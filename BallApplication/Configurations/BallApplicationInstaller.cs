using BallApplication.Services.Interface;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace BallApplication.Configurations
{
    public class BallApplicationInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                       .BasedOn(typeof(IService))
                       .WithServiceAllInterfaces()
                       .LifestyleScoped());
        }
    }
}
