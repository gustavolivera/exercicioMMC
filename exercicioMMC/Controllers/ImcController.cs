using exercicioMMC.Models;
using Microsoft.AspNetCore.Mvc;


namespace exercicioMMC.Controllers
{
	public class ImcController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Calcular(ImcModel valores) {
			ModelState.Clear();
			valores.Calcular();
			return View("Index", valores);
		}
	}
}
