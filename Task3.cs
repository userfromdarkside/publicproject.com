/*Task 3 
Your task is to create a Visual C Sharp program that asks for the password three times. If the password is correct, it will welcome the user, otherwise, it will say Goodbye and END the program.
Run the above program and extend it to accept only alphanumeric input - for example, if a user enters digits only or characters only, it should not accept that as input, and ensures input is alphanumeric, and a mix of digits, numbers and one special character.   

 */
using System;
using System.Linq;

namespace PasswordCheckingProgress
{
    class Task3
    {
        static void Main(string[] args)
        {
            const string correctPassword = "Loveyou3000!";
            int attempts = 0;

            while (attempts < 3)
            {
                Console.Write("Enter password: ");
                string input = Console.ReadLine();

                if (IsValidPassword(input))
                {
                    if (input == correctPassword)
                    {
                        Console.WriteLine("Welcome, sweetie!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Password must contain alphanumeric and at least one special character.");
                }

                attempts++;
            }

            Console.WriteLine("Goodbye.");
        }

        static bool IsValidPassword(string password)
        {
            bool containsLetter = password.Any(char.IsLetter);
            bool containsDigit = password.Any(char.IsDigit);
            // Assuming special characters are anything that's not a letter or digit.
            bool containsSpecial = password.Any(ch => !char.IsLetterOrDigit(ch));

            return containsLetter && containsDigit && containsSpecial;
        }
    }
}
