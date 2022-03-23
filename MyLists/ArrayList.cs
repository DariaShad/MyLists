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
            if (Length >= _array.Length)
            {
                UpSize();
            }
            _array[Length] = value;
            Length++;
        }

        public void AddByIndex(int value, int index)
        {
            if (index >= Length)
            {
                return;
            }

            if (_array.Length == Length)
            {
                UpSize();
            }

            int newLength = _array.Length;
            int[] newArray = new int[newLength + 1];

            for (int j = 0; j < index; j++)
            {
                newArray[j] = _array[j];
            }

            for (int i = index; i < _array.Length; i++)
            {
                newArray[i + 1] = _array[i];
            }

            newArray[index] = value;
            _array = newArray;

            Length++;
        }


        public void AddToBeginning(int value)
        {
            if (Length >= _array.Length)
            {
                UpSize();
            }
            int[] newArray = new int[_array.Length];

            for (int i = 0; i < Length; i++)
            {
                newArray[i + 1] = _array[i];
            }

            newArray[0] = value;
            _array = newArray;
            Length++;
        }

        //удаление из конца одного элемента

        public void DeleteLast()
        {
            if (Length==0)
            {
                throw new Exception("Length == 0");
            }
            Length--;
        }

        //удаление из начала одного элемента
        public void DeleteFirst()
        {
            int[] newArray = new int[_array.Length];
            for(int i=1; i<_array.Length; i++)
            {
                newArray[i - 1] = _array[i];
            }
            _array = newArray;
            Length--;
        }

        //удаление по индексу одного элемента
        public void DeleteByIndex(int index)
        {
            int[] newArray = new int[_array.Length];

            for (int i=0; i<index; i++)
            {
                newArray[i] = _array[i];
            }    

            for (int j=index+1; j<Length; j++)
            {
                newArray[j-1] = _array[j];
            }
            _array = newArray;
            Length--;
        }

        //удаление из конца N элементов
        public void DeleteFromEndNElements(int N)
        {
            for(int i=0; i<N; i++)
            {
                this.DeleteLast();
            }
        }

        //удаление по индексу N элементов
        public void DeleteByIndexNElements(int index, int amount)
        {
            int[] newArray = new int[_array.Length];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }

            for (int j = index+amount; j < Length; j++)
            {
                newArray[j - amount] = _array[j];
            }
            _array = newArray;
            Length-=amount;
        }

        //вернуть длину
        public void ReturnLength()
        {
           
        }

        //доступ по индексу 


        public void Write()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{_array[i] }" + ", ");
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
