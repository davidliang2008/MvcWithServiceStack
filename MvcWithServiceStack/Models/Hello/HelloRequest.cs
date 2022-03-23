using ServiceStack;

namespace MvcWithServiceStack.Models.Hello
{
    [Route("/hello/{name}")]
    public class HelloRequest : IReturn<HelloResponse>
    {
        public string Name { get; set; }
    }
}