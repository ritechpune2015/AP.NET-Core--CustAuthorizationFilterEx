using CustAuthorizationFilterEx.Models;
using CustAuthorizationFilterEx.ViewModels;

namespace CustAuthorizationFilterEx.Repositories
{
	public class UserRepo : IUser
	{
		CompanyContext cc;
		public UserRepo(CompanyContext cc)
		{ 
		  this.cc = cc;
		}


		public LoginResultVM Login(LoginVM rec)
		{
			var urec = this.cc.Users.SingleOrDefault(p=>p.EmailID == rec.EmailID && p.Password == rec.Password);
			LoginResultVM res = new LoginResultVM();
			if (urec != null)
			{
				res.IsSuccess = true;
				res.UserID = urec.UserID;
				res.FullName = urec.FullName;
			}
			else
			{
				res.IsSuccess = false;
			}

			return res;
		}

		public bool Register(RegistrationVM rec)
		{
			try
			{
				User urec = new User()
				{
					FirstName = rec.FirstName,
					LastName = rec.LastName,
					EmailID = rec.EmailID,
					Password = rec.Password,
					Address = rec.Address,
					MobileNo = rec.MobileNo
				};

				this.cc.Users.Add(urec);
				this.cc.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
