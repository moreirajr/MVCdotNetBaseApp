using DomainValidation.Interfaces.Specification;


namespace MVCdotNetBaseApp.Domain.Entities.Formulario.Specifications
{
	public class FormularioHasDate : ISpecification<Formulario>
	{
		public bool IsSatisfiedBy(Formulario entity)
		{
			return entity.DataInicio.HasValue || entity.DataFim.HasValue;
		}
	}
}
