using System;
using System.Collections;

namespace ArratLis
{
    class Deneme
    {
        int x;

        public Deneme(int x )
        {
            this.x = x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList AList = new ArrayList();
            AList.Add("GAMZE");
            AList.Add("Ali");
            AList.Add("Ayse");
            object obj = AList;
            Deneme d = new Deneme(5);
            
            AList.Add(d);

            foreach(object i in AList)
                Console.WriteLine("bakim " + (object)i);





        }
    }
}
