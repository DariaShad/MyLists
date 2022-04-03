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
        //3 конструктора (пустой, на основе одного элемента, на основе массива )

        public ArrayList(int element) //конструктор
        {
            int[] massive = new int[1] { element};
            _array = massive;
        }

        public ArrayList(int [] array)
        {
            _array = array;
            Length = array.Length;
        }
        // 1. Добавление значения в конец
        public void AddToEnd(int value)
        {
            if (Length >= _array.Length)
            {
                UpSize();
            }
            _array[Length] = value;
            Length++;
        }

        // 2. Добавление значения в начало
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

        // 3. Добавление значения по индексу
        public void AddByIndex(int value, int index)
        {
            if(index>Length)
            {
                throw new Exception("Index should be less than the length of the list");
            }
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

       
        // 4. удаление из конца одного элемента

        public void DeleteLast()
        {
            if (Length==0)
            {
                throw new Exception("Length == 0");
            }
            Length--;
        }

        // 5. удаление из начала одного элемента
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

        // 6. удаление по индексу одного элемента
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

        // 7. удаление из конца N элементов
        public void DeleteFromEndNElements(int N)
        {
            for(int i=0; i<N; i++)
            {
                this.DeleteLast();
            }
        }

        // 8.  удаление из начала N элементов
        public void DeleteFromBeginningNElement(int N)
        {
            for (int i = 0; i < N; i++)
            {
                this.DeleteFirst();
            }
        }

        // 9. удаление по индексу N элементов
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

        //10. вернуть длину (свойство)

        // 11. доступ по индексу, 13. изменение по индексу
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

        // 12. первый индекс по значению (-1 - не нашел)

        public int FindIndexByValue(int value)
        {
            int resultNotFound = -1;
            for(int i=0; i<Length; i++)
            {
                if(_array[i]==value)
                {
                    return i;
                }
            }

            return resultNotFound;
        }

        // 14. реверс
        public void Reverse()
        {
            int index = 0;
            int[] newArray = new int[_array.Length];
            for(int i=Length-1; i>=0; i--)
            {
                newArray[index] = _array[i];
                index++;
            }
            _array = newArray;
        }

        // 15. поиск значения максимального элемента
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

        // 16. поиск значения минимального элемента
        public int FindMinElement()
        {
            
            int minElement = _array[0];
            for (int i = 0; i < Length; i++)
            {
                if (minElement > _array[i])
                {
                    minElement = _array[i];
                }
            }
            return minElement;
        }

        // 17. поиск индекс максимального элемента
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

        // 18. поиск индекс минимального элемента
        public int FindIndexMinElement()
        {
            int MinElement = _array[0];
            int index = 0;
            for (int i = 0; i < Length; i++)
            {
                if (MinElement > _array[i])
                {
                    MinElement = _array[i];
                    index = i;
                }
            }
            return index;
        }

        //19. сортировка по возрастанию
        public void SortAscending()
        {
            int tmp = 0;
            for (int i = 0; i < Length; i++)
            {
                for (int j = i; j < Length; j++)
                {
                    if (_array[i]> _array[j])
                    {
                        tmp = _array[i];
                        _array[i] = _array[j];
                        _array[j] = tmp;
                    }
                }
            }
        }

        //20. сортировка по убыванию
        public void SortDescending()
        {
            int tmp = 0;
            for (int i = 0; i < Length; i++)
            {
                for (int j = i; j < Length; j++)
                {
                    if (_array[i] < _array[j])
                    {
                        tmp = _array[i];
                        _array[i] = _array[j];
                        _array[j] = tmp;
                    }
                }
            }
        }

        //21. удаление по значению первого элемента (вернуть индекс)
        public int DeleteByValueReturnIndex(int value)
        {
            int index = 0;
            int[] newArray = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                if (_array[i]==value)
                {
                   index = i;
                    i++;
                }
                newArray[i] = _array[i];
            }
            _array = newArray;
            return index;
        }

        // 22. удаление по значению всех (вернуть кол-во)
        public int DeleteAllByValue(int value)
        {
            int count = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    count++;
                }
                else
                {
                    _array[i - count] = _array[i];
                }
            }
            Length -= count;

            return count;
        }

        // 23. 3 конструктора (наверху написаны)
        public void Write()
        {
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{_array[i] }" + ", ");
            }
            Console.WriteLine();
        }

        //24.добавление списка (вашего самодельного) в конец

        public void AddList(ArrayList list)
        {
            if (list is null)
            {
                throw new NullReferenceException();
            }

            for (int i = 0; i < list.Length; i++)
            {
                this.AddToEnd(list[i]);
            }
        }

        //25. добавление списка в начало
        public void AddListToBeginning(ArrayList list)
        {
            int newLength = Length + list.Length;
            int[] newArray = new int[newLength];
            for (int i = 0; i < list.Length; i++)
            {
                newArray[i] = list[i];
            }

            for (int i = 0; i < Length; i++)
            {
                newArray[i + list.Length] = _array[i];
            }

            _array = newArray;
            Length = newArray.Length;
        }
    
        //26.добавление списка по индексу
        public void AddListByIndex(ArrayList list, int index)
        {
            if (list.Length == 0 || _array.Length == 0)
            {
                throw new Exception("Empty list!");
            }
            if (index < 0 || index > _array.Length)
            {
                throw new IndexOutOfRangeException("index");
            }
            int newLength = Length + list.Length;
            int[] newArray = new int[newLength];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }
            for (int i = 0; i < list.Length; i++)
            {
                newArray[i + index] = list[i];
            }
            for (int i = 0; i < Length - index; i++)
            {
                newArray[i + index + list.Length] = _array[i + index];
            }
            _array = newArray;
            Length = newArray.Length;
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

        public override string ToString()
        {
            string s = "[";

            for (int i = 0; i < Length; i++)
            {
                s += $"{_array[i]} ";
            }
            s += "]";
            return s;
        }

        public override bool Equals(object obj)
        {
            bool isEqual = true;

            if (obj == null || !(obj is ArrayList))
            {
                isEqual = false;
            }
            else
            {
                ArrayList list = (ArrayList)obj;

                if (list.Length != this.Length)
                {
                    isEqual = false;
                }
                else
                {
                    for (int i = 0; i < this.Length; i++)
                    {
                        if (list[i] != this[i])
                        {
                            isEqual = false;
                        }
                    }
                }
            }
            return isEqual;
        }


    }
}
