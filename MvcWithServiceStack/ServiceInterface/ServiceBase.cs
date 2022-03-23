using ServiceStack;
using ServiceStack.Configuration;

namespace MvcWithServiceStack.ServiceInterface
{
    public abstract class ServiceBase : Service
    {
        public IAppSettings AppSettings { get; }
    }
}