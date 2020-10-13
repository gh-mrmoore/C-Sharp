using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    public class HelloWorld
    {
        //declare Class fields
        private string message = "Hello World!";

        internal void sayHello()
        {
            string message = "Hellooooo World!!!!!!";
            Console.WriteLine(message);
            Console.WriteLine(this.message);
        }

        private string sayGoodBye()
        {
            return "Bye";
        }

        public void reallySayGoodBye()
        {
            Console.WriteLine(sayGoodBye());
        }
    }
}
