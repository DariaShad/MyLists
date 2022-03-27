using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyLists.Tests.ArrayListTestSources
{
    class SortAscendingTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 4, 5, 2, 9, 3 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3, 4, 5, 9, });
            yield return new object[] { list, expectedList };
        }
    }
}
