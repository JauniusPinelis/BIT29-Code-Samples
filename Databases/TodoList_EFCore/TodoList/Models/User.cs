using System.Collections.Generic;

namespace TodoList.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Todo> Todos { get; set; }
    }
}
