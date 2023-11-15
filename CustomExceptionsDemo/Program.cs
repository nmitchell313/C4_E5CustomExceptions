//Nicholas Mitchell nmitchell11@cnm.edu
//Custom Exceptions Demo


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string doAnother;
            do
            {
                try
                {
                    Console.Write("Please enter a social security number: ");
                    String userInput = Console.ReadLine();
                    SocialSecurityNumber ssn = new SocialSecurityNumber();
                    ssn.SSN = userInput;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Error! " + exc.Message + "\nException type: " + exc.GetType());
                }
                finally
                {
                    Console.WriteLine("This section always excecutes!");
                }

                Console.Write("Do another (y/n): ");
                doAnother = Console.ReadLine();
            } while (doAnother == "y");

        }
    }
}
