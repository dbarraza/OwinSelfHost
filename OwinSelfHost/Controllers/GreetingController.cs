using System.Web.Http;
using OwinSelfHost.Model;

namespace OwinSelfHost.Controllers
{
    public class GreetingController : ApiController
    {
        public Greeting Get()
        {
            return new Greeting
            {
                Text = "This is an WebApi"
            };
        }
    }
}
