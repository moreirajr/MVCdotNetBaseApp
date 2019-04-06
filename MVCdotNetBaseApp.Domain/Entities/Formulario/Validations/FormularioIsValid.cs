using DomainValidation.Validation;
using MVCdotNetBaseApp.Domain.Entities.Base.Specifications;
using MVCdotNetBaseApp.Domain.Entities.Formulario.Specifications;

namespace MVCdotNetBaseApp.Domain.Entities.Formulario.Validations
{
	public class FormularioIsValid : Validator<Formulario>
	{
		public FormularioIsValid()
		{
			var idIsValid = new EntityHasValidId();
			var formularioHasCampos = new FormularioHasCampos();
			var formularioCamposHasMinimumTypes = new FormularioCamposHasMinimumTypes();
			var formularioHasDate = new FormularioHasDate();

			base.Add("idIsValid", new Rule<Formulario>(idIsValid, "Id inválido"));
			base.Add("formularioHasCampos", new Rule<Formulario>(formularioHasCampos, "O formulário deve ter no mínimo 10 campos."));
			base.Add("formularioCamposHasMinimumTypes", new Rule<Formulario>(formularioCamposHasMinimumTypes, "O formulário deve ter pelo menos 3 campos distintos."));
			base.Add("formularioHasDate", new Rule<Formulario>(formularioHasDate, "O formulário deve ter data inicial ou data final preenchida."));
		}
	}
}
