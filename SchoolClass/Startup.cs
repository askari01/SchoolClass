using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolClass.Startup))]
namespace SchoolClass
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
