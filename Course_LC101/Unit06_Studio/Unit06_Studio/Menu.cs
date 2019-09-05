using System;
using System.Collections.Generic;
using System.Text;

namespace Unit06_Studio
{
    class Menu
    {
        public DateTime MenuDate;
        public String MenuName;
        public static int ItemId = 1;
        public Dictionary<int, MenuItem> ItemList = new Dictionary<int, MenuItem>();

        public Menu(String mName)
        {
            MenuName = mName;
            MenuDate = DateTime.Today;
        }

        //if MenuDate is within 7 days of the Item date, then the item is new, otherwise it is old
        public string IsItemNew(DateTime menuDate, DateTime itemDate)
        {
            //return DateTime.Compare(MenuDate, itemDate);
            if ((menuDate - itemDate).TotalDays <= 7)
            {
                return "New Item!!!";
            } else
            {
                return "Existing Item.";
            }
        }
    }
}
