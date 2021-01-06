using System.Web.Mvc;
using Microsoft.Practices.Unity;
using NetC.JuniorDeveloperExam.Web.Services;
using Unity.Mvc3;

namespace NetC.JuniorDeveloperExam.Web
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IJsonService, JsonService>();
            

            return container;
        }
    }
}