using QuanLySanPham.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham.Service
{
    public interface ISupplierService
    {
        Task<IEnumerable<Supplier>> Get();
    }
}
