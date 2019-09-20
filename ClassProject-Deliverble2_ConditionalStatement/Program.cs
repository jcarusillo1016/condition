//Name: Joseph Carusillo
//Date: 9/12/2019
//Project: Conditonal Statement
//Description: Ask user for expected grade(integer) in class, and based on the ans program will dsplay the letter grade

using System;


namespace ClassProject_Deliverble2_ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {  
          // Ask user for integer value for conditional statment
          Console.WriteLine("Please enter what grade you expet to get in ISM4300");

            // Using try catch to help handle errors
            try
            {
                //create a variable for the value used in the statement
                string input = Console.ReadLine();

                //named value as grade and parsed the value
                int grade = int.Parse(input);

                // An if/else if statement that handles the conditions for the users Letter grade
                if ((grade > 0) && (grade < 50))
                {
                    Console.WriteLine("Grade:F");
                }
                else if ((grade > 50) && (grade < 70))
                {
                    Console.WriteLine("Grade:D");
                }
                else if ((grade > 70) && (grade < 80))
                {
                    Console.WriteLine("Grade:C");
                }
                else if((grade > 80) && (grade < 90))
                {
                    Console.WriteLine("Grade:B");
                }   
                else if(grade > 90)
                {
                    Console.WriteLine("Grade:A");
                }
                else
                {
                    Console.WriteLine("Please enter an integer value within the range 1-100");
                }
                

            }
            catch
            {
                // error statement for user
                Console.WriteLine("You have not entered an integer vaue into the system so an error has occured. Please try again.");
                               
                
            }
            //used to keep the window open after it is done computing
            Console.ReadKey(true);
        }
    }
}
