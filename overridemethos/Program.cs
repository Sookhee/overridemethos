using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridemethos
{
    class Program
    {
        int Power(int input)
        {
            return (input*input);
        }

        int Power(int input, int count)
        {
            int result = 1;
            for(int i = 1; i < count; i++)
            {
                result *= input;
            }
            return result;
        }

        int SumAll(int end)
        {
            int sum = 0;
            for(int i = 0; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }

        int SumAll(int start, int end)
        {
            int sum = 0;
            for(int i = start; i <= end; i++)
            {
                sum += i;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
