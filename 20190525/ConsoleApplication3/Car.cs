using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Car
    {
        [Key]
        public int CarNo { get; set; }
        public string Type { get; set; }
        public int BrandNo { get; set; }

        [ForeignKey("BrandNo")]
        public CarBrand Brand { get; set; }
    }
}
