using System.Threading.Tasks;
using Statiq.App;
using Statiq.Common;
using Statiq.Web;

namespace Blog
{
    public class Program
    {
        public static async Task<int> Main(string[] args) =>
          await Bootstrapper
            .Factory
            .CreateWeb(args)
            .DeployToNetlify(
              "alexmg.netlify.com",
              Config.FromSetting<string>("NETLIFY_TOKEN"))
            .RunAsync();
    }
}
