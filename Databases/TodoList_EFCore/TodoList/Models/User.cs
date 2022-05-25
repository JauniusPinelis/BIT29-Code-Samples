using System.Collections.Generic;
using TodoList.Models.Base;

namespace TodoList.Models
{
    public class User : Entity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Todo> Todos { get; set; }
    }
}
