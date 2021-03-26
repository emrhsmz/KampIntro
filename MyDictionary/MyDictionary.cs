using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<MyKey, MyValue>
    {
        (MyKey, MyValue)[] keyValues;

        public MyDictionary()
        {
            keyValues = new (MyKey,MyValue)[0];
        }

        public void Add(MyKey No, MyValue Name)
        {
            (MyKey,MyValue)[] tempArray = keyValues;

            keyValues = new (MyKey,MyValue)[keyValues.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                keyValues[i] = tempArray[i];
            }

            keyValues[keyValues.Length - 1] = (No, Name);
        }

        public int Length
        {
            get { return keyValues.Length; } // get : getter
        }

        public void Listeleme()
        {
            for (int i = 0; i < keyValues.Length; i++)
            {
                Console.WriteLine("Adı ve Numarası" + keyValues[i]);
            }
        }
    }
}
