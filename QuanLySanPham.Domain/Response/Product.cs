using QuanLySanPham.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySanPham.API.Controllers
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public long Price { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }
        public string Category { get; set; }
        public int SupplierId { get; set; }
        public string Supplier { get; set; }
    }
}
