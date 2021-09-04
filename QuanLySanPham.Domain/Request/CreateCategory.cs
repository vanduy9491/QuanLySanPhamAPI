using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySanPham.Domain.Request
{
    public class CreateCategory
    {
        public string CategoryName { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }
    }
}
