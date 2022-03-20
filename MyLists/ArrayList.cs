using System;

namespace MyLists
{
    public class ArrayList
    {
        public int Length { get; private set; }

        private int[] _array;

        public ArrayList()
        {
            _array = new int[10];
            Length = 0;
        }

        public void AddToEnd(int value)
        {
            if (Length < _array.Length)
            {
                UpSize();
            }
            _array[Length] = value;
            Length++;
        }

        public void AddToBeginning(int value)
        {
            int newLength = _array.Length+1;
            int[] newArray = new int[newLength];
            for(int i=0; i<newLength; i++)
            {
                _array[i] = newArray[i + 1];
            }
            newArray[0] = value;
        }

        public void AddByIndex(int value)
        {

        }
        public void Write()
        {
            for(int i=0; i < Length; i++)
            {
                Console.Write($"{_array[i] }");
            }
            Console.WriteLine();
        } 

        private void UpSize()
        {
            int newLength = (int)(_array.Length * 1.5d + 1);
            int[] newArray = new int[newLength];
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }


    }
}
