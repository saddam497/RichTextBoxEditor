using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RTBEditor.Startup))]
namespace RTBEditor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
