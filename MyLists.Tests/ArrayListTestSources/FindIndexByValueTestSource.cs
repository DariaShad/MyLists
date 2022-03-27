using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyLists.Tests.ArrayListTestSources
{
    class FindIndexByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index;
            int value = 3;
            int expectedIndex = 2;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return new object[] { value, expectedIndex, list};
        }
    }
}
