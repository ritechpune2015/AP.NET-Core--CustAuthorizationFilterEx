using Microsoft.AspNetCore.Mvc;

namespace CustAuthorizationFilterEx.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
