using MVCdotNetBaseApp.Application.Interfaces;
using MVCdotNetBaseApp.Application.Services;
using MVCdotNetBaseApp.Data.Context;
using MVCdotNetBaseApp.Data.Repositories;
using MVCdotNetBaseApp.Domain.Entities.Base.Interfaces;
using MVCdotNetBaseApp.Domain.Entities.Formulario.Interfaces;
using MVCdotNetBaseApp.Domain.Entities.Formulario.Services;
using SimpleInjector;


namespace MVCdotNetBaseApp.Ioc
{
	public class DependencyInjectorContainer
	{
		public static void Register(Container container)
		{
			container.Register<ApplicationDatabaseContext>(Lifestyle.Scoped);

			container.Register(typeof(IBaseRepository<>), typeof(BaseRepository<>), Lifestyle.Scoped);

			#region AppServices
			container.Register<IFormularioAppService, FormularioAppService>(Lifestyle.Scoped);
			#endregion

			#region Services
			container.Register<IFormularioService, FormularioService>(Lifestyle.Scoped);
			#endregion

			#region Repositories
			container.Register<IFormularioRepository, FormularioRepository>(Lifestyle.Scoped);
			#endregion
		}
	}
}
