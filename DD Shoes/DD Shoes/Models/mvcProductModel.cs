using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DD_Shoes.Models
{
    public class mvcProductModel
    {
        public string Product_Name { get; set; }
        public int Product_ID { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        public double Product_Price { get; set; }
        public int Product_Quantity { get; set; }
        public string Product_Category { get; set; }
        public string Product_Description { get; set; }
        public string Image_URL { get; set; }
    }
}