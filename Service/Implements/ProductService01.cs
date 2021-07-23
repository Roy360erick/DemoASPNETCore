using Common.HttpHelpers;
using Domain;
using Infraestructure.DataContext;
using Microsoft.EntityFrameworkCore;
using Service.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implements
{
    public class ProductService01 : IProductService
    {
        private readonly DBContext _context;

        public ProductService01(DBContext context)
        {
            _context = context;
        }


        public async Task<EResponseBase<Product>> Delete(int Id)
        {
            EResponseBase<Product> response = new EResponseBase<Product>();

            try
            {
                var product = await _context.Products.Where(x => x.Id == Id).FirstAsync();
                product.Enabled = false;
                await _context.SaveChangesAsync();
                response.IsResultList = true;
                response.objeto = product;
            }
            catch (Exception ex)
            {
                response.MessageEN = ex.Message;
            }

            return response;
        }

        public async Task<EResponseBase<Product>> Get()
        {
            EResponseBase<Product> response = new EResponseBase<Product>();

            try
            {
                var products = await _context.Products.ToListAsync();
                response.IsResultList = true;
                response.listado = products;
            }
            catch (Exception ex)
            {
                response.MessageEN = ex.Message;
            }

            return response;
        }

        public async Task<EResponseBase<Product>> GetById(int Id)
        {
            EResponseBase<Product> response = new EResponseBase<Product>();

            try
            {
                var product = await _context.Products.Where(x => x.Id == Id).FirstAsync();
                response.IsResultList = true;
                response.objeto = product;
            }
            catch (Exception ex)
            {
                response.MessageEN = ex.Message;
            }

            return response;
        }

        public async Task<EResponseBase<Product>> Post(Product product)
        {
            EResponseBase<Product> response = new EResponseBase<Product>();

            try
            {
                product.Enabled = true;
                _context.Add(product);
                await _context.SaveChangesAsync();
                response.IsResultList = true;
                response.objeto = product;
            }
            catch (Exception ex)
            {
                response.MessageEN = ex.Message;
            }

            return response;
        }

        public async Task<EResponseBase<Product>> Put(Product product)
        {
            EResponseBase<Product> response = new EResponseBase<Product>();

            try
            {
                product.Enabled = true;
                _context.Update(product);
                await _context.SaveChangesAsync();
                response.IsResultList = true;
                response.objeto = product;
            }
            catch (Exception ex)
            {
                response.MessageEN = ex.Message;
            }

            return response;
        }
    }
}
