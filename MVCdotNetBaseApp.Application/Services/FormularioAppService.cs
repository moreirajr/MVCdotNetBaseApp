using MVCdotNetBaseApp.Application.Interfaces;
using MVCdotNetBaseApp.Application.ViewModels;
using MVCdotNetBaseApp.Domain.Entities.Formulario;
using MVCdotNetBaseApp.Domain.Entities.Formulario.Interfaces;
using System.Linq;

namespace MVCdotNetBaseApp.Application.Services
{
	public class FormularioAppService : BaseAppService<Formulario, FormularioViewModel>, IFormularioAppService
	{
		private readonly IFormularioService _formularioService;

		public FormularioAppService(IFormularioService formularioService) : base(formularioService)
		{
			_formularioService = formularioService;
		}

		public override FormularioViewModel Update(FormularioViewModel viewModel)
		{
			var formulario = _formularioService.GetById(viewModel.Id);

			formulario.Nome = viewModel.Nome;
			formulario.DataInicio = viewModel.DataInicio;
			formulario.DataFim = viewModel.DataFim;

			formulario.Campos = viewModel.Campos
				.Select(x => new Campo
				{
					Id = x.Id,
					Descricao = x.Descricao,
					Tipo = x.Tipo,
					TipoValor = x.TipoValor,
					FormularioId = x.FormularioId
				}).ToList();

			_formularioService.Update(formulario);
			viewModel.ValidationMessage = formulario.ValidationMessage;

			return viewModel;
		}
	}
}
