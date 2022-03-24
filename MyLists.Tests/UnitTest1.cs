using NUnit.Framework;
using System.Collections;
namespace MyLists.Tests
{
    public class Tests
    {
       
        [Test]
        public void Test1()
        {
            int[] newMassive = new int[3] { 1, 2, 3 };
            ArrayList arrayList = new ArrayList(newMassive);
            arrayList.AddToEnd(4);
            int[] expected = new int[4] { 1, 2, 3, 4 };
            ArrayList arrayListExpected = new ArrayList(expected);
            Assert.AreEqual(arrayListExpected, arrayList);
        }
    }

    
    [TestCaseSource(typeof(DeleteAllByValueTestSource))]
    public void DeleteAllByValueTest(int value, ArrayList list, ArrayList expectedList, int expectedNumber)
    {
        int actualNumber = list.DeleteAllByValue(value);

        ArrayList actualList = list;
        Assert.AreEqual(expectedNumber, actualNumber);
        Assert.AreEqual(expectedList, actualList);
    }

    public class DeleteAllByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 4, 5 });
            int expectedNumber = 1;
            yield return new object[] {value, list, expectedList, expectedNumber };
        }
    }
}
