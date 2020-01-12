using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentIdentity.Startup))]
namespace StudentIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
