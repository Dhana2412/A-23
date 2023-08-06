using project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the shared library class
            DataValidator dataValidator = new DataValidator();

            // Use the shared library method
            bool isValidEmail = dataValidator.ValidateEmail("example@email.com");

            // Display the result
            Console.WriteLine($"Is Valid Email: {isValidEmail}");

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
    

