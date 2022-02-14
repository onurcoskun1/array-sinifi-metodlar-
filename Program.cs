using System;

namespace array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = {7,15,34,26,11,4,8,22};

            Console.WriteLine("Sırasız Dizi");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);


            Console.WriteLine("Sıralı Dizi");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Clear
            Console.WriteLine("Array Clear Metodu");
            //İlgili dizinin elemanlarını kullanarak 2. index'ten itibaren 2 tane elemanını sıfırlar.
            Array.Clear(sayiDizisi,2,2);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("Reverse Metodu");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("IndexOf Metodu");
            Console.WriteLine( Array.IndexOf(sayiDizisi, 15));

            Console.WriteLine("Resize Metodu");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);


	
        }
    }
}
