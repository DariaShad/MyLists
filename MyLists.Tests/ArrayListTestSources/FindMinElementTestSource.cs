using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyLists.Tests.ArrayListTestSources
{
    class FindMinElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 5, 3, 6, 1, 8, 0 });
            int expectedElement = 0;
            yield return new object[] { expectedElement, list };
        }
    }
}
