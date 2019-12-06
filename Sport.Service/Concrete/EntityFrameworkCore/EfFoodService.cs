using Sport.Domain.Entities;
using Sport.Repository.Abstract;
using Sport.Repository.Concrete;
using Sport.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport.Service.Concrete.EntityFrameworkCore
{
    public class EfFoodService : IFoodService
    {
        private readonly IFoodRepository _foodRepo;
        public EfFoodService(IFoodRepository foodRepo)
        {
            _foodRepo = foodRepo;
        }

        public async Task<int> AddFoodAsync(Food food)
        {
            return await _foodRepo.Add(food);
        }

        public async Task<IEnumerable<Food>> GetAllFoodAsync()
        {
            return await _foodRepo.GetAll();
        } 
    }
}
