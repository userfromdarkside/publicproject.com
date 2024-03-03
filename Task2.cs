/*Task 2
Simple Online Grading Program
You are required to build a program that converts the score to grade based on the decision rule shown below:
•	Grade is High Distinction if score is between 85 and 100
•	Grade is distinction if score is between 75 and 84
•	Grade is Credit if score is between 65 and 74
•	Grade is Pass if score is between 55 and 64
•	Grade is Fail if score is between 0 and 54
•	Grade is invalid if any other score.
 */
using System;

namespace ConvertScoreToGrade
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your score: ");
            int score = int.Parse(Console.ReadLine());
            string grade;

            if (score >= 85 && score <= 100)
            {
                grade = "High Distinction";
            }
            else if (score >= 75 && score <= 84)
            {
                grade = "Distinction";
            }
            else if (score >= 65 && score <= 74)
            {
                grade = "Credit";
            }
            else if (score >= 55 && score <= 64)
            {
                grade = "Pass";
            }
            else if (score >= 0 && score <= 54)
            {
                grade = "Fail";
            }
            else
            {
                grade = "Invalid";
            }

            Console.WriteLine($"Your grade is: {grade}");
        }
    }
}
