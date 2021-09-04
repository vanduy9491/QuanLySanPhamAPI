using Dapper;
using QuanLySanPham.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham.Service
{
    public class SupplierService :BaseService, ISupplierService
    {
        public async Task<IEnumerable<Supplier>> Get()
        {
            var suppliers = await SqlMapper.QueryAsync<Supplier>(cnn: connection, sql: "GetAllSupplier", commandType: System.Data.CommandType.StoredProcedure);
            return suppliers;
        }
    }
}
