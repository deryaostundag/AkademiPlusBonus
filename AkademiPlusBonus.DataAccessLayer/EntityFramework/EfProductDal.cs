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
    public class EfProductDal:GenericRepository<Product>, IProductDal
    {
        //Entitiye özgü method oluşturur. Entityde hangi sınıfla çalışacağını belirtir. 
        //Her Class için olmazsa olmazdır. 

    }
}
