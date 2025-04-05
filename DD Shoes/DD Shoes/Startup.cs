using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DD_Shoes.Startup))]
namespace DD_Shoes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
