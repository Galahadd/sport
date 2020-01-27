using Sport.Domain.Entities;
using Sport.Repository.Abstract;
using Sport.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sport.Service.Concrete.EntityFrameworkCore
{
    public class EfUserService:IUserService
    {

        private readonly IUserRepository _userRepo;
        public EfUserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task<int> AddUserAsync(User user)
        {
            return await _userRepo.Add(user);
        }


        public async Task<int> DeleteUserAsync(User user)
        {
            return await _userRepo.Delete(user);
        }

        public async Task<int> EditUserAsync(User user)
        {
            return await _userRepo.Edit(user);
        }

        public async Task<User> UserById(int Id)
        {
            User getUser = await _userRepo.Get(p => p.Id == Id);
            return getUser;
        }

        public async Task<IEnumerable<User>> GetAllUserAsync()
        {
            return await _userRepo.GetAll();
        }
    }
}
