using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class DataEntities : DbContext
    {
        public DataEntities() : base("CS")
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarBrand> CarBrands { get; set; }

    }
}
