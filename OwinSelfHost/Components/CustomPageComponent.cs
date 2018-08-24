using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace OwinSelfHost.Components
{
    using AppFunc = Func<IDictionary<string,object>,Task>;

    public class CustomPageComponent
    {
        private readonly AppFunc _next;

        public CustomPageComponent(AppFunc next)
        {
            _next = next;
        }
        
        //Comment from GitHub
        public async Task Invoke(IDictionary<string, object> enviroment)
        {
            var response = enviroment["owin.ResponseBody"] as Stream;
            using (var writer = new StreamWriter(response))
            {
                await writer.WriteAsync("Welcome to my custom page");
                await _next(enviroment);
            }
        }
    }
}
