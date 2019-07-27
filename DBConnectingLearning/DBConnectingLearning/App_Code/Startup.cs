using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DBConnectingLearning.Startup))]
namespace DBConnectingLearning
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
