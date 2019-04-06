using MVCdotNetBaseApp.Domain.Entities.Formulario;


namespace MVCdotNetBaseApp.Data.Mapping
{
	public class CampoMapping : BaseMapping<Campo>
	{
		public CampoMapping()
		{
			Property(x => x.Descricao)
				.IsOptional()
				.HasMaxLength(50);

			Property(x => x.Tipo)
				.IsRequired();

			Property(x => x.TipoValor)
				.IsRequired();

			HasRequired(cmp => cmp.Formulario)
				.WithMany()
				.HasForeignKey(cmp => cmp.FormularioId);
		}
	}
}