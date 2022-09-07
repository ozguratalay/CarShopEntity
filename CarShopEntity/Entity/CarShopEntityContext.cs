using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopEntity.Entity
{
   public class CarShopEntityContext: DbContext
    {
       public DbSet<CarShopUserData> carShopUserDatas { get; set; }
       public DbSet<CarRepo> carRepos { get; set; }
       public DbSet<SellList> SellLists { get; set; }
       public DbSet<AdminLogin> AdminLogins { get; set; }
    }
}
 