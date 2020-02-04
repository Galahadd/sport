using Sport.Domain.Entities;
using Sport.Domain.Entities.MMRelation;
using Sport.Repository.Abstract;
using Sport.Repository.Abstract.MMinterfaces;
using Sport.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sport.Service.Concrete.EntityFrameworkCore
{
    public class EfSportListService : ISportListService
    {
        private readonly ISportListRepository _sportListRepo;
        private readonly ISportDayRepository _sportDayRepository;
        private readonly IAreaRepository _areaRepository;
        private readonly IAreaMovementsRepository _areaMovementsRepository;
        public EfSportListService(ISportListRepository sportListRepo,
            ISportDayRepository sportDayRepository,
            IAreaRepository areaRepository,
            IAreaMovementsRepository areaMovementsRepository)
        {
            _sportListRepo = sportListRepo;
            _sportDayRepository = sportDayRepository;
            _areaRepository = areaRepository;
            _areaMovementsRepository = areaMovementsRepository;
        }

        public async Task<int> AddSportListAsync(SportList sportList)
        {
            var savedNutritionList = await _sportListRepo.AddEntityAndGetId(sportList);

            SportDay sDay = null;
            Area aDay = null;
            int success = 0;

            for (int i = 1; i <= 7; i++)
            {
                sDay = new SportDay();
                sDay.Name = "Day " + i;
                sDay.FKSportListId = savedNutritionList.Id;
                sDay = await _sportDayRepository.AddEntityAndGetId(sDay);

                for (int j = 1; j <= 8; j++)
                {
                    aDay = new Area();
                    aDay.Name = "Area " + j;
                    aDay.FKDayId = sDay.Id;

                    success = await _areaRepository.Add(aDay);
                }
            }
            if (success > 0)
            {
                return 1;
            }
            return 0;
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

        public async Task<int> AddAreaMovements(string[] stringMovementIdList, int areaId)
        {
            AreaMovements newAreaMovement= null;
            int success = 0;

            foreach (var thatMovement in stringMovementIdList)
            {
                newAreaMovement = new AreaMovements();
                newAreaMovement.FKMovementId = Convert.ToInt32(thatMovement);
                newAreaMovement.FKAreaId = areaId;

                await _areaMovementsRepository.Add(newAreaMovement);
                success = await _areaMovementsRepository.Save();
            }

            if (success > 0)
            {
                return 1;
            }
            return 0;

        }
    }
}
