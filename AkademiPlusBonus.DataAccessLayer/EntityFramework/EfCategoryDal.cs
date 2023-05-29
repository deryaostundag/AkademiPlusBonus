using AkademiPlusBonus.DataAccessLayer.Abstract;
using AkademiPlusBonus.DataAccessLayer.Repositories;
using AkademiPlusBonus.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusBonus.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal: GenericRepository<Category>, ICategoryDal
    {

    }
}
