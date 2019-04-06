using DomainValidation.Interfaces.Specification;
using System;


namespace MVCdotNetBaseApp.Domain.Entities.Base.Specifications
{
	public class EntityHasValidId : ISpecification<BaseEntity>
	{
		public bool IsSatisfiedBy(BaseEntity entity)
		{
			return entity.Id != Guid.Empty;
		}
	}
}
