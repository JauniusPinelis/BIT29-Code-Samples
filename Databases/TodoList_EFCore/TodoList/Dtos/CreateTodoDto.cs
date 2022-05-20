using System.Collections.Generic;
using TodoList.Models;

namespace TodoList.Dtos
{
    public class CreateTodoDto
    {
        public Todo Todo { get; set; }

        public List<User> Users { get; set; }
    }
}
