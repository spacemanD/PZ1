using System;
using System.Collections;

namespace PZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList1Z list = new ArrayList1Z();
            ArrayList List = new ArrayList();
            List.Add(5);
            List.Add(6);
            List.Add(7);
            List.Add(8);
            int[] array1 = list.ToArray(List);
            list.Print(array1);
            
    }
}
}
