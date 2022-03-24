using Funq;
using MvcWithServiceStack.ServiceInterface;
using ServiceStack;
using ServiceStack.Mvc;
using System.Web.Mvc;

namespace MvcWithServiceStack
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("MvcWithServiceStack", typeof(ServiceBase).Assembly)
        {
        }

        public override void Configure(Container container)
        {
            SetConfig(new HostConfig
            {
                HandlerFactoryPath = "api"
            });

            ControllerBuilder.Current.SetControllerFactory(new FunqControllerFactory(container));
        }
    }
}