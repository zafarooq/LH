using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using ListerHaigh.Repositories;

namespace ListerHaigh.Resolvers
{
    public class RepositoriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IDepartmentManager>().ImplementedBy<DepartmentManager>());
            container.Register(Component.For<IEventManager>().ImplementedBy<EventManager>());
        }
    }
}