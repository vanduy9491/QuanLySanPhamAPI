using QuanLySanPham.Domain.Request;
using QuanLySanPham.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham.Service
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> Get();
        Task<Category> GetById(int categoryId);
        Task<CreateCategoryResult> Create(CreateCategory create);
        Task<UpdateCategoryResult> Update(UpdateCategory create);
        Task<DeleteCategoryResult> Delete(int categoryId);
        Task<RestoreCategoryResult> Restore(int categoryId);

    }
}
