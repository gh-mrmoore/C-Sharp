using System;
using System.Collections.Generic;

namespace Interfaces_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code for Lesson Here
            //Lesson_HouseCat suki = new Lesson_HouseCat("Suki", 12);
            //Lesson_CatSitter annie = new Lesson_CatSitter(suki);

            //annie.FeedTheCat();

            // Code for Exercises Here
            //Exercise_Case menu = new Exercise_Case();
            //List<Exercise_Flavor> availableFlavors = menu.Flavors;
            //List<Exercise_Cone> availableCones = menu.Cones;

            //Use a Comparer class to sort the 'flavors' array alphabetically by the 'name' field
            //Exercise_CompareFlavors compareFlavors = new Exercise_CompareFlavors();
            //availableFlavors.Sort(compareFlavors);

            //Use a Comparator class to sort the 'cones' array in increasing order by the 'cost' field
            //Exercise_CompareCones compareCones = new Exercise_CompareCones();
            //availableCones.Sort(compareCones);

            // Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting
            //foreach(Exercise_Flavor thisFlavor in availableFlavors)
            //{
            //    Console.WriteLine(thisFlavor.Name);
            //}

            //foreach(Exercise_Cone thisCone in availableCones)
            //{
            //    Console.WriteLine(thisCone.Name + " " + thisCone.Cost);
            //}


            //Code for Studio Here

            // TODO: Declare and initialize a CD and a DVD object.
            Studio_DVD bb4l = new Studio_DVD(1, 500, "DVD", "Bad Boys 4 Life");
            List<string> songList = new List<string>();
            songList.Add("We Will Rock You");
            songList.Add("Under Pressure");
            songList.Add("We Are the Champions");

            Studio_CD Queen = new Studio_CD(2, 250, "CD", songList);

            // TODO: Call each CD and DVD method to verify that they work as expected
            Console.WriteLine(Queen.SpinDisc());
            Console.WriteLine(bb4l.SpinDisc());


        }
    }
}
