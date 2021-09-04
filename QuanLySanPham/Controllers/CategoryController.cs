using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLySanPham.Domain.Request;
using QuanLySanPham.Domain.Response;
using QuanLySanPham.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLySanPham.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        /// <summary>
        /// Lấy toàn bộ các danh mục sản phẩm
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<Category>> Get()
        {
            return await categoryService.Get();
        }
        /// <summary>
        /// Lấy danh mục theo ID
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{categoryId}")]
        public async Task<Category> GetById(int categoryId)
        {
            return await categoryService.GetById(categoryId);
        }
        /// <summary>
        /// Tạo mới một danh mục
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<CreateCategoryResult> Create(CreateCategory model)
        {
            return await categoryService.Create(model);
        }
        /// <summary>
        /// Cập nhật category
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<UpdateCategoryResult> Update(UpdateCategory model)
        {
            return await categoryService.Update(model);
        }
        /// <summary>
        /// Khôi phục lại category
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{categoryId}")]
        public async Task<DeleteCategoryResult> Delete(int categoryId)
        {
            return await categoryService.Delete(categoryId);
        }

        [HttpPatch]
        [Route("{categoryId}")]
        public async Task<RestoreCategoryResult> Restore(int categoryId)
        {
            return await categoryService.Restore(categoryId);
        }
    }
}
