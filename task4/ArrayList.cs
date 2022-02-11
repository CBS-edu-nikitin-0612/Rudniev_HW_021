using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class ArrayList
    {
        private object[] array;
        public object this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                throw new IndexOutOfRangeException();
            }
        }
        public int Count => array.Length;
        public ArrayList()
        {
            array = new object[0];
        }

        public void Add(object item)
        {
            object[] temp = new object[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
                temp[i] = array[i];
            temp[array.Length] = item;
            array = temp;
        }
        public void Remove(object item)
        {
            int n = -1, j = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i].GetHashCode() == item.GetHashCode())
                    n = i;

            if (n == -1)
                return;

            object[] temp = new object[array.Length - 1];
            for (int i = 0; i < array.Length; i++)
                if (i != n)
                {
                    temp[j] = array[i];
                    j++;
                }

            array = temp;
        }
        public void Clear()
        {
            array = new object[0];
        }
    }
}
