using System;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product0 = new Products();

            product0.Category = "Mutfak Eşyası";
            product0.ProductName = "Fincan Takımı";
            product0.Color = "Kırmızı";
            product0.Company = "Karaca";
            product0.Price = 90;


            Products product1 = new Products();

            product1.Category = "Teknolojik Aletler";
            product1.ProductName = "klavye";
            product1.Color = "Mavi";
            product1.Company = "Logitech";
            product1.Price = 65;


            Products product2 = new Products();

            product2.Category = "Aksesuar";
            product2.ProductName = "Kolye";
            product2.Color = "Sarı";
            product2.Company = "Koton";
            product2.Price = 35;


            Products product3 = new Products();

            product3.Category = "Ayakkabı";
            product3.ProductName = "Postal";
            product3.Color = "Siyah";
            product3.Company = "FLO";
            product3.Price = 120;


            Products product4 = new Products();

            product4.Category = "Makyaj Ürünleri";
            product4.ProductName = "Likit Mat Ruj";
            product4.Color = "Bordo";
            product4.Company = "M.A.C.";
            product4.Price = 160;


            Products product5 = new Products();

            product5.Category = "Çanta";
            product5.ProductName = "Sırt Çantası";
            product5.Color = "Lacivert";
            product5.Company = "H&M";
            product5.Price = 80;


            // ürünleri dizi içerisine atama

            Products[] products = new Products[] { product0, product1, product2, product3, product4, product5 };
            // products listesini product degiskenine atayarak foreach döngüsü ile ürün rengi + ismi + fiyatı şeklinde yazdırma
            foreach (var product in products)
            {
                Console.WriteLine(product.Color + " " + product.ProductName + " : " + product.Price + " TL ");
            }
            // for döngüsü ile dizide yer alan ürünlerin firmalarını yazdırma
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(products[i].ProductName + "-" + "Üretici Firma: " + products[i].Company);
            }
            // while döngüsü ile dizide yer alan ürünlerin fiyatlarını yazdırma
            int p = 0;
            while (p != products.Length)
            {
                Console.WriteLine(products[p].Color + " " + products[p].ProductName + " Fiyat: " + products[p].Price);
                p++;
            }

            Sum sum1 = new Sum();
            sum1.summary = product0.Pr
                ice + product1.Price + product2.Price + product3.Price + product4.Price + product5.Price;

            Console.WriteLine("Toplam Ödenecek Tutar: " + sum1.summary);

        }
    }


    class Products
    {
        public string Category { get; set; }
        public string ProductName { get; set; }
        public string Color { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }


    }

    class Sum
    {
        public int summary { get; set; }
    }



}