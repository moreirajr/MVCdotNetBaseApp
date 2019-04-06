using MVCdotNetBaseApp.Application.Interfaces;
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
  }
}
