using Sport.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sport.Service.Abstract
{
   public interface IUserService
    {

        Task<IEnumerable<User>> GetAllUserAsync();
        Task<int> AddUserAsync(User user);

        Task<int> EditUserAsync(User user);

        Task<int> DeleteUserAsync(User user);

        Task<User> UserById(int Id);
    }
}
