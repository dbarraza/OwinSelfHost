using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OwinSelfHost.Components
{
    using AppFunc = Func<IDictionary<string,object>,Task>;

    public class LoggerComponent
    {
        private readonly AppFunc _next;

        public LoggerComponent(AppFunc next)
        {
            _next = next;
        }

        public async Task Invoke(IDictionary<string, object> enviroment)
        {
            Console.WriteLine(enviroment["owin.RequestPath"]);
            Console.WriteLine(enviroment["owin.ResponseStatusCode"]);
            await _next(enviroment);
        }
    }
}
