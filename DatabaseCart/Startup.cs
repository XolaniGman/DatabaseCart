using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DatabaseCart.Startup))]
namespace DatabaseCart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
