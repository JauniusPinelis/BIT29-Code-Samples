using System.Collections.Generic;
using System.Linq;
using TodoList.Data;
using TodoList.Dtos;
using TodoList.Models;

namespace TodoList.Services
{
    public class UserService
    {
        private DataContext _dataContext;

        public UserService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<UserDto> GetAll()
        {
            var entities = _dataContext.Users.ToList();
            var dtos = entities.Select(x => new UserDto
            {
                Id = x.Id,
                FullName = $"{x.FirstName} {x.LastName}"
            }).ToList();

            return dtos;
        }

        public void Add(User user)
        {
            _dataContext.Users.Add(user);
            _dataContext.SaveChanges();
        }
    }
}
