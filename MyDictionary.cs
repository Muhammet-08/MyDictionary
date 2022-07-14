using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T>
    {
        T[] names;
        T[] tempNames;

        public MyDictionary()
        {
            names = new T[0];
        }

        public void Add(T name)
        {
            tempNames = names;
            names = new T[names.Length + 1];
            for (int i = 0; i < tempNames.Length; i++)
            {
                names[i] = tempNames[i];
            }

            names[names.Length-1] = name;
        }

        

        public int Count
        {
            get { return names.Length; }
        }

    }
}
