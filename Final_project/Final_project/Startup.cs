using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Final_project.Startup))]
namespace Final_project
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
