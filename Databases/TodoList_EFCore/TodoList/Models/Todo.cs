using System;

namespace TodoList.Models
{
    public class Todo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public DateTime CreatedUtc { get; set; }
    }
}
