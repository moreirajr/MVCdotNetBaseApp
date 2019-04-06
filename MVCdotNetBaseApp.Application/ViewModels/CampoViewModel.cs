using MVCdotNetBaseApp.Util.Enums;
using System;


namespace MVCdotNetBaseApp.Application.ViewModels
{
	public class CampoViewModel : BaseViewModel
	{
		public string Descricao { get; set; }

		public ETipoCampo Tipo { get; set; }

		public ETipoValor TipoValor { get; set; }

		public Guid FormularioId { get; set; }
		public virtual FormularioViewModel Formulario { get; set; }
	}
}
