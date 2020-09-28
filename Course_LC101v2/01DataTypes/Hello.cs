using System;
using System.Collections.Generic;
using System.Text;

namespace DataTypes
{
    public class Hello
    {
        public static string DisplayMessage(string language)
        {
            if (language.Equals("sp"))
            {
                return "Hola LaunchCode!";
            }
            else if (language.Equals("fr"))
            {
                return "Bonjour LaunchCode";
            }
            else
            {
                return "Hi LaunchCode";
            }
        }
    }
}
