using System.Collections.Generic;
using System.Linq;
using TodoList.Data;
using TodoList.Dtos;
using TodoList.Models;
using TodoList.Services.Base;

namespace TodoList.Services
{
    public class UserService : BaseService<User>
    {
        public UserService(DataContext dataContext) : base(dataContext)
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
    }
}
