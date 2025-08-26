using CustAuthorizationFilterEx.Repositories;
using CustAuthorizationFilterEx.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CustAuthorizationFilterEx.Controllers
{
	 
	public class ManageUserController : Controller
	{
		IUser repo;
		public ManageUserController(IUser repo) {
			this.repo = repo;
		}

		[HttpGet]
		public IActionResult SignIn()
		{
			return View();
		}

		[HttpPost]
		public IActionResult SignIn(LoginVM rec)
		{
			if (ModelState.IsValid)
			{
				var res = this.repo.Login(rec);
				if (res.IsSuccess)
				{
					TempData["UserName"] = res.FullName;
					return RedirectToAction("Index", "UserHome", new { area = "UserArea" });
				}
				else
				{
					ModelState.AddModelError("", "Invalid Email Id or Password!");
				}
			}
			return View(rec);
		}

		[HttpGet]
		public IActionResult SignUp()
		{
			return View();
		}

		[HttpPost]
		public IActionResult SignUp(RegistrationVM rec)
		{
			if (ModelState.IsValid)
			{
				var res=this.repo.Register(rec);
				if (res)
				{
					return RedirectToAction("SignIn");
				}
				else
				{
					ModelState.AddModelError("", "Can not register");
				}
			}
			return View(rec);
		}

	}
}
