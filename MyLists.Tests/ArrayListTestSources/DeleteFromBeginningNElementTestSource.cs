using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyLists.Tests.ArrayListTestSources
{
    class DeleteFromBeginningNElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int N = 2;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            ArrayList expectedList = new ArrayList(new int[] { 3, 4, 5, 6 });
            yield return new object[] { N, list, expectedList };
        }
    }
}
