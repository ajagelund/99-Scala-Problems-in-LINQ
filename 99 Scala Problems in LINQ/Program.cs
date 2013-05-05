using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99_Scala_Problems_in_LINQ
{
    class Program
    {
        /// <summary>
        /// 99 Scala problems: http://aperiodic.net/phil/scala/s-99/
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var problem = new Problem_List();
            IEnumerable<int> list = new List<int>() { 1, 1, 2, 3, 5, 8 };
            IEnumerable<int> palindromeList = new List<int>() { 1, 2, 3, 2, 1 };
            IEnumerable<dynamic> nestedList = new List<dynamic>() { new List<dynamic>() { 1, 1 }, 2, new List<dynamic>() { 3, new List<dynamic>() { 5, 8 } } };
            //IEnumerable<dynamic> nestedList = new List<dynamic>() { new List<dynamic>() { 1, 1 }, new List<dynamic>() { 5, 8 } };

            RunProblem(1, problem.P01(list), 8);
            RunProblem(2, problem.P02(list), 5);
            RunProblem(3, problem.P03(list), 2);
            RunProblem(4, problem.P04(list), 2);
            RunProblem(5, problem.P05(list), new List<int>() { 8, 5, 3, 2, 1, 1 });
            RunProblem(6, problem.P06(palindromeList), true);
            RunProblem(7, problem.P07(nestedList), new List<int>() { 1,1,2,3,5,8 });
            

            Console.ReadLine();
        }

        private static void RunProblem(int problemNumber, int actual, int expected)
        {
            Console.WriteLine(string.Format("P{0:00}: {1} [Expected: {2}]", problemNumber, actual, expected));
        }
        private static void RunProblem(int problemNumber, bool actual, bool expected)
        {
            Console.WriteLine(string.Format("P{0:00}: {1} [Expected: {2}]", problemNumber, actual, expected));
        }
        private static void RunProblem(int problemNumber, IEnumerable<int> actual, IEnumerable<int> expected)
        {
            List l = new List();
            
            Console.WriteLine(string.Format("P{0:00}: {1} [Expected: {2}]", problemNumber, l.listToString(actual) , l.listToString(expected)));
        }
    }
}
