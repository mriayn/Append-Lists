using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendList
{
    class AppendLists
    {
        static void Main(string[] args)
        {

            var line = Console.ReadLine().Split('|').Reverse();
            var list = new List<string>();

            foreach (var item in line)
            {
                List<string> arr = item.Split(' ').ToList();
                foreach (var i in arr)
                {
                    if (i != "")
                    {
                        list.Add(i);
                    }

                }

            }
            Console.WriteLine(string.Join(" ", list));

        }
    }
}
