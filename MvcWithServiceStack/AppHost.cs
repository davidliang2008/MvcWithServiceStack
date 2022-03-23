using Funq;
using ServiceStack;
using ServiceStack.Mvc;
using System.Web.Mvc;

namespace MvcWithServiceStack
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("MvcWithServiceStack", typeof(AppHost).Assembly)
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