using System;
using System.Threading.Tasks;
using AzureAD.Configuration;
using Microsoft.Owin;
using Owin;

namespace NETFrameworkTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            AzureDependencyInjection.ConfigureAzureDependencyService(app);
            //ConfigureAuth(app);
        }
    }
}
