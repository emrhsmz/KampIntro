using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // T => Type 
    {
        T[] items;
        public MyList() // ctor - constructor tab tab // bir class new olarak instance oluşturulduğu an constructor çalışır.
        {
            items = new T[0]; // oluşturulan array 0 değeri verir
        }
        public void Add(T item)
        {
            T[] tempArray = items; // arrayin referansını tutuyorum.
            items = new T[items.Length + 1]; // elaman sayısını bir arttırdık
            for (int i = 0; i < tempArray.Length; i++)  //tempArrayin değeri kadar dönüyoruz.
            {
                items[i] = tempArray[i]; // items arrayimizle temp arrayi eşitliyoruz.
            }

            items[items.Length - 1] = item; // items array 0 dan başladığı için 1 eksik alıp item ekliyoruz.
        }

        public int Length
        {
            get { return items.Length; } // get : getter
        }

        public T[] Items
        {
            get { return items; } // get : getter
        }
    }
}
