using NUnit.Framework;
using System.Collections;
using MyLists;
using MyLists.Tests.ArrayListTestSources;
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

        [TestCaseSource(typeof(DeleteAllByValueTestSource))]
        public void DeleteAllByValueTest(int value, ArrayList list, ArrayList expectedList, int expectedNumber)
        {
            int actualNumber = list.DeleteAllByValue(value);

            ArrayList actualList = list;
            Assert.AreEqual(expectedNumber, actualNumber);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddToBeginningTestSource))]
        public void AddToBeginningTest(int value, ArrayList list, ArrayList expectedList)
        {
            list.AddToBeginning(value);
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, actualList);
        }
        
        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(ArrayList list, ArrayList expectedList)
        {
            
        }
    }
}
