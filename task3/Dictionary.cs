using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Dictionary<TKey, TValue>
    {
        private TKey[] keys;
        private TValue[] values;
        public TValue[] this[TKey index]
        {
            get
            {
                TValue[] tempValues = new TValue[0];
                for (int i = 0; i < keys.Length; i++)
                    if (keys[i].ToString() == index.ToString())
                    {
                        TValue[] temp = new TValue[tempValues.Length + 1];
                        for (int j = 0; j < tempValues.Length; j++)
                            temp[j] = tempValues[j];
                        temp[tempValues.Length] = values[i];
                        tempValues = temp;
                    }
                return tempValues;
            }
        }
        public int Count => values.Length;
        
        public Dictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = new TKey[keys.Length + 1];
            TValue[] tempValues = new TValue[values.Length + 1];
            for (int i = 0; i < keys.Length; i++)
                tempKeys[i] = keys[i];
            for (int i = 0; i < values.Length; i++)
                tempValues[i] = values[i];
            tempKeys[keys.Length] = key;
            tempValues[values.Length] = value;
            keys = tempKeys;
            values = tempValues;
        }
        public void Clear()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
    }
}
