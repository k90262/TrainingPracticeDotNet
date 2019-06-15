﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class BeforeTodayAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value == null ? false : (DateTime)value < DateTime.Today;
        }
    }
}