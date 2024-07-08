using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHA_TEST
{
    internal class Addition
    {
        //implementating async

        //creating a method to calculate numbers
        public async Task<int> AddNum(int x, int y)
        {
            //call the calculation and await the operation 
            int result = await Calculation(x, y);
            return result;
        }

        //method calculates numbers
        public async Task<int> Calculation(int x, int y)
        {
            Console.WriteLine("\nPlease wait... Calculation in progress");//alerts user
            await Task.Delay(3000); //delaying this task by 3 seconds     
            return x + y;//returns sum of two numbers
        }
    }
}
