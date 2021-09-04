using QuanLySanPham.API.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham.Service
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> Get();
    }
}
