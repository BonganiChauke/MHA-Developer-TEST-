using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHA_TEST
{
    internal class Languages
    {
        //using interface to demontrates multiple inherintace
        public interface BackEnd
        {
            //creating a interface method to be inherited by a class
            void BackEndLangauges();
        }

        //using interface method
        public interface FrontEnd
        {
            //interface method to be inherited by a class
            void FrontEndLanguges();
        }

        //creating a class to inherite interface methods
        public class ProgrammingLanguages : BackEnd, FrontEnd
        {
            //method for BackEndLangauges for the interface method 
            public void BackEndLangauges()
            {
                Console.Write("Back End Languages\n" +
                    "1. Java\n" +
                    "2. C#\n" +
                    "3. Python\n");
            }

            //method for BackEndLangauges for the interface method 
            public void FrontEndLanguges()
            {
                Console.Write("\nFront End Languages\n" +
                    "1. HTML\n" +
                    "2. CSS\n" +
                    "3. JavaScript\n");
            }

        }

        //method to view output for instance methods
        public void Result()
        {
            //creating an instance object of ProgrammingLanguages Class
            ProgrammingLanguages programming = new ProgrammingLanguages();

            
            Console.WriteLine("\n\n******************* Multiple Inheritance *******************\n");

            //calling the methods
            programming.BackEndLangauges();
            programming.FrontEndLanguges();
        }

    }
}
