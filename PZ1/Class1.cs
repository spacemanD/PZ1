using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PZ1
{
   
    public class ArrayList1Z:ArrayList
    {
        ArrayList List = new ArrayList();

        //int[] NewArray = (int[])AList.ToArray(typeof(int));

        public int[] ToArray(ArrayList myList)
        {
            int i = 0;
            int[] array = new int[myList.Count];
            foreach (int  arr in myList)
            {
                array[i] = arr;
                i++;

            }
            return array;
        }
        public void Print(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" "+array[i]);
            }
        }

        public  bool Search(ArrayList list,object? item)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (item == list[i])
                {
                    return true;
                }
            }
            return false;
        }
        public  int Search1(object item)
        {

            for (int i = 0; i < List.Count; i++)
            {
                if (item == List[i])
                    return i;
            }
            return -1;
        }
        public int BinarySearch(int[] array, int searchedValue, int first, int last)
        {
            if (first > last)
            {
                return -1;
            }


            var middle = (first + last) / 2;
            var middleValue = array[middle];

            if (middleValue == searchedValue)
            {
                return middle;
            }
            else
            {
                if (middleValue > searchedValue)
                {
                    return BinarySearch(array, searchedValue, first, middle - 1);
                }
                else
                {
                    return BinarySearch(array, searchedValue, middle + 1, last);
                }
            }
        }
            public  void AddItem1(int item, int[] array, int last)
            {
                try
                {
                    int i = last;
                    for (; i >= 0 && array[i] > item; i--)
                        array[i + 1] = array[i];
                    array[i + 1] = item;
                    last++;
                }

                catch (Exception e)
                {

                    Console.WriteLine("Array is full"); ;
                }
                finally
                {
                    Console.WriteLine("Done");
                }
            }
        public void AddItem(int item, int[] array, int last)
        {
            try
            {
                int i = last;
                for (; i >= 0 && array[i] > item; i--)
                    array[i + 1] = array[i];
                array[i + 1] = item;
                last++;
            }
            catch (Exception)
            {
               
            }
           

        }
        public  int[] Intersection(int[] arr1, int[] arr2)
        {
            Filtr(arr1);
            Filtr(arr2);
            int n = 0;
            int[] intersection = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        intersection[n] = arr1[i];
                        n++;
                    }
                    else
                    {
                    }
                }
            }
            FiltrNull(intersection);
            return intersection;
        }
        public  int[] Union(int[] arr1, int[] arr2)
        {
            Filtr(arr1);
            Filtr(arr2);
            int n = 0;
            int b = arr1.Length;
            int[] union = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                union[n] = arr1[i];
                n++;
            }
            for (int j = 0; j < arr2.Length; j++)
            {

                union[b] = arr2[j];
                b++;
            }
            FiltrNull(union);
            return union;
        }
        public int[] Filtr(int[] arr1)
        {
            int[] filtr = new int[arr1.Length];
            int temp;
            for (int i = 0; i < arr1.Length - 1; i++)
            {
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }
            return filtr;


        }
        public int[] Reverese(int[] arr1)
        {
            int[] filtr = new int[arr1.Length];
            int temp;
            for (int i = 0; i < arr1.Length - 1; i++)
            {
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] < arr1[j])
                    {
                        temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }
            return filtr;


        }
        private int capacity;
        //public  int Capacity {
        //    get { return capacity;}
        //    set {capacity = List.Capacity * 2; } }
        public int[] FiltrNull(int[] arr1)
        {
            int[] filtrnull = new int[arr1.Length];
            var set = new HashSet<int>();
            foreach (var item in arr1)
                if (!set.Add(item))
                    Console.WriteLine(item);
            return filtrnull;
        }
        public ArrayList DeleteItem(ArrayList list, object? item)
        {
            int g = 0;
            
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == item)
                    list.RemoveAt(i);
             
            }
            return list;
        }
        public  ArrayList Additem(ArrayList list, object? item)
        {
             list.Add(item);
            return list;
        }
        public bool Seaching(ArrayList list, object? item)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == item)
                    return true;
            }
            return false;
        }
    }
}

