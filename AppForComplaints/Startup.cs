using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppForComplaints.Startup))]
namespace AppForComplaints
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
