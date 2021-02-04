using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TKey, TValue>
    {
        //List<TKey> keys;
        //List<TValue> values;
        TKey[] items;
        TValue[] items1;
        public MyDictionary()
        {
            items = new TKey[0];
            items1 = new TValue[0];
            
           
        }

        public void Add(TKey item, TValue item1)
        {
            TKey[] tempArray = items;
            items = new TKey[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

            TValue[] tempArray1 = items1;
            items1 = new TValue[items1.Length + 1];
            for (int i = 0; i < tempArray1.Length; i++)
            {
                items1[i] = tempArray1[i];
            }
            items1[items.Length - 1] = item1;

        }

        
    }
}
