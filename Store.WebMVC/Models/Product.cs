﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Store.WebMVC.Models
{
    //place access to a foreign key?
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int UPC { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}