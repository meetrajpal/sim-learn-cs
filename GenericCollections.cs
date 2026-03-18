using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GenericCollections
    {
        public static void ListDemo()
        {
            List<int> intList = new List<int>() { };
        }

        public static void SortedListDemo()
        {
            SortedList<int, string> asas = new SortedList<int, string>();
            asas.Add(1, "MR");
            asas.Add(2, "MR");
            foreach (KeyValuePair<int, string> item in asas)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine(asas[2]);
        }
    }
}
