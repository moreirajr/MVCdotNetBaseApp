using System.ComponentModel.DataAnnotations;


namespace MVCdotNetBaseApp.Util.Enums
{
	public enum ETipoValor
	{
		Texto = 1,
		[Display(Name = "Numérico")]
		Numerico = 2,
		Moeda = 4,
		Data = 8
	}
}
