using Sport.Domain;
using Sport.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sport.Repository.Concrete.EntityFrameworkCore
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly SportDatabaseContext _context;
        public EfUnitOfWork(SportDatabaseContext context)
        {
            _context = context ?? throw new ArgumentNullException("Context null olamaz");
        }
        private IFoodRepository _foods;

        public IFoodRepository Foods
        {
            get
            {
                return _foods ?? (_foods = new EfFoodRepository(_context));
            }
        }
    }
}
