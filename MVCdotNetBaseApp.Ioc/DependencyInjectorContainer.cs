using MVCdotNetBaseApp.Data.Context;
using MVCdotNetBaseApp.Data.Repositories;
using MVCdotNetBaseApp.Domain.Entities.Base.Interfaces;
using SimpleInjector;


namespace MVCdotNetBaseApp.Ioc
{
    public class DependencyInjectorContainer
    {
        public static void Register(Container container)
        {
            container.Register<ApplicationDatabaseContext>(Lifestyle.Scoped);

            container.Register(typeof(IBaseRepository<>), typeof(BaseRepository<>), Lifestyle.Scoped);
        }
    }
}
