using Sport.Domain.Entities;
using Sport.Repository.Abstract;
using Sport.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sport.Service.Concrete.EntityFrameworkCore
{
    public class EfAreaService:IAreaService
    {
        private readonly IAreaRepository _areaRepo;
        public EfAreaService(IAreaRepository areaRepo)
        {
            _areaRepo = areaRepo;
        }

        public async Task<int> AddAreaAsync(Area Area)
        {
            return await _areaRepo.Add(Area);
        }


        public async Task<int> DeleteAreaAsync(Area Area)
        {
            return await _areaRepo.Delete(Area);
        }

        public async Task<int> EditAreaAsync(Area Area)
        {
            return await _areaRepo.Edit(Area);
        }

        public async Task<Area> AreaById(int Id)
        {
            Area getArea = await _areaRepo.Get(p => p.Id == Id);
            return getArea;
        }

        public async Task<IEnumerable<Area>> GetAllAreaAsync()
        {
            return await _areaRepo.GetAll();
        }
    }
}
