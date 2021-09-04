using QuanLySanPham.API.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySanPham.Domain.Response
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }

    }
}
