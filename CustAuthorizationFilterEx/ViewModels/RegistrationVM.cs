using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustAuthorizationFilterEx.ViewModels
{
	public class RegistrationVM
	{
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		[Required]
		[EmailAddress]
		public string EmailID { get; set; }
		[Required]
		[RegularExpression(@"^\d{10}$",ErrorMessage ="10 digits required")]
		public string MobileNo { get; set; }
		[Required]
		public string Address { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[Required]
		[DataType(DataType.Password)]
		public string CofirmPassword { get; set; }
	}
}
