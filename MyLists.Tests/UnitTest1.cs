using NUnit.Framework;
using System.Collections;
using MyLists;
using MyLists.Tests.ArrayListTestSources;
namespace MyLists.Tests

{
    public class Tests
    {

        [Test]
        public void AddToEndTest()
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
            Assert.AreEqual(list, expectedList);
        }

        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(ArrayList list, ArrayList expectedList)
        {
            list.DeleteLast();
            Assert.AreEqual(expectedList, list);
        }

        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(int value, int index, ArrayList list, ArrayList expectedList)
        {
            list.AddByIndex(value, index);
            Assert.AreEqual(expectedList, list);

        }

        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeleteFirstTest(ArrayList list, ArrayList expectedList)
        {
            list.DeleteFirst();
            ArrayList actualList = list;
            Assert.AreEqual(expectedList, list);
        }

        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(int index, ArrayList list, ArrayList expectedList)
        {
            list.DeleteByIndex(index);
            Assert.AreEqual(list, expectedList);
        }

        [TestCaseSource(typeof(DeleteFromEndNElementsTestSource))]
        public void DeleteFromEndNElementsTest(int N, ArrayList list, ArrayList expectedList)
        {
            list.DeleteFromEndNElements(N);
            Assert.AreEqual(list, expectedList);
        }

        [TestCaseSource(typeof(DeleteFromBeginningNElementTestSource))]
        public void DeleteFromBeginningNElementTest(int N, ArrayList list, ArrayList expectedList)
        {
            list.DeleteFromBeginningNElement(N);
            Assert.AreEqual(expectedList, list);
        }

        [TestCaseSource(typeof(DeleteByIndexNElementsTestSource))]
        public void DeleteByInndexNElementsTest(int index, int amount, ArrayList list, ArrayList expectedList)
        {
            list.DeleteByIndexNElements(index, amount);
            Assert.AreEqual(expectedList, list);
        }

        [TestCaseSource(typeof(FindIndexByValueTestSource))]
        public void FindIndexByValueTest(int value, int expectedIndex, ArrayList list)
        {
            var index=list.FindIndexByValue(value);
            Assert.AreEqual(expectedIndex, index);
        }

        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(ArrayList list, ArrayList expectedList)
        {
            list.Reverse();
            Assert.AreEqual(expectedList, list);
        }

        [TestCaseSource(typeof(FindMaxTestSource))]
        public void FindMaxTest(int expectedMaxElement, ArrayList list)
        {
            var maxElement=list.FindMax();
            Assert.AreEqual(expectedMaxElement, maxElement);
        }

        [TestCaseSource(typeof(FindMinElementTestSource))]
        public void FindMinElementTest(int expectedMinElement, ArrayList list)
        {
            var minElement = list.FindMinElement();
            Assert.AreEqual(expectedMinElement, minElement);
        }
        [TestCaseSource(typeof(FindIndexMaxElementTestSource))]
        public void FindIndexMaxElementTest(int expectedIndex, ArrayList list)
        {
            var index = list.FindIndexMaxElement();
            Assert.AreEqual(expectedIndex, index);
        }
        [TestCaseSource(typeof(FindIndexMinElementTestSource))]
        public void FindIndexMinElementTest(int expectedIndex, ArrayList list)
        {
            var index = list.FindIndexMinElement();
            Assert.AreEqual(expectedIndex, index);
        }
        [TestCaseSource(typeof(SortAscendingTestSource))]
        public void SortAscendingTest(ArrayList list, ArrayList expectedList)
        {
            list.SortAscending();
            Assert.AreEqual(expectedList, list);
        }
        [TestCaseSource(typeof(SortDescendingTestSource))]
        public void SortDesscendingTest(ArrayList list, ArrayList expectedList)
        {
            list.SortDescending();
            Assert.AreEqual(expectedList, list);
        }
        [TestCaseSource(typeof(DeleteByValueReturnIndexTestSource))]
        public void DeleteByValueReturnIndexTest(int value, int expectedIndex, ArrayList list)
        {
            var index = list.DeleteByValueReturnIndex(value);
            Assert.AreEqual(expectedIndex, index);
        }

    }
}

