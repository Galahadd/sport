using System;
using System.Collections.Generic;
using System.Text;

namespace Sport.Repository.Abstract
{
    public interface IUnitOfWork
    {
        IFoodRepository Foods { get; }
    }
}
