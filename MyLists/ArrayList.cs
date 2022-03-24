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
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[index];
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[index] = value;
            }
        }

        //первый индекс по значению (-1 - не нашел)


        //изменение по индексу
        //public int this[int index]
        //{
        //    get
        //    {
        //        if (index < 0 || index >= Length)
        //        {
        //            throw new IndexOutOfRangeException();
        //        }
        //        return _array[index];
        //    }
        //    set
        //    {
        //        if (index < 0 || index >= Length)
        //        {
        //            throw new IndexOutOfRangeException();
        //        }
        //        _array[index] = value;
        //    }
        //}

        //реверс
        public void Reverse()
        {
            int index = 0;
            int[] newArray = new int[_array.Length];
            for(int i=_array.Length; i>=0; i--)
            {
                newArray[index] = _array[i];
                index++;
            }
            _array = newArray;
        }

        //поиск значения максимального элемента
        public int FindMax()
        {
            int maxElement = _array[0];
            for (int i = 0; i < _array.Length; i++)
            {
                if (maxElement < _array[i])
                {
                    maxElement = _array[i];
                }
            }
            return maxElement;
        }

        //поиск значения минимального элемента
        public int FindMinElement()
        {
            
            int minElement = _array[0];
            for (int i = 0; i < _array.Length; i++)
            {
                if (minElement > _array[i])
                {
                    minElement = _array[i];
                }
            }
            return minElement;
        }

        //поиск индекс максимального элемента
        public int FindIndexMaxElement()
        {
            int MaxElement = _array[0];
            int index = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (MaxElement < _array[i])
                {
                    MaxElement = _array[i];
                    index = i;
                }
            }
            return index;
        }

        //поиск индекс минимального элемента
        public int FindIndexMinElement()
        {
            int MinElement = _array[0];
            int index = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (MinElement > _array[i])
                {
                    MinElement = _array[i];
                    index = i;
                }
            }
            return index;
        }
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
