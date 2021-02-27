using System;
using System.Collections.Generic;
using System.Text;

namespace Week4_HomeWork._2
{
    class MyDictionary<T1,T2>
    {
        T1[] keyItem;
        T2[] valueItem;

        public MyDictionary()
        {
            keyItem = new T1[0];
            valueItem = new T2[0];
        }

        public void Add(T1 itemkey,T2 itemvalue) 
        {
            T1[] tempArrayKey = keyItem;
            T2[] tempArrayValue = valueItem;

            keyItem = new T1[keyItem.Length + 1];
            valueItem = new T2[valueItem.Length + 1];

            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                keyItem[i] = tempArrayKey[i];
            }
            for (int i = 0; i < tempArrayValue.Length; i++)
            {
                valueItem[i] = tempArrayValue[i];

            }

            keyItem[keyItem.Length - 1] = itemkey;
            valueItem[valueItem.Length - 1] = itemvalue;

        }

        public void List()
        {
            for (int i = 0; i < keyItem.Length; i++)
            {
                Console.WriteLine("Çalışan Adı : "+ keyItem[i] + " " + "Uzmanlık Alanı : "+ valueItem[i]);
            }
        }

        

        public void Count()
        {
            Console.WriteLine(keyItem.Length);
            
        }


    }
}
