#tool "nuget:https://api.nuget.org/v3/index.json?package=Wyam&version=2.2.7"
#addin "nuget:https://api.nuget.org/v3/index.json?package=Cake.Wyam&version=2.2.7"
#addin "nuget:https://api.nuget.org/v3/index.json?package=NetlifySharp&version=0.1.0"

using NetlifySharp;

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
        DotNetCoreBuild("../Wyam/tests/integration/Wyam.Examples.Tests/Wyam.Examples.Tests.csproj");        
        DotNetCoreExecute("../Wyam/tests/integration/Wyam.Examples.Tests/bin/Debug/netcoreapp2.1/Wyam.dll",
            "-a \"../Wyam/tests/integration/Wyam.Examples.Tests/bin/Debug/netcoreapp2.1/**/*.dll\" -r \"blog -i\" -t \"../Wyam/themes/Blog/CleanBlog\" -pw --attach");
    });

Task("Netlify")
    .Does(() =>
    {
        string netlifyToken = EnvironmentVariable("netlify_token");
        if (string.IsNullOrEmpty(netlifyToken))
        {
            throw new Exception("Could not get Netlify token environment variable");
        }

        Information("Deploying output to Netlify");
        var client = new NetlifyClient(netlifyToken);
        client.UpdateSite("alexmg.netlify.com", MakeAbsolute(Directory("./output")).FullPath).SendAsync().Wait();
    });
    
//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Preview");    
    
Task("AppVeyor")
    .IsDependentOn("Build")
    .IsDependentOn("Netlify");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);
