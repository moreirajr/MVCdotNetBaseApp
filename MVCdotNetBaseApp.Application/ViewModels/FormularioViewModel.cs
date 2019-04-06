using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCdotNetBaseApp.Application.ViewModels
{
	public class FormularioViewModel : BaseViewModel
	{
		public string Nome { get; set; }

		public DateTime DataInicio { get; set; }

		public DateTime? DataFim { get; set; }

		public ICollection<CampoViewModel> Campos { get; set; }
	}
}
