using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99_Scala_Problems_in_LINQ
{
    public class Problem_List
    {
        private List LinqList { get { return new List(); } }

        /// <summary>
        /// Find the last element of a list
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int P01(IEnumerable<int> list)
        {
            return LinqList.Last(list);
        }
        /// <summary>
        /// Find the last but one element of a list
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int P02(IEnumerable<int> list)
        {
            return LinqList.Penultimate(list);
        }
        /// <summary>
        /// Find the Kth element of a list
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int P03(IEnumerable<int> list)
        {
            return LinqList.Nth(2, list);
        }
        /// <summary>
        /// Find the number of elements in a list
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int P04(IEnumerable<int> list)
        {
            return LinqList.Length(list);
        }
        /// <summary>
        /// Reverse a list
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public IEnumerable<int> P05(IEnumerable<int> list)
        {
            return LinqList.Reverse(list);
        }
        /// <summary>
        /// Find out whether a list is a palindrome
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        internal bool P06(IEnumerable<int> list)
        {
            return LinqList.IsPalindrome(list);
        }
        /// <summary>
        /// Flatten a nested list structure
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        internal IEnumerable<int> P07(IEnumerable<dynamic> list)
        {
            return LinqList.Flatten(list);
        }
    }
}
