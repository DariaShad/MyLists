﻿using System;

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

        public void Add(int value)
        {
            if (Length < _array.Length)
            {
                UpSize();
            }
            _array[Length] = value;
            Length++;


            //if (Length < _array.Length)
            //{
            //    _array[Length] = value;
            //    Length++;
            //}
            //else
            //{
            //    UpSize();
            //    _array[Length] = value;
            //    Length++;
            //}

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
