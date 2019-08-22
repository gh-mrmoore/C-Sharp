using System;
using System.Collections.Generic;
using System.Text;

namespace Unit05_Studio
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
    }
}