using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyLists.Tests.ArrayListTestSources
{
    class DeleteByIndexNElementsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 2;
            int amount = 3;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 6, 7 });
            yield return new object[] { index, amount, list, expectedList };
        }
    }
}
