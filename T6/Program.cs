using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

/*
В кругу стоят N человек, пронумерованных от 1 до N. 
При ведении счета по кругу вычеркивается каждый второй человек, пока не останется один. 
Составить две программы, моделирующие процесс. 
Одна из программ должна использовать класс ArrayList, а вторая — LinkedList. Какая из двух программ работает быстрее?
 */



namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
           
            //=============================================================

            ArrayList list = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9,10};
            int fl=1;

            stopWatch.Start();
            while (list.Count != 1)
            {
                for (int i = 0; i < list.Count ; i++)
                {

                    if (fl == 2)
                    { 
                        list.RemoveAt(i);
                        i--;
                        fl = 1;
                    }
                    else fl = 2;
                }
            }
            stopWatch.Stop();
            TimeSpan ts1 = stopWatch.Elapsed;

            //====================================================================
            LinkedList<int> list1 = new LinkedList<int>();
            int temp;
            int[] mas = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < mas.Length; i++)
            {
                list1.AddLast(mas[i]);
            }
            fl = 1;
            var item = list1.First;
            //=====================================================================

            stopWatch.Start();            
            while (list1.Count != 1)
            {
                item = list1.First;
                while (item != null)
                {
                    temp = item.Value;
                  
                    item = item.Next;
                    if (fl == 2)
                    {
                        list1.Remove(temp);
                        //list1.Remove(item.Previous.Value);                                                
                        fl = 1;
                    }
                    else fl = 2;                    
                }
            }
            stopWatch.Stop();
            TimeSpan ts2 = stopWatch.Elapsed;

            int c;

            if (ts2 > ts1)
                c = 2;
            else c = 1;

            Console.WriteLine(c);
        }
    }
}
/*
                ArrayList list = new ArrayList() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
                int fl;

                while(list.Count!=1)

                for (int i = 0; i <list.Count-1; i++)
                {
                    fl = i;
                    if (fl % 2 != 0)
                        list.RemoveAt(i);
                }
                */