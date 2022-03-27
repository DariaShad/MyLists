using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyLists.Tests.ArrayListTestSources
{
    class FindMaxTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 5, 3, 1, 7, 10 });
            int expectedMaxElement = 10;
            yield return new object[] { expectedMaxElement, list };
        }
    }
}
