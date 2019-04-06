using MVCdotNetBaseApp.Domain.Entities.Base;
using MVCdotNetBaseApp.Util.Enums;
using System;


namespace MVCdotNetBaseApp.Domain.Entities.Formulario
{
	public class Campo : BaseEntity
	{
		public string Descricao { get; set; }

		public ETipoCampo Tipo { get; set; }

		public ETipoValor TipoValor { get; set; }

		public Guid FormularioId { get; set; }
		public virtual Formulario Formulario { get; set; }
	}
}
