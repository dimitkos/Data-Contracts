using API.Implementation;
using API.Interfaces;
using Data_Contracts.Models;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.ModelBinding;
using System.Web.Routing;

namespace Data_Contracts
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var container = new Container();

            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            container.Register<IApiImplementation, MainImplementation>(Lifestyle.Scoped);


            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            GlobalConfiguration.Configure(WebApiConfig.Register);
            //GlobalConfiguration.Configuration.Services.Replace(typeof(IAssembliesResolver), new MyCustomAssemblyResolver());
            //ModelBinders.Binders.Add(typeof(UsageModel), new CustomModelBinder<UsageModel>());

        }
    }
}
