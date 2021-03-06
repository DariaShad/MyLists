using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace MyLists.Tests.ArrayListTestSources
{
    internal class DeleteAllByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 4, 5 });
            int expectedNumber = 1;
            yield return new object[] { value, list, expectedList, expectedNumber };


            value = 2;
            list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            expectedList = new ArrayList(new int[] { 1, 5 });
            expectedNumber = 3;
            yield return new object[] { value, list, expectedList, expectedNumber };
        }
    }
}
