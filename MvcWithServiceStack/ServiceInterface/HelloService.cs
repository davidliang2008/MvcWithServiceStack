using MvcWithServiceStack.Models.Hello;
using ServiceStack.Configuration;

namespace MvcWithServiceStack.ServiceInterface
{
    public class HelloService : ServiceBase
    {
        public IAppSettings AppSettings { get; set; }

        // Commenting this out will give you a NULL reference on AppSettings
        //public HelloService()
        //{
        //    var test = AppSettings.Get<string>("custom");
        //}

        public object Get(HelloRequest request)
        {
            return new HelloResponse
            {
                Result = $"Hello, { request.Name }! Your custom value is { AppSettings.Get<string>("custom") }."
            };
        }
    }
}