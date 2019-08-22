using System;
using System.Collections.Generic;
using System.Text;

namespace Unit05_Studio
{
    class MenuItem
    {
        public DateTime ItemDate { get; set; }
        public String ItemDescription { get; set; }
        public double ItemPrice { get; set; }
        public String ItemCategory { get; set; }   //will only be appetizer, main course or dessert

        public MenuItem(DateTime itemDate, String itemDesc, double itemPrice, String itemCategory)
        {
            ItemDate = itemDate;
            ItemDescription = itemDesc;
            ItemPrice = itemPrice;
            ItemCategory = itemCategory;
        }
    }
}
