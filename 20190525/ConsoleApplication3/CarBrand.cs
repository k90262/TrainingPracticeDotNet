using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class CarBrand
    {
        public int CarBrandID { get; set; }
        public string Name { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
