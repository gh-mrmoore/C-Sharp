using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    class RestauantMenu
    {
        // set class fields
        private List<MenuItem> menuList = new List<MenuItem>();   // list of menu items
        private bool newMenu;   // is the menu new?
        private DateTime menuDate;   // date menu was last updated?

        // getters and setters
        public DateTime MenuDate
        {
            get { return menuDate; }
            private set { menuDate = DateTime.Now; }   //could also just do this in the constructor
        }

        public bool NewMenu
        {
            get { return newMenu; }
            private set { newMenu = value; }   //could also just do this in my constructor
        }

        public List<MenuItem> MenuList { get; set; }


        // constructors
        public 

    }
}
