using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile:Animal
    {   public bool CanChangeColors { get; set; } 
        public double TailLength { get; set; }
        public string ScaleType { get; set; }

        public void ChangeColor(bool canChangeColors)
        {
            if (canChangeColors==true)
            {
                Console.WriteLine("You have changed colors.");

            }
            else
            {
                Console.WriteLine("Try again next time.");
            }
                
        }
     }
}
    

