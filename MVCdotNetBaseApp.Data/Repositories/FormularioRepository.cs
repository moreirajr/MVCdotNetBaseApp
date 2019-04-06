using MVCdotNetBaseApp.Data.Context;
using MVCdotNetBaseApp.Domain.Entities.Formulario;
using MVCdotNetBaseApp.Domain.Entities.Formulario.Interfaces;


namespace MVCdotNetBaseApp.Data.Repositories
{
	public class FormularioRepository : BaseRepository<Formulario>, IFormularioRepository
	{
		private readonly ApplicationDatabaseContext _applicationDatabaseContext;

		public FormularioRepository(ApplicationDatabaseContext applicationDatabaseContext) : base(applicationDatabaseContext)
		{
			_applicationDatabaseContext = applicationDatabaseContext;
		}
	}
}