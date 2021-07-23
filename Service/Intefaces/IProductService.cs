using Common.HttpHelpers;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Intefaces
{
    public interface IProductService 
    {
        Task<EResponseBase<Product>> Get();
        Task<EResponseBase<Product>> GetById(int Id);
        Task<EResponseBase<Product>> Post(Product product);
        Task<EResponseBase<Product>> Put(Product product);
        Task<EResponseBase<Product>> Delete(int Id);
    }
}
