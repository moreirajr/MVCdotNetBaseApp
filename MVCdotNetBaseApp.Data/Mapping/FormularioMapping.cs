using MVCdotNetBaseApp.Domain.Entities.Formulario;


namespace MVCdotNetBaseApp.Data.Mapping
{
	public class FormularioMapping : BaseMapping<Formulario>
	{
		public FormularioMapping()
		{
			Property(x => x.Nome)
				.IsRequired()
				.HasMaxLength(70);

			Property(x => x.DataInicio)
				.IsRequired();

			Property(x => x.DataFim)
				.IsOptional();

			HasMany(frm => frm.Campos)
				.WithRequired()
				.HasForeignKey(cmp => cmp.FormularioId);
		}
	}
}