using CustAuthorizationFilterEx.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CustAuthorizationFilterEx.Areas.UserArea.Controllers
{
	[Area("UserArea")]
	public class UserHomeController : Controller
	{
		IProduct repo;
		public UserHomeController(IProduct repo)
		{
			this.repo = repo;
		}

		public IActionResult Index()
		{
			var res = this.repo.GetAll();
			return View(res);
		}
	}
}
