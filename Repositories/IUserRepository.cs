using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserWebApi.Model;

namespace UserWebApi.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> Get();
        Task<User> Create(User user);
    }
}
