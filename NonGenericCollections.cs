using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class NonGenericCollections
    {
        public static void ArrayListDemo()
        {
            var a = new int[]{ 1, 3, 54 };
            
            ArrayList arrayList = new ArrayList(10); 

            arrayList = new ArrayList(a);
            foreach (var element in arrayList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
