using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Polymorphism
{
    public class Lesson_CatSitter
    {
        public Lesson_Cat Pet { get; set; }
        public Lesson_CatSitter(Lesson_Cat pet)
        {
            Pet = pet;
        }

        public void FeedTheCat()
        {
            // code to prepare the cat's meal
            Pet.Eat();
        }
    }
}
