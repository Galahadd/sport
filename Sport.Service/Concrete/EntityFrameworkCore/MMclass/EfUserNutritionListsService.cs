using Sport.Domain.Entities.MMRelation;
using Sport.Repository.Abstract.MMinterfaces;
using Sport.Service.Abstract.MMRelation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sport.Service.Concrete.EntityFrameworkCore.MMclass
{
    public class EfUserNutritionListsService:IUserNutritionListsService
    {

        private readonly IUserNutritionListsRepository _userNutritionListsRepo;
        public EfUserNutritionListsService(IUserNutritionListsRepository userNutritionListsRepo)
        {
            _userNutritionListsRepo = userNutritionListsRepo;
        }

        public async Task<int> AddUserNutritionListsAsync(UserNutritionLists userNutritionLists)
        {
            return await _userNutritionListsRepo.Add(userNutritionLists);
        }


        public async Task<int> DeleteUserNutritionListsAsync(UserNutritionLists userNutritionLists)
        {
            return await _userNutritionListsRepo.Delete(userNutritionLists);
        }

        public async Task<int> EditUserNutritionListsAsync(UserNutritionLists userNutritionLists)
        {
            return await _userNutritionListsRepo.Edit(userNutritionLists);
        }

        public async Task<UserNutritionLists> UserNutritionListsById(int Id)
        {
            UserNutritionLists getUserNutritionLists = await _userNutritionListsRepo.Get(p => p.Id == Id);
            return getUserNutritionLists;
        }

        public async Task<IEnumerable<UserNutritionLists>> GetAllUserNutritionListsAsync()
        {
            return await _userNutritionListsRepo.GetAll();
        }
    }
}
