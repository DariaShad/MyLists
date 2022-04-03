using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyLists.Tests.ArrayListTestSources
{
    class DeleteByValueReturnIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int expectedIndex = 3;
            int value = 4;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 });
            yield return new object[] { value, expectedIndex, list };
        }
    }
}
