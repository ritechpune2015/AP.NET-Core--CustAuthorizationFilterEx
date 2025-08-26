using System.ComponentModel.DataAnnotations.Schema;

namespace CustAuthorizationFilterEx.Models
{
	public class User
	{
		public Int64 UserID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		[NotMapped]
		public string FullName {
			get
			{
				return $"{LastName} {FirstName}";
			}
		}
		public string EmailID { get; set; }
		public string MobileNo { get; set; }
		public string Address { get; set; }
		public string Password { get; set; }
	}
}
