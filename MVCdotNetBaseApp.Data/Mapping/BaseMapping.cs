using MVCdotNetBaseApp.Domain.Entities.Base;
using System.Data.Entity.ModelConfiguration;


namespace MVCdotNetBaseApp.Data.Mapping
{
	public class BaseMapping<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : BaseEntity
	{
		public BaseMapping()
		{
			HasKey(x => x.Id);
		}
	}
}
