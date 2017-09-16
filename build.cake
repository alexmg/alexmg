#tool nuget:?package=Wyam
#addin nuget:?package=Cake.Wyam

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Build")
    .Does(() =>
    {
        Wyam(new WyamSettings
        {
            Recipe = "Blog",
            Theme = "CleanBlog",
            UpdatePackages = true
        });        
    });
    
Task("Preview")
    .Does(() =>
    {
        Wyam(new WyamSettings
        {
            Recipe = "Blog",
            Theme = "CleanBlog",
            UpdatePackages = true,
            Preview = true,
            Watch = true
        });        
    });

Task("Debug")
    .Does(() =>
    {
        StartProcess("../Wyam/src/clients/Wyam/bin/Debug/wyam.exe",
            "-a \"../Wyam/src/**/bin/Debug/*.dll\" -r \"blog -i\" -t \"../Wyam/themes/Blog/CleanBlog\" -p -w");
    });

Task("Mono")
    .Does(() =>
    {
        StartProcess(@"c:\Program Files\Mono\bin\mono.exe", "../Wyam/src/clients/Wyam/bin/Debug/wyam.exe " +
            "-a \"../Wyam/src/**/bin/Debug/*.dll\" -r \"blog -i\" -t \"../Wyam/themes/Blog/CleanBlog\" -p --verbose");
    });

Task("Deploy")
    .Does(() =>
    {
        string variable = "netlify_token";
        string token = EnvironmentVariable(variable);
        if (string.IsNullOrEmpty(token))
        {
            throw new Exception("Could not get " + variable + " environment variable");
        }
        
        Zip("./output", "output.zip", "./output/**/*");
        StartProcess("curl", "--header \"Content-Type: application/zip\" --header \"Authorization: Bearer " + token + "\" --data-binary \"@output.zip\" --url https://api.netlify.com/api/v1/sites/alexmg.netlify.com/deploys");
    });
    
//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Preview");    
    
Task("AppVeyor")
    .IsDependentOn("Build")
    .IsDependentOn("Deploy");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);
