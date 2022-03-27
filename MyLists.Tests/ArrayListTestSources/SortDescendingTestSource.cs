using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyLists.Tests.ArrayListTestSources
{
    class SortDescendingTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 4, 5, 2, 9, 3 });
            ArrayList expectedList = new ArrayList(new int[] { 9, 5, 4, 3, 2, 1 });
            yield return new object[] { list, expectedList };
        }
    }
}
