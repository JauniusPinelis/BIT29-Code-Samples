using TodoList.Data;
using TodoList.Models;
using TodoList.Services.Base;

namespace TodoList.Services
{
    public class CategoryService : BaseService<Category>
    {

        public CategoryService(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
