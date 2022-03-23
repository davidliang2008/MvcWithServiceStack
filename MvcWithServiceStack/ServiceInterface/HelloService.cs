using MvcWithServiceStack.Models.Hello;

namespace MvcWithServiceStack.ServiceInterface
{
    public class HelloService : ServiceBase
    {
        public object Get(HelloRequest request)
        {
            return new HelloResponse
            {
                Result = $"Hello, { request.Name }! Your custom value is { AppSettings.Get<string>("custom") }."
            };
        }
    }
}