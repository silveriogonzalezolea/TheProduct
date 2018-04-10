using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheBoredProfessor.Startup))]
namespace TheBoredProfessor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
