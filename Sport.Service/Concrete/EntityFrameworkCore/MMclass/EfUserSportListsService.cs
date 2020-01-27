using Sport.Domain.Entities.MMRelation;
using Sport.Repository.Abstract.MMinterfaces;
using Sport.Service.Abstract.MMRelation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sport.Service.Concrete.EntityFrameworkCore.MMclass
{
    public class EfUserSportListsService:IUserSportListsService
    {

        private readonly IUserSportListsRepository _userSportListsRepository;
        public EfUserSportListsService(IUserSportListsRepository userSportListsRepository)
        {
            _userSportListsRepository = userSportListsRepository;
        }

        public async Task<int> AddUserSportListsAsync(UserSportLists userSportLists)
        {
            return await _userSportListsRepository.Add(userSportLists);
        }


        public async Task<int> DeleteUserSportListsAsync(UserSportLists userSportLists)
        {
            return await _userSportListsRepository.Delete(userSportLists);
        }

        public async Task<int> EditUserSportListsAsync(UserSportLists userSportLists)
        {
            return await _userSportListsRepository.Edit(userSportLists);
        }

        public async Task<UserSportLists> UserSportListsById(int Id)
        {
            UserSportLists getUserSportLists = await _userSportListsRepository.Get(p => p.Id == Id);
            return getUserSportLists;
        }

        public async Task<IEnumerable<UserSportLists>> GetAllUserSportListsAsync()
        {
            return await _userSportListsRepository.GetAll();
        }
    }
}
