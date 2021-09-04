using Dapper;
using QuanLySanPham.Domain.Request;
using QuanLySanPham.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham.Service
{
    public class CategoryService : BaseService, ICategoryService
    {
        public async Task<CreateCategoryResult> Create(CreateCategory create)
        {
            try
            {
                var foundCategory = await GetByName(create.CategoryName);
                if (foundCategory == null)
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@categoryName", create.CategoryName);
                    parameters.Add("@status", create.Status);

                    var category = await SqlMapper.QueryFirstOrDefaultAsync<Category>(
                        cnn: connection, sql: "sp_CreateCategory", param: parameters, commandType: System.Data.CommandType.StoredProcedure);
                    return new CreateCategoryResult()
                    {
                        IsExist = false,
                        Category = category
                    };
                }
                return new CreateCategoryResult()
                {
                    Category = foundCategory,
                    IsExist = true
                };
            }
            catch (Exception)
            {
                return new CreateCategoryResult()
                {
                    Category = new Category()
                };
            }
        }

        public async Task<UpdateCategoryResult> Update(UpdateCategory updateCategory)
        {
            try
            {
                var foundCategory = await GetByName(updateCategory.CategoryName, updateCategory.CategoryId);

                if (foundCategory == null)
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@categoryId", updateCategory.CategoryId);
                    parameters.Add("@categoryName", updateCategory.CategoryName);
                    parameters.Add("@status", updateCategory.Status);

                    var category = await SqlMapper.QueryFirstOrDefaultAsync<Category>(
                        cnn: connection, sql: "sp_UpdateCategory", param: parameters, commandType: System.Data.CommandType.StoredProcedure);
                    return new UpdateCategoryResult()
                    {
                        IsExist = false,
                        Category = category
                    };
                }
                return new UpdateCategoryResult()
                {
                    Category = foundCategory,
                    IsExist = true
                };
            }
            catch (Exception)
            {
                return new UpdateCategoryResult()
                {
                    Category = new Category()
                };
            }
        }



        public async Task<IEnumerable<Category>> Get()
        {
            var categories = await SqlMapper.QueryAsync<Category>(cnn: connection, sql: "getAllCategory", commandType: System.Data.CommandType.StoredProcedure);
            return categories;
        }

        public async Task<Category> GetById(int categoryId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@categoryId", categoryId);
            var category = await SqlMapper.QueryFirstOrDefaultAsync<Category>(
                                            cnn: connection,
                                            sql: "GetCategoryById",
                                            param: parameters,
                                            commandType: System.Data.CommandType.StoredProcedure);
            return category;
        }
        public async Task<Category> GetByName(string categoryName, int categoryId = 0)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryName);
            parameters.Add("@categoryId", categoryId);
            var category = await SqlMapper.QueryFirstOrDefaultAsync<Category>(
                cnn: connection, sql: "sp_GetCategoryByName", param: parameters, commandType: System.Data.CommandType.StoredProcedure);
            return category;
        }

        public async Task<DeleteCategoryResult> Delete(int categoryId)
        {
            try
            {
                var foundCategory = await GetById(categoryId);

                if (foundCategory != null)
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@categoryId", categoryId);

                    var category = await SqlMapper.QueryFirstOrDefaultAsync<Category>(
                        cnn: connection, sql: "sp_RemoveCategory", param: parameters, commandType: System.Data.CommandType.StoredProcedure);
                    return new DeleteCategoryResult()
                    {
                        Success = true,
                        NotFound = false
                    };
                }
                return new DeleteCategoryResult()
                {
                    Success = false,
                    NotFound = true
                };
            }
            catch (Exception)
            {
                return new DeleteCategoryResult()
                {
                    Success = false,
                    NotFound = false
                };
            }
        }

        public async  Task<RestoreCategoryResult> Restore(int categoryId)
        {
            try
            {
                var foundCategory = await GetById(categoryId);

                if (foundCategory != null)
                {
                    DynamicParameters parameters = new DynamicParameters();
                    parameters.Add("@categoryId", categoryId);

                    var category = await SqlMapper.QueryFirstOrDefaultAsync<Category>(
                        cnn: connection, sql: "sp_RestoreCategory", param: parameters, commandType: System.Data.CommandType.StoredProcedure);
                    return new RestoreCategoryResult()
                    {
                        Success = true,
                        NotFound = false
                    };
                }
                return new RestoreCategoryResult()
                {
                    Success = false,
                    NotFound = true
                };
            }
            catch (Exception)
            {
                return new RestoreCategoryResult()
                {
                    Success = false,
                    NotFound = false
                };
            }
        }
    }
}
