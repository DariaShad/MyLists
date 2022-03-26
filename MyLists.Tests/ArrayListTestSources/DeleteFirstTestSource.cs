using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyLists.Tests.ArrayListTestSources
{
    internal class DeleteFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 2, 3, 4, 5 });
            yield return new object[] { list, expectedList };
        }
    }
}
