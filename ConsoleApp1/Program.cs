using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----");

            //linq
            //List<int> scores = [32, 78, 29, 84, 3, 52, 32, 35, 27, 38, 101, 90, 88];
            int[] scores = {32, 78, 29, 84, 3, 52, 32, 35, 27, 38, 101, 90, 88 };

            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                orderby score descending
                select score;

            var scoreQuery2 = scores.Where(s => s > 80).OrderByDescending(s => s);

            Console.WriteLine("--1--");

            foreach (var score in scoreQuery)
            {
                Console.WriteLine(score);
            }

            Console.WriteLine("--2--");

            foreach (var score in scoreQuery2)
            {
                Console.WriteLine(score);
            }
        }
    }
}
