using System.Web.Http;
using Owin;
using OwinSelfHost.Components;

namespace OwinSelfHost
{
    public class StartUp
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.Use<LoggerComponent>();
            ConfigWebApi(appBuilder);
            appBuilder.Use<CustomPageComponent>();
        }

        private void ConfigWebApi(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new {id = RouteParameter.Optional});

            appBuilder.UseWebApi(config);
        }
    }
}
