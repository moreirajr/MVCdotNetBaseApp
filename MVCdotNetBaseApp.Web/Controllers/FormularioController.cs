using MVCdotNetBaseApp.Application.Interfaces;
using MVCdotNetBaseApp.Util.Enums;
using System;
using System.Linq;
using System.Web.Mvc;

namespace MVCdotNetBaseApp.Web.Controllers
{
  public class FormularioController : Controller
  {
    private readonly IFormularioAppService _formularioAppService;

    public FormularioController(IFormularioAppService formularioAppService)
    {
      _formularioAppService = formularioAppService;
    }

    public ActionResult Index()
    {
      return View();
    }

    public JsonResult CampoTipo()
    {
      var values = Enum.GetNames(typeof(ETipoCampo)).Select(x => new
      {
        Value = x.ToString(),
        Text = Enum.GetName(typeof(ETipoCampo), x)
      });

      return Json(values, JsonRequestBehavior.AllowGet);
    }

    public JsonResult CampoTipoValor()
    {
      var values = Enum.GetNames(typeof(ETipoValor)).Select(x => new
      {
        Value = x.ToString(),
        Text = Enum.GetName(typeof(ETipoValor), x)
      });

      return Json(values, JsonRequestBehavior.AllowGet);
    }

  }
}
