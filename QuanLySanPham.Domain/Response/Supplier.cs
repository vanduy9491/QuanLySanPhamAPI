using QuanLySanPham.API.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySanPham.Domain.Response
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        
    }
}
