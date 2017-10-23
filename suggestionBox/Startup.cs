using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(suggestionBox.Startup))]
namespace suggestionBox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
