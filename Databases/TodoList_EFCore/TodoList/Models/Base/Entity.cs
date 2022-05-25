using System;

namespace TodoList.Models.Base
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public DateTime CreatedUtc { get; set; }
    }
}
