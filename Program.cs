using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //deklarasi pembuatan menu 

            int pilih;
            float jawaban,pertama,kedua;

            Console.WriteLine("Kalkulator Sederhana");
            Console.WriteLine("Pilih menu");
            Console.WriteLine("1.Penambahan");
            Console.WriteLine("2.Penguranagan");
            Console.WriteLine("3.perkalian");
            Console.WriteLine("4.Pembagian");
            Console.WriteLine("5.Keluar");
            Console.WriteLine("==============");

            Console.Write("Masukkan menu pilihan anda (1-4) : ");
            pilih = Convert.ToInt16(Console.ReadLine());
            switch (pilih)
            {
                case 1:
                    Console.Write("masukkan angka pertama : ");
                    pertama = Convert.ToSingle(Console.ReadLine());
                    Console.Write("masukkan angka kedua : ");
                    kedua = Convert.ToSingle(Console.ReadLine());
                    jawaban = pertama + kedua;
                    Console.Write("Jawaban = " + jawaban);
                    Console.ReadKey ();
                    break;
                case 2:
                    Console.Write("masukkan angka pertama : ");
                    pertama = Convert.ToSingle(Console.ReadLine());
                    Console.Write("masukkan angka kedua : ");
                    kedua = Convert.ToSingle(Console.ReadLine());
                    jawaban = pertama - kedua;
                    Console.Write("Jawaban = " + jawaban);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Write("masukkan angka pertama : ");
                    pertama = Convert.ToSingle(Console.ReadLine());
                    Console.Write("masukkan angka kedua : ");
                    kedua = Convert.ToSingle(Console.ReadLine());
                    jawaban = pertama * kedua;
                    Console.Write("Jawaban = " + jawaban);
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Write("masukkan angka pertama : ");
                    pertama = Convert.ToSingle(Console.ReadLine());
                    Console.Write("masukkan angka kedua : ");
                    kedua = Convert.ToSingle(Console.ReadLine());
                    jawaban = pertama / kedua;
                    Console.Write("Jawaban = " + jawaban);
                    Console.ReadKey();
                    break;
                case 5:
                    Console.Write("goodbye");
                    Console.ReadKey(); 
                    break;
               default :
                    Console.WriteLine("Inputan anda salah silakan ulangi !!");
                    Console.ReadKey();
                    //main();
                    break;
            }
        }
    }
}