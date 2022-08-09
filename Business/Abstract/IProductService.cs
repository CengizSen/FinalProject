using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IProductService
    {
        
        IDataResult<List<Product>> GetAll();//Bütün datayı getirir
        IDataResult< List<Product>> GetAllByCategoryId(int id);//Category datasını verilen category Idsine göre getirir   
        IDataResult <List<Product>> GetByUnitPrice(decimal min, decimal max);//Belirtilen fiyat aralığındaki verileri getirir.
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult <Product> GetById(int productId);
        IResult Add(Product product);
        IResult Update(Product product);
     }
}
