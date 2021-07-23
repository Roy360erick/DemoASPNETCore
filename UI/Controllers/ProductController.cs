using AutoMapper;
using Common.HttpHelpers;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Models;
using Service.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<EResponseBase<ProductV1>> Get()
        {
            var response = await _productService.Get();

            var result = _mapper.Map<EResponseBase<Product>, EResponseBase<ProductV1>>(response);

            return result;
        }

        [HttpGet("{Id}")]
        public async Task<EResponseBase<Product>> Get(int Id)
        {
            return await _productService.GetById(Id);
        }

        [HttpPost]
        public async Task<EResponseBase<Product>> Post(Product product)
        {
            return await _productService.Post(product);
        }
    }
}
