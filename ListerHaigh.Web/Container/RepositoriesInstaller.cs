using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using ListerHaigh.Repositories;
namespace ListerHaigh.Web.Container
{
    public class RepositoriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IDepartmentManager>().ImplementedBy<DepartmentManager>());
        }
    }
}