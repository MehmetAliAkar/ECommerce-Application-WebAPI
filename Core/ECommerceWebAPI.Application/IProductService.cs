using ECommerceWebAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceWebAPI.Application
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}