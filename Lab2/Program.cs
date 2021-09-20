/// Chapter No. 9 and 10 - Week4_Lab2
/// File Name: Lab2.java
/// @author: Rossana Palma
/// Date:  September 18, 2021
///
/// Problem Statement: Write a console application that simulates the Lamp flowchart(Slide 35).
///  
/// Overall Plan:
/// 1) Create a boolean expression for lamp is on (true). Use if statement to display the lamp is on else off.
/// 2) Create a boolean expression for lamp is plugged in (true). Use if statement to display the lamp is plugged in else it needs plug in.
/// 3) Create a boolean expression for bulb is burned out(true). Use if statement to display the bulb needs to be replaced else if it needs a repair.
/// 4) Display sentences for true conditions

using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lamp flowchart
            // Boolean lampOn
            bool lampOn = true;
            if(lampOn)
            {
                Console.WriteLine("The lamp is on");
            }
            else
            {
                Console.WriteLine("The lamp is off");
            }
            // Boolean pluggedIn
            bool pluggedIn = true;
            if (pluggedIn)
            {
                Console.WriteLine("The lamp is plugged in.");
            }
            else
            {
                Console.WriteLine("Plug the lamp.");
            }
            //Boolean bulbBurnedOut
            bool bulbBurnedOut = true;
            if (bulbBurnedOut)
            {
                Console.WriteLine("Replace the bulb.");
            }
            else
            {
                Console.WriteLine("Repair the lamp.");
            }

        }
    }

}
    

