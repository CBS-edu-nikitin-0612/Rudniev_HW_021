using System;
using System.Collections;

namespace aditionalTask
{
    class MyClass
    { }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(4);
            arrayList.Add("aditionalTask");
            arrayList.Add(new MyClass());

            int temp = 0;
            for (int i = 0; i < arrayList.Count; i++)
            {
                if (arrayList[i] is Int32)
                    temp += (int)arrayList[i];
            }

            //Сталкиваемся с проблемой неявной типизации коллекции. 
            //При работе с элементом коллекции приходится делать приведение к типу с которым мы работаем. 
            //Также мы не можем быть уверенны в том, что именно этот тип будет находится в коллекции. 
            //И в таком случае происходит упаковка и расспаковка.
        }
    }
}
