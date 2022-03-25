using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class AddByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 5;
            int index = 6;
            ArrayList list = new ArrayList(new int[] { 0, 1, 2, 3, 4 });
            ArrayList expectedList = new ArrayList(new int[] { 0, 1, 2, 3, 4, 5 });
            yield return new object[] { value, index, list, expectedList };
        }
    }
}
