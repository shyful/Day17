using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalculatorApp_10_1_15.Startup))]
namespace CalculatorApp_10_1_15
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
