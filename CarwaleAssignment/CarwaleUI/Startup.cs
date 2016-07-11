using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarwaleUI.Startup))]
namespace CarwaleUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
