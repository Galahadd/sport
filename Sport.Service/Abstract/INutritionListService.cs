﻿using Sport.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sport.Service.Abstract
{
   public interface INutritionListService
    {
        Task<IEnumerable<NutritionList>> GetAllNutritionListAsync();
        Task<int> AddNutritionListAsync(NutritionList nutritionList);

        Task<int> EditNutritionListAsync(NutritionList nutritionList);

        Task<int> DeleteNutritionListAsync(NutritionList nutritionList);

        Task<NutritionList> NutritionListById(int Id);

        Task<int> AddThatFoods(List<Food> thatFoods, int thatId);
    }
}