using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99_Scala_Problems_in_LINQ
{
    public class List
    {
        internal Func<IEnumerable<int>, string> listToString = l => l.Aggregate<int, string>(String.Empty, (x, y) => (x.Length > 0 ? x + "," : x) + y.ToString());

        public int Last(IEnumerable<int> list)
        {
            return list.Last();
        }

        internal int Penultimate(IEnumerable<int> list)
        {
            return Nth(1, Reverse(list));
        }

        internal int Nth(int n, IEnumerable<int> list)
        {
            return list.ElementAt(n);
        }

        internal IEnumerable<int> Reverse(IEnumerable<int> list)
        {
            return list.Reverse();
        }


        internal int Length(IEnumerable<int> list)
        {
            return list.Count();
        }

        internal bool IsPalindrome(IEnumerable<int> list)
        {
            var middle = Length(list) / 2;
            var list1 = list.Take(middle);
            var list2 = Reverse(list).Take(middle);

            for (int i = 0; i < middle; i++)
            {
                if (Nth(i, list1) != Nth(i, list2)) { return false; }
            }
            return true;
        }

        internal IEnumerable<int> Flatten(IEnumerable<dynamic> list)
        {
            //Todo: Find more efficient way to do this with LINQ

            List<int> retval = new List<int>();

            foreach (var item in list)
            {
                int i = 0;
                if (int.TryParse(item.ToString(), out i)) { retval.Add(i); }
                else { retval.AddRange(Flatten(item)); }
            }

            return retval;
        }
    }

}
