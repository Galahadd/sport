using Sport.Domain.Entities;
using Sport.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport.Service.Abstract
{
    public interface IFoodService
    {

        Task<IEnumerable<Food>> GetAllFoodAsync();
        Task<int> AddFoodAsync(Food food);
    }
}
