using Dapper;
using QuanLySanPham.API.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham.Service
{
    public class ProductService : BaseService, IProductService
    {
        public async Task<IEnumerable<Product>> Get()
        {
            var products = await SqlMapper.QueryAsync<Product>(cnn: connection, sql: "GetAllProduct", commandType: System.Data.CommandType.StoredProcedure);
            return products;
        }
    }
}
