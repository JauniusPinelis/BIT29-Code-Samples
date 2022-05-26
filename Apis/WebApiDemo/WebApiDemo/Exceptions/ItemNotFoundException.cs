using System;

namespace WebApiDemo.Exceptions
{
    public class ItemNotFoundException : ArgumentException
    {
        public ItemNotFoundException() : base("Item not found")
        {

        }
    }
}
