using TodoList.Data;
using TodoList.Models;

namespace TodoList.Repositories
{
    public class TodoRepository : RepositoryBase<Todo>
    {

        public TodoRepository(DataContext dataContext)
        {
        }


    }
}
