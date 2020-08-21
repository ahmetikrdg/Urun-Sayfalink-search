using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.business.Abstract
{
    public interface IProductServices
    {
         Product GetById(int id);
         Product GetProductDetails(int id);
         Product GetProductDetails(string Url);
         List<Product> GetProductsByCategory(string name,int page,int pageSize);
         int GetCountByCategory(string category);
         List<Product> GetHomePageProducts();
         List<Product> GetSearchResult(string Search);
         List<Product> GetAll();
         void Create(Product entity);
         void Update(Product entity);
         void Delete(Product entity);
    }
}