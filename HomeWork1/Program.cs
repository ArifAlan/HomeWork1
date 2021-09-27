using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)

        {
            Product Telefon1 = new Product();
            Telefon1.urunAdi = "Iphone";
            Telefon1.urunFiyati = 20000;
            Telefon1.urunHafizasi = "256 GB";


            Product Telefon2 = new Product();
            Telefon2.urunAdi = "Samsung";
            Telefon2.urunFiyati = 2000;
            Telefon2.urunHafizasi = "64GB";


            Product Telefon3 = new Product();
            Telefon3.urunAdi = "Huawei";
            Telefon3.urunFiyati = 1000;
            Telefon3.urunHafizasi = "16 GB";

            Product[] Telefonlar = new Product[] { Telefon1 , Telefon2,Telefon3 };

            foreach (var Product in Telefonlar)
            {
                Console.WriteLine("ÜRÜN ADI :" + Product.urunAdi+"  "+"Ürün fiyaı: "+Product.urunFiyati+" "+"Ürün Hafızası : "+Product.urunHafizasi);
               
            }
            Console.WriteLine("                     ");
            Console.WriteLine("------------------------------");

            for (int i = 0; i < Telefonlar.Length; i++)
            {
                Console.WriteLine("Ürün Adı : "+Telefonlar[i].urunAdi+" "+"Ürün Fıyatı : "+Telefonlar[i].urunFiyati+" "+"Ürün Hafızası : "+Telefonlar[i].urunHafizasi);
            }
            Console.WriteLine("                     ");
            Console.WriteLine("------------------------------");


            int x = 0;
            while (x<Telefonlar.Length)
            {
             
                Console.WriteLine("Ürün Adı : " + Telefonlar[x].urunAdi + " " + "Ürün Fıyatı : " + Telefonlar[x].urunFiyati + " " + "Ürün Hafızası : " + Telefonlar[x].urunHafizasi);
                x++;
            }

        }

    }

    class Product
    {
        public string urunAdi { get; set; }
        public int urunFiyati { get; set; }
        public string urunHafizasi { get; set; }
    }
        
}
