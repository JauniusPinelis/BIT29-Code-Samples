using TodoList.Models.Base;

namespace TodoList.Models
{
    public class Todo : NamedEntity
    {
        public string Category { get; set; }

        public User User { get; set; }

        public int? UserId { get; set; }
    }
}
