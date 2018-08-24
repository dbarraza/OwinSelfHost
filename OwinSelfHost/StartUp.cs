using Owin;

namespace OwinSelfHost
{
    public class StartUp
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.UseWelcomePage();
        }
    }
}
