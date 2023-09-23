using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            //yukarıdaki kod satırında geçici bir dizi oluşturup bunun items dizisinin adresini göstermesini sağlıyoruz.
            //Diziler, referans tip olduklarından new diyip dizinin eleman sayısını arttırırsak
            //bu sefer önceki kaydolmuş değerler silinir. Bunu önlemek için geçici bir dizi oluşturup varolan değere eşliyoruz ki
            //varolan değerin adresi kaybolmasın.
            items = new T[items.Length + 1];
            // bu kod ile dizinin elaman sayısını bir arttırıyoruz.

           for(int i = 0; i <tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1]=item;//son elemanı için items.lenght-1 yaptık. Dizinin son elemanı kullanıcının girdiği item T veri tipindeki değşken dedik.
        }

        public T[] Items //code ları test etmek için boyle bir sey olusturduk.
        {
            get { return items; }
        }
    }
}
