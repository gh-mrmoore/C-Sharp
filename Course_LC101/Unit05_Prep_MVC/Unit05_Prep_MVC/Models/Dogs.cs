using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unit05_Prep_MVC.Models
{
    public class Dogs
    {
        public String DogBreed { get; set; }
        public String DogSize { get; set; }

        public Dogs(String breed, String size)
        {
            DogBreed = breed;
            DogSize = size;
        }
    }
}
