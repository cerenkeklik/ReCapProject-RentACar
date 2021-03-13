using Core.DataAccess;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfCarImageDal : EfEntityRepositoryBase<CarImage, DatabaseContext>, ICarImageDal
    {
    }
}
