using MyLists;
using System;

namespace program
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.AddToBeginning(10);
            arrayList.AddToBeginning(1);
            arrayList.AddToBeginning(160);
            arrayList.AddToBeginning(560);
            arrayList.AddToBeginning(7);
            arrayList.AddToBeginning(10);
            arrayList.AddToBeginning(160);
            
            arrayList.Write();

            //int maxValue=arrayList.FindMax();
            //Console.WriteLine(maxValue);
            int minValue = arrayList.FindMinElement();
            Console.WriteLine(minValue);

            //int indexMaxValue = arrayList.FindIndexMaxElement();
            //Console.WriteLine(indexMaxValue);
            //int indexMinElement = arrayList.FindIndexMinElement();
            //Console.WriteLine(indexMinElement); //ПУСТЫЕ ЯЧЕЙКИ СЧИТАЕТ ЭЛЕМЕНТАМИ 0

        }
    }
}
