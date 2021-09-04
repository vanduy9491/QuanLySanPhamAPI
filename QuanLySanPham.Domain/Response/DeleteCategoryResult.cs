using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySanPham.Domain.Response
{
    public class DeleteCategoryResult
    {
        public bool Success { get; set; }
        public bool NotFound { get; set; }
        public string Message => Success ? Common.Message.Category.Delete : (NotFound ? Common.Message.Category.NotFound : Common.Message.Fail); 


    }
}
