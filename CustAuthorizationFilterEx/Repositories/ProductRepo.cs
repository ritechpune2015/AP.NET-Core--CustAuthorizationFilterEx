using CustAuthorizationFilterEx.Models;

namespace CustAuthorizationFilterEx.Repositories
{
	public class ProductRepo : IProduct
	{
		CompanyContext cc;
		public ProductRepo(CompanyContext cc)
		{
			this.cc = cc;
		}

		public List<Product> GetAll()
		{
			return this.cc.Products.ToList();
		}
	}
}
