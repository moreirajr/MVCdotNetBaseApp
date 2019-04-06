using DomainValidation.Interfaces.Specification;
using System.Linq;


namespace MVCdotNetBaseApp.Domain.Entities.Formulario.Specifications
{
	public class FormularioHasCampos : ISpecification<Formulario>
	{
		public bool IsSatisfiedBy(Formulario entity)
		{
			return entity.Campos.Any() && entity.Campos.Count < 10;
		}
	}
}
