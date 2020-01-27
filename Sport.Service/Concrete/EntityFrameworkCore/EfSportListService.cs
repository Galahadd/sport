using Sport.Domain.Entities;
using Sport.Repository.Abstract;
using Sport.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sport.Service.Concrete.EntityFrameworkCore
{
    public class EfSportListService:ISportListService
    {
        private readonly ISportListRepository _sportListRepo;
        public EfSportListService(ISportListRepository sportListRepo)
        {
            _sportListRepo = sportListRepo;
        }

        public async Task<int> AddSportListAsync(SportList sportList)
        {
            return await _sportListRepo.Add(sportList);
        }


        public async Task<int> DeleteSportListAsync(SportList sportList)
        {
            return await _sportListRepo.Delete(sportList);
        }

        public async Task<int> EditSportListAsync(SportList sportList)
        {
            return await _sportListRepo.Edit(sportList);
        }

        public async Task<SportList> SportListById(int Id)
        {
            SportList getSportList = await _sportListRepo.Get(p => p.Id == Id);
            return getSportList;
        }

        public async Task<IEnumerable<SportList>> GetAllSportListAsync()
        {
            return await _sportListRepo.GetAll();
        }
    }
}
