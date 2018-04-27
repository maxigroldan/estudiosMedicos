using System;
using Unity;

namespace EstudiosMedicos.IoC
{
    public class IoC
    {
        private static UnityContainer _container { get; set; }
        public static UnityContainer Container
        {
            get
            {
                if (_container == null)
                    CreateContainer();
                return _container;
            }
        }

        private static void CreateContainer()
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            _container = container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            var assembly = System.Reflection.Assembly.Load("EstudiosMedicos.Services");

            var types = assembly.GetTypes();

            //EstudiosMedicos.Data

            // Components
            /*container.RegisterType(.RegisterType(
                AllClasses.FromAssemblies(typeof(UnityConfig).Assembly),
                WithMappings.FromMatchingInterface,
                WithName.Default);*/

        }
    }
}
