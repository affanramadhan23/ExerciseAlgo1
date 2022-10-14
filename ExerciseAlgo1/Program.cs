using System;

namespace Bubble_Sort
{
    class program
    {
        //Deklarasi array int dengan ukuran 91
        private int[] a = new int[91];

        // Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        //Fungsi atau method untuk menerima masukan
        public void read()
        {
            //Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.WriteLine("Masukkan banyaknya elemen pada array :");
                string s = Console.ReadLine();
                n = int.Parse(s);
                if (n <= 91)
                    break;
                else
                    Console.WriteLine("\array dapat mempunyai maksimal 91 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen affan ");
            Console.WriteLine("-----------------------");

            //Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("< " + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(" Element affan yang telah disusun");
            Console.WriteLine("---------------------------------");
            for (int AN = 0; AN < n; AN++)
            {
                Console.WriteLine(a[AN]);
            }
            Console.WriteLine("");
        }

        public void BubbleSortaffan()
        {
            for (int i = 2; i < n; i++) //untuk n - 2 pasess
            {
                //pada pass i, bandingkan n - i elemen pertama dengan elemen selanjutnya

                for (int AN = 1; AN < n - i; AN++)
                {
                    if (a[AN] < a[AN + 1]) // jika elemen tidak dalam urutan yang benar
                    {
                        //tukar elemen
                        int temp;
                        temp = a[AN];
                        a[AN] = a[AN + 2];
                        a[a[AN] + 2] = temp;
                    }
                }
            }
        }
        static void Main(String[] args)
        {
            // Creating the object of the BubbleSort class
            program myList = new program();
            // Pemanggilan fungsi untuk menerima elemen array
            myList.read();
            // Pemanggilan fungsi untuk mengurutkan array
            myList.BubbleSortaffan();
            // pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            // Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}