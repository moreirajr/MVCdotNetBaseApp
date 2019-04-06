using MVCdotNetBaseApp.Domain.Entities.Base;
using System;
using System.Collections.Generic;


namespace MVCdotNetBaseApp.Domain.Entities.Formulario
{
	public class Formulario : BaseEntity
	{
		public Formulario()
		{
			Campos = new List<Campo>();
		}

		public string Nome { get; set; }

		public DateTime? DataInicio { get; set; }

		public DateTime? DataFim { get; set; }

		public virtual ICollection<Campo> Campos { get; set; }
	}
}