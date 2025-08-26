using System.ComponentModel.DataAnnotations;

namespace CustAuthorizationFilterEx.ViewModels
{
	public class LoginVM
	{
		[Required(ErrorMessage ="Email ID Required")]
		[EmailAddress(ErrorMessage ="Invlaid Email ID")]
		public string EmailID { get; set; }
		[Required(ErrorMessage ="Password Required")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}
