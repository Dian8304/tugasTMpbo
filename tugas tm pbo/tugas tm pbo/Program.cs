using Animal;
using System;
using abstrak;
internal class Program
{

    static void Main(string[] args)
    {
        Animal.Cemani cemani1 = new Animal.Cemani("Ciki");
        Animal.Kapas kapas1 = new Animal.Kapas("Flufi");
        Animal.Batik batik1 = new Animal.Batik("Suwiwi");
        Animal.Kapas kapas2 = new Animal.Kapas("Waluyo");


        cemani1.Bersuara();
        kapas1.Berlari("string");
        batik1.Berlari(1);
        kapas2.Berlari(1);
        kapas2.Makan();
        kapas1.AyamDijual();
        kapas1.AyamBermain();
    }
}