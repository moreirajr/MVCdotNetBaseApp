using MVCdotNetBaseApp.Application.ViewModels;
using MVCdotNetBaseApp.Domain.Entities.Formulario;


namespace MVCdotNetBaseApp.Application.Interfaces
{
	public interface IFormularioAppService : IBaseAppService<Formulario, FormularioViewModel>
	{
	}
}
