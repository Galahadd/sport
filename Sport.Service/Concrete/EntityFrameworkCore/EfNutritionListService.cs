using Sport.Domain.Entities;
using Sport.Domain.Entities.MMRelation;
using Sport.Repository.Abstract;
using Sport.Repository.Abstract.MMinterfaces;
using Sport.Repository.Concrete.EntityFrameworkCore.MMclass;
using Sport.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sport.Service.Concrete.EntityFrameworkCore
{
    public class EfNutritionListService:INutritionListService
    {
        private readonly INutritionListRepository _nutritionListRepo;
        private readonly INutritionDayRepository _nutritionDayRepo;
        private readonly IThatDayRepository _thatDayRepository;
        private readonly IMealFoodsRepository _mealFoodsRepository;

        public EfNutritionListService(
            INutritionListRepository nutritionListRepo,
            INutritionDayRepository nutritionDayRepo,
            IThatDayRepository thatDayRepository,
            IMealFoodsRepository mealFoodsRepository)
        {
            _nutritionListRepo = nutritionListRepo;
            _nutritionDayRepo = nutritionDayRepo;
            _thatDayRepository = thatDayRepository;
            _mealFoodsRepository = mealFoodsRepository;
        }

        public async Task<int> AddNutritionListAsync(NutritionList nutritionList)
        {
            var savedNutritionList = await _nutritionListRepo.AddEntityAndGetId(nutritionList);

            NutritionDay nDay = null;
            ThatDay tDay = null;
            int success = 0;

            for (int i = 1; i <= 7; i++)
            {
                nDay = new NutritionDay();
                nDay.Name = "Day " + i;
                nDay.FKNutritionListId = savedNutritionList.Id;
                nDay = await _nutritionDayRepo.AddEntityAndGetId(nDay);

                for (int j = 1; j <= 5; j++)
                {
                    tDay = new ThatDay();
                    tDay.Name = "That " + j;
                    tDay.FKNutritionDayId = nDay.Id;

                    success = await _thatDayRepository.Add(tDay);
                }      
            }
            if (success > 0)
            {
                return 1;
            }
            return 0;
        }

        public async Task<int> DeleteNutritionListAsync(NutritionList nutritionList)
        {
            return await _nutritionListRepo.Delete(nutritionList);
        }

        public async Task<int> EditNutritionListAsync(NutritionList nutritionList)
        {
            return await _nutritionListRepo.Edit(nutritionList);
        }

        public async Task<NutritionList> NutritionListById(int Id)
        {
            NutritionList getNutritionList = await _nutritionListRepo.Get(p => p.Id == Id);
            return getNutritionList;
        }

        public async Task<IEnumerable<NutritionList>> GetAllNutritionListAsync()
        {
            return await _nutritionListRepo.GetAll();
        }

        public async Task<int> AddThatFoods(string[] stringFoodIdList, int thatId)
        {
            MealFoods newMealFood = null;
            int success = 0;

            foreach (var thatFood in stringFoodIdList)
            { 
                newMealFood = new MealFoods();
                newMealFood.FKFoodId = Convert.ToInt32(thatFood);
                newMealFood.FKThatDayId = thatId;

                 await _mealFoodsRepository.Add(newMealFood);
                 success = await _mealFoodsRepository.Save();
            }

            if (success > 0 )
            {
                return 1;
            }
            return 0;
         
        }
    }
}

