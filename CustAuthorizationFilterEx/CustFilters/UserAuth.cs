using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CustAuthorizationFilterEx.CustFilters
{
	public class UserAuth : ActionFilterAttribute, IAuthorizationFilter
	{
		public void OnAuthorization(AuthorizationFilterContext context)
		{
			if (context.HttpContext.Session.GetString("UserID") == null)
			{
				context.Result = new RedirectToRouteResult(new {action="SignIn",controller="ManageUser",area=""});
			}
		}
	}
}
