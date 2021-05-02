using blazor_serverside_crud_operation.DataAccess;
using blazor_serverside_crud_operation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_serverside_crud_operation.Service
{
	public class ProductService
	{
        private readonly IProductAccessLayer objproduct;

        public ProductService(IProductAccessLayer _objproduct)
        {
            objproduct = _objproduct;
        }

        public Task<List<Product>> GetProductList()
        {
            return Task.FromResult(objproduct.GetProductList());
        }

        public void Create(Product Product)
        {
            objproduct.AddProduct(Product);
        }
        public Task<Product> Details(Guid id)
        {
            return Task.FromResult(objproduct.GetProductData(id));
        }

        public void Edit(Product product)
        {
            objproduct.UpdateProduct(product);
        }

        public void Delete(Guid id)
        {
            objproduct.DeleteProduct(id);
        }
    }
}
