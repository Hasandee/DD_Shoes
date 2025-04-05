using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DD_Shoes.Models
{
    public class DDProductTableModel
    {
        public string Product_Name { get; set; }
        public int Product_ID { get; set; }
        public string Product_Price { get; set; }
        public int Product_Quantity { get; set; }
        public string Product_Category { get; set; }
        public string Product_Description { get; set; }
        public string Image_URL { get; set; }
    }
}