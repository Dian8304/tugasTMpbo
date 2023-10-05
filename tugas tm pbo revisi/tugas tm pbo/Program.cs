using Animal;
using System;
using abstrak;
internal class Program
{
    static void Main(string[] args = null)
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("| Selamat Datang di Kandang Ayam Pak Bagyo! |");
        Console.WriteLine("--------------------------------------------\n");
        Console.WriteLine("Ayo lihat ayam hias milik Pak Bagyo!");
        Console.WriteLine("\n\nTekan ENTER untuk melanjutkan");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("\nLihat aktivitas ayam Pak Bagyo di sini!");
        Console.WriteLine($"\n1. Ciki si Ayam Cemani \n2. Lala si Ayam Cemani" +
        $"\n3. Tuti si Ayam Cemani \n4. Flufi si Ayam Kapas \n5. Waluyo si Ayam" +
        $" Kapas \n6. Siska si Ayam Kapas \n7. Suwiwi si Ayam Batik \n8. Lila si" +
        $" Ayam Batik \n9. Taro si Ayam Batik\n10. Keluar");
        Console.WriteLine("\nKetik nomor opsi ayam yang ingin kamu lihat\n");
        string pilihan = (Console.ReadLine());

        if (pilihan == "10")
        {
            Console.WriteLine("Sampai jumpa!");
        }
        else
        {
            while (pilihan != "10")
            {
                if (pilihan == "1")
                {
                    Animal.Cemani cemani1 = new Animal.Cemani("Ciki");
                    cemani1.Bersuara();
                    Console.WriteLine("\n\nTekan ENTER untuk melanjutkan");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else if (pilihan == "2")
                {
                    Animal.Cemani cemani2 = new Animal.Cemani("Lala");
                    cemani2.Berlari("string");
                    Console.WriteLine("\n\nTekan ENTER untuk melanjutkan");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else if (pilihan == "3")
                {
                    Animal.Cemani cemani3 = new Animal.Cemani("Tuti");
                    cemani3.Berlari(1);
                    Console.WriteLine("\n\nTekan ENTER untuk melanjutkan");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else if (pilihan == "4")
                {
                    Animal.Kapas kapas1 = new Animal.Kapas("Flufi");
                    kapas1.Makan();
                    Console.WriteLine("\n\nTekan ENTER untuk melanjutkan");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else if (pilihan == "5")
                {
                    Animal.Kapas kapas2 = new Animal.Kapas("Waluyo");
                    kapas2.negarasal();
                    Console.WriteLine("\n\nTekan ENTER untuk melanjutkan");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else if (pilihan == "6")
                {
                    Animal.Kapas kapas3 = new Animal.Kapas("Siska");
                    kapas3.Makan();
                    Console.WriteLine("\n\nTekan ENTER untuk melanjutkan");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else if (pilihan == "7")
                {
                    Animal.Batik batik1 = new Animal.Batik("Suwiwi");
                    batik1.AyamBermain();
                    Console.WriteLine("\n\nTekan ENTER untuk melanjutkan");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else if (pilihan == "8")
                {
                    Animal.Batik batik2 = new Animal.Batik("Lila");
                    batik2.AyamDijual();
                    Console.WriteLine("\n\nTekan ENTER untuk melanjutkan");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else if (pilihan == "9")
                {
                    Animal.Batik batik3 = new Animal.Batik("Taro");
                    batik3.AyamBermain();
                    Console.WriteLine("\n\nTekan ENTER untuk melanjutkan");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Menu tidak ada. Silakan pilih lagi!");
                    Console.WriteLine("\n\nTekan ENTER untuk melanjutkan");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
            }
            Program.Main(null);
            Console.Clear();
        }
    }
}