using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Ebru", "Gökçe","Sultan","Satı"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; //new deyince yeni referans oluşturuyo eski değerler çalışmıyor.
            //isimler[4] = "Beyza";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
            // ctrl k cntrl v  toplu command alma u
            List<string> isimler2 = new List<string> { "Ebru", "Gökçe", "Sultan", "Satı" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Beyza");  //add dediğimiz için eleman sayısı artıyor.
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            

        }
    }
}
