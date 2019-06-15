using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CustomerValidation
    {
        [Required(ErrorMessage = "請輸入姓名！")]
        public string Name { get; set; }

        [Required(ErrorMessage = "請輸入生日！")]
        [BeforeToday(ErrorMessage = "請輸入今天之前的日期 !")]
        public Nullable<System.DateTime> Birthday { get; set; }
    }

    [MetadataType(typeof(CustomerValidation))]
    public partial class Customer
    {

    }
}