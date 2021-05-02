using blazor_serverside_crud_operation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_serverside_crud_operation.DataAccess
{
	public interface IProductAccessLayer
	{
		public List<Product> GetProductList();
		public void AddProduct(Product product);
		public void UpdateProduct(Product product);
		public Product GetProductData(Guid id);
		public void DeleteProduct(Guid id);
	}
	public class ProductAccessLayer : IProductAccessLayer
	{
		private readonly InventoryContext _context;
		public ProductAccessLayer(InventoryContext context)
		{
			_context = context;
		}
		public List<Product> GetProductList()
		{
			return _context.Products.AsNoTracking().ToList();
		}
		public void AddProduct(Product product)
		{
			_context.Products.Add(product);
			_context.SaveChanges();
		}

		public void DeleteProduct(Guid id)
		{
			Product product = _context.Products.Find(id);
			_context.Products.Remove(product);
			_context.SaveChanges();
		}

		

		public Product GetProductData(Guid id)
		{
			Product product = _context.Products.Find(id);
			return product;
		}

		public void UpdateProduct(Product product)
		{
			_context.Entry(product).State = EntityState.Modified;
			_context.SaveChanges();
		}
	}
}
