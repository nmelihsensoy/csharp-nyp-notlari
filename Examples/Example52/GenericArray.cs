using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example52
{
    class GenericArray<T>
    {
        private T[] array;
        private int size;
        private T defaultVal;

        public GenericArray(int size, T defaultVal)
        {
            this.size = size;
            this.defaultVal = defaultVal;
            array = new T[size+1];
            for (int i=0; i<size; i++)
            {
                array[i] = defaultVal;
            }
        }

        public void swapFirstSecond()
        {
            swap<T>(ref array[0], ref array[1]);
        }

        public static void swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index<=size-1)
                {
                    return array[index];
                }
                else
                {
                    return defaultVal;
                }
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    if (value.GetType() == typeof(T))
                    {
                        array[index] = value;
                    }
                    else
                    {
                        throw new System.ArgumentException("Wrong Type");
                    }
                }
            }
        }
    }
}
