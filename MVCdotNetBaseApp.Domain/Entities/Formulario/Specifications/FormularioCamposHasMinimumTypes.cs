using DomainValidation.Interfaces.Specification;
using System.Linq;

namespace MVCdotNetBaseApp.Domain.Entities.Formulario.Specifications
{
	public class FormularioCamposHasMinimumTypes : ISpecification<Formulario>
	{
		public bool IsSatisfiedBy(Formulario entity)
		{
			return entity.Campos.Select(x => x.Tipo).Distinct().Count() < 3;
		}
	}
}
