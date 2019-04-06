using MVCdotNetBaseApp.Domain.Entities.Base;
using System;

namespace MVCdotNetBaseApp.Domain.Entities.Formulario
{
	public class Campo : BaseEntity
	{
		public string Descricao { get; set; }

		public string Tipo { get; set; }

		public string TipoValor { get; set; }

		public Guid FormularioId { get; set; }
		public virtual Formulario Formulario { get; set; }
	}
}
