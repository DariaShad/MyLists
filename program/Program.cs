using MyLists;

namespace program
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.AddToBeginning(10);
            arrayList.AddToBeginning(1);
            arrayList.AddToBeginning(25);
            arrayList.AddToBeginning(56);
            arrayList.AddToBeginning(7);
            arrayList.AddToBeginning(10);
            arrayList.AddToBeginning(100);
            
            arrayList.Write();
            arrayList.DeleteByIndexNElements(2, 3);
            arrayList.Write();

        }
    }
}
