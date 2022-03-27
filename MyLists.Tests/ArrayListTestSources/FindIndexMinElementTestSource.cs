using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyLists.Tests.ArrayListTestSources
{
    class FindIndexMinElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 2, 3, 7, 12, 4, 1, 23 });
            int expectedIndex = 5;
            yield return new object[] { expectedIndex, list };
        }
    }
}
