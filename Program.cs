using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DebugCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Math";
            Program p = new Program();
            p.Run();
            Console.ReadLine();

        }

        public void Run()
        {
            Math();
        }

        private void Math()
        {
            int res = 0;

            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = (i + 1) * 1000;
            }

            res = Mult(arr);
        }

        private int Mult(int[] nums)
        {
            int res = 1;
            for (int x = 0; x < nums.Length; x++)
            {
                Console.WriteLine("Iteration {0} {1}*{2} = {3}", x, res, nums[x], res * nums[x]);
                res = res * nums[x];
            }

            return res;
            
        }
    }
}
