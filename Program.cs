using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Add student name, course number, and CRN as a multi-line comment at the beginning of the code.
/* Isabella Tomasek
 * Course Number: 1050
 * CRN: 86411
 */

namespace CompetencyLabThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Use an if statement. Given the variables temp = 72 and tempLimit = 38, output "WARM WEATHER!" if temp is greater than tempLimit.
            int temp = 72;
            int tempLimit = 38;

            if (temp > tempLimit)
            {
                Console.WriteLine("WARM WEATHER!");
            }

            //3. Given the variables x = 47 and y = 68, use an if statement to compare the two variables and output a statement that states which variable is smaller.
            int x = 47;
            int y = 68;

            if (x < y)
            {
                Console.WriteLine("x is smaller");
            }

            //4. Use an if-else statement. If isOver16 is true, output "The student can learn to drive." If isOver16 is false, output "The student cannot learn to drive."
            bool isOver16 = true;

            if (isOver16)
            {
                Console.WriteLine("The student can learn to drive.");
            }
            else 
            {
                Console.WriteLine("The student cannot learn to drive.");
            }

            //5. Use an if-else statement to display “Passed” if a student’s score on the learner’s permit test is greater than or equal to 75 but displays “Failed” if it’s less than 75. Include an encouraging message to the student that failed and a congratulatory message to the student that passed.
            int score = 66;

            if (score >= 75)
            {
                Console.WriteLine("Congratulations, you passed!");
            }
            else
            {
                Console.WriteLine("Failed. Practice makes perfect, you got this next time!");
            }

            //6. Use an if-else if-else statement. Print a letter grade for the following conditions: 90-100 - A 80-89 - B 70-79 - C 60-69 - D else - F
            int grade = 75;

            if(grade >= 90 && grade <= 100)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 80 && grade < 90)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 70 && grade < 80)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 60 && grade < 70)
            {
                Console.WriteLine("D");    
            }
            else
            {
                Console.WriteLine("F");

            }

            //7. Use an if-else if-else statement. Display a prompt to the user to choose a number between 1 and 5 (1 and 5 are inclusive) and then store the user’s input in a string variable. Display a message to the user that tells them the prize they have won. The prizes are as follows:
            // 1 You won a computer 2 You won a monitor 3 You won a mouse 4 You won a keyboard 5 You won a printer else You lose. Try again!
            Console.WriteLine("Choose a number between 1 and 5");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            if (userNumber == 1)
            {
                Console.WriteLine("You won a computer");
            }
            else if (userNumber == 2)
            {
                Console.WriteLine("You won a monitor");
            }
            else if (userNumber == 3)
            {
                Console.WriteLine("You won a mouse");
            }
            else if (userNumber == 4)
            {
                Console.WriteLine("You won a keyboard");
            }
            else if (userNumber == 5)
            {
                Console.WriteLine("You won a printer");
            }
            else
            {
                Console.WriteLine("You lose. Try again!");
            }

            //8. Use a switch statement to output the following values for sport course level description. Level 1 – Recreational Level 2 – Lower intermediate Level 3 - Intermediate Level 4 – Upper Intermediate Level 5 – Competitive Level 6 – Very Competitive Level 7 – Highest level of Competition
            int courseLevel = 5;
            switch (courseLevel)
            {
                case 1:
                    Console.WriteLine("Recreational Level");
                    break;
                case 2:
                    Console.WriteLine("Lower intermediate Level");
                    break;
                case 3:
                    Console.WriteLine("Intermediate Level");
                    break;
                case 4:
                    Console.WriteLine("Upper Intermediate Level");
                    break;
                case 5:
                    Console.WriteLine("Competitive Level");
                    break;
                case 6:
                    Console.WriteLine("Very Competitive Level");
                    break;
                case 7:
                    Console.WriteLine("Highest level of Competition");
                    break;
            }

            //9. Use a switch statement to determine if the number 729 is odd or even and output a message stating whether 729 is odd or even.
            int switchNumber = 729;
            switch (switchNumber % 2)
            {
                case 0:
                    Console.WriteLine("729 is even");
                    break;
                case 1:
                    Console.WriteLine("729 is odd");
                    break;
            }
        }
    }
}
