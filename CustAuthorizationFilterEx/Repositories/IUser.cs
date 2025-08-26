using CustAuthorizationFilterEx.ViewModels;

namespace CustAuthorizationFilterEx.Repositories
{
	public interface IUser
	{
 	   LoginResultVM Login(LoginVM rec);
		bool Register(RegistrationVM rec);
	}
}
