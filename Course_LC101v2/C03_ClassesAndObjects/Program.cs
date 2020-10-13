using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld hello = new HelloWorld();

            hello.sayHello();

            hello.reallySayGoodBye();

            // what happens if there's no constructor???
            Person me = new Person();

            me.FirstName = "Matthew";
            me.LastName = "Moore";

            Console.WriteLine(me.FirstName);
            Console.WriteLine(me.LastName);

            Console.WriteLine(DateTime.Now);

            // restaurant stuff...

            // create a list of menu items to add to my menu

            // create today's menu

            // create tomorrow's menu

            // etc....


        }
    }
}
