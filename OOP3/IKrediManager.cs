using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //class yerine interface(arayüz) yazdık şablon olarak.okunurluğu 
    //arttırmak için IKredi.. diye başlatıyoruz.interface old anlayabilmek için
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();

        
    }
}

//interface leri birbirinin alternatifi olan ama kod içerikleri 
//farklı olan durumlar için kullanırız.
