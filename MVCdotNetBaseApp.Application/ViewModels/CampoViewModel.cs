using System;


namespace MVCdotNetBaseApp.Application.ViewModels
{
	public class CampoViewModel : BaseViewModel
	{
		public string Descricao { get; set; }

		public string Tipo { get; set; }

		public string TipoValor { get; set; }

		public Guid FormularioId { get; set; }
		public virtual FormularioViewModel Formulario { get; set; }
	}
}
