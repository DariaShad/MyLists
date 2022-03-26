using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace MyLists.Tests

{
    internal class AddToBeginningTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 1;
            ArrayList list = new ArrayList(new int[] { 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            yield return  new object[] { value, list, expectedList,};
        }
    }
}