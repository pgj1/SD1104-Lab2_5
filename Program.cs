using System;

namespace Lab2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("****** Lab 2.5 - Manipulating user inputs ******");
            Console.WriteLine("************************************************");

            Console.WriteLine("Task 1");

            // get user input
            Console.Write("Input 2 numbers:");
            string userInput1 = Console.ReadLine();
            string userInput2 = Console.ReadLine();

            // convert input to integer
            int num1 = int.Parse(userInput1);
            int num2 = int.Parse(userInput2);

            // adding input 1 & input 2
            int add = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " is " + add);

            //subtracting input 1 - input 2
            int sub = num1 - num2;
            Console.WriteLine(num1 + " - " + num2 + " is " + sub);

            //multiplying input 1 & input 2
            int mult = num1 * num2;
            Console.WriteLine(num1 + " x " + num2 + " is " + mult);

            //Dividing input 1 by input 2
            double div = num1 / (double)num2;
            Console.WriteLine(num1 + " / " + num2 + " is " + div);

            Console.WriteLine("End of Task 1");
            Console.WriteLine("***************************************");

            Console.WriteLine("Task 2");
            // print Hello and your name (which you will type in on the Console) in a separate line.
            Console.Write("Input your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello");
            Console.WriteLine(name);

            Console.WriteLine("End of Task 2");
            Console.WriteLine("***************************************");
            // End task 2


            // 3 print the output of multiplication of three numbers which will be entered by the user

            Console.WriteLine("Task 3");
            // get user input
            Console.Write("Input 3 numbers:");
            int userInput3_1 = int.Parse(Console.ReadLine());
            int userInput3_2 = int.Parse(Console.ReadLine());
            int userInput3_3 = int.Parse(Console.ReadLine());
            
            // multiply inputs
            int prod3 = userInput3_1 * userInput3_2 * userInput3_3;
            Console.Write(userInput3_1 + "x" + userInput3_2 + "x" + userInput3_3 + " is ");
            Console.WriteLine(prod3);

            Console.WriteLine("End of Task 3");
            Console.WriteLine("***************************************");
            // End task 3

            // 4 takes an age (for example 20) as input and prints something like  
            // "You look younger than the age the user entered"

            Console.WriteLine("Task 4");
            // get user input
            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());
            int newage = age - 2;
            Console.WriteLine("Really? You don't look a day over "+ newage);

            Console.WriteLine("End of Task 4");
            // End task 4

            Console.WriteLine("  ");
            Console.WriteLine("    ***** End of Lab 2.5 *****");
            Console.WriteLine("***************************************");


        }
    }
}
