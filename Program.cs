/*
 * 
 * Coder: Shane Luttmann
 * This is my Hello World - Deliverable 1
 * I added more code to help me get back into the grove of C#
 * 
 */

using System;

namespace Visual_Studio_2019_Csharp_Get_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Var to hold a string and to run the while loop.
            String name = "";
            String exit = "Yes";

            Console.WriteLine("Hopefuly I remember how to code in C#.");

            // While loop to run the main part of the program
            while (exit == "Yes" || exit == "yes" || exit == "Y" || exit == "y")
            {
                // Here is the one writeline needed for this deliverable.
                Console.WriteLine("\nHello World!");

                // Asking the user for there name to input into the name var.
                Console.Write("What is your name?: ");
                name = Console.ReadLine();

                // Nested while loop just in case the user dose not enter a name.
                while (name == "")
                {
                    // Light humor as the programs asks the user to input a name. 
                    Console.Write("Really now? What is your name: ");
                    name = Console.ReadLine();

                    // Nested IF statement which if it detects that the user has not entered something it will then close the program.
                    if (name == "")
                    {
                        Console.WriteLine("Well OK then, since you dont want to play along...");
                        // Ends the program
                        Environment.Exit(0);
                    }
                    // Else if the user inputs something, it displays the output including the name var.
                    else
                    {
                        //Output
                        Console.WriteLine("\nHello, " + name + "! You are not as bad is I thought you were!\n");
                    }


                }
                //Output if the user inputs something the first time.
                Console.WriteLine("\nHello, " + name + "! You are not as bad is I thought you were!\n");

                // Reads input for the user to restart the while loop. (Restarting the program)
                Console.Write("Do you want to loop this program again?: ");
                exit = Console.ReadLine();
            }

            // If the user ends the while loop the program ends.
            Environment.Exit(0);
        }
    }
}
