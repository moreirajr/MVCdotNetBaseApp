using MVCdotNetBaseApp.Domain.Entities.Base.Services;
using MVCdotNetBaseApp.Domain.Entities.Formulario.Interfaces;
using MVCdotNetBaseApp.Domain.Entities.Formulario.Validations;
using System;


namespace MVCdotNetBaseApp.Domain.Entities.Formulario.Services
{
	public class FormularioService : BaseService<Formulario>, IFormularioService
	{
		private readonly IFormularioRepository _formularioRepository;
		public FormularioService(IFormularioRepository formularioRepository) : base(formularioRepository)
		{
			_formularioRepository = formularioRepository;
		}

		public override Formulario Add(Formulario obj)
		{
			var validationResult = new FormularioIsValid().Validate(obj);
			string errors = "";

			if (IsValid(validationResult, out errors))
				_formularioRepository.Add(obj);
			else
				obj.ValidationMessage = errors;

			return obj;
		}

		public override Formulario Update(Formulario obj)
		{
			var validationResult = new FormularioIsValid().Validate(obj);
			string errors = "";

			if (IsValid(validationResult, out errors))
				_formularioRepository.Update(obj);
			else
				obj.ValidationMessage = errors;

			return obj;
		}

		public override Formulario Delete(Guid id)
		{
			var obj = _formularioRepository.GetById(id);

			var validationResult = new FormularioIsValid().Validate(obj);
			string errors = "";

			if (IsValid(validationResult, out errors))
				_formularioRepository.Delete(obj);
			else
				obj.ValidationMessage = errors;

			return obj;
		}
	}
}
