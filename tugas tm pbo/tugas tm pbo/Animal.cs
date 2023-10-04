using abstrak;

namespace Animal
{
    class Ayam
    {
        public string jenis;
        public string nama;
        public string warna;
        public int umur;
        public string jenisbulu;
        public int harga;

        public Ayam(string jenis, string nama, string warna, int umur, string jenisbulu, int harga)
        {
            this.jenis = jenis;
            this.nama = nama;
            this.warna = warna;
            this.umur = umur;
            this.jenisbulu = jenisbulu;
            this.harga = harga;
        }


        //overloading
        public void Berlari(string a)
        {
            Console.WriteLine($"{nama} si ayam {jenis} berwarna {warna} lari lagi!");
        }

        public void Berlari(int b)
        {
            Console.WriteLine($"{nama} si {jenis} berwarna {warna} dikejar kucing!");
        }

        //virtual untuk override
        public virtual void Makan()
        {
            Console.WriteLine($"{nama} si {jenis} {warna} suka makan.");
        }

        public virtual void Bersuara()
        {
            Console.WriteLine($"{nama} si {jenis} {warna} pernah berkata: ");
        }
    }


    //subclass cemani
    internal class Cemani : Ayam
    {
        public Cemani(string nama) : base("cemani", nama, "hitam", 2, "bulu hitam", 10000) { }

        public override void Bersuara()
        {
            Console.WriteLine($"Ayam {jenis} kecil, si {nama} bersuara Ciap Ciap Ciap");
        }
    }

    internal class Batik : Ayam
    {
        public Batik(string nama) : base("kapas", nama, "hitam putih", 4, "bulu bercorak", 3000) { }
    }

    //subclass kapas
    internal class Kapas : Ayam, INegaraasal
    {
        public Kapas(string nama) : base("kapas", nama, "putih", 1, "bulu lebat", 8000) { }

        public override void Makan()
        {
            Console.WriteLine($"Ayam {jenis}, si {nama} yang harganya {harga} rupiah itu sedang makan makanan bergizi.");
        }

        public void negarasal()
        {
            Console.WriteLine($"{nama} si ayam {jenis} berasal dari negara Cina");
        }



        //method
        public void AyamDijual()
        {
            Console.WriteLine($"{nama} si ayam {jenis} dengan bulu berwarna {warna} dan {jenisbulu} berumur {umur} tahun dijual dengan harga Rp {harga}");
        }

        public void AyamBermain()
        {
            Console.WriteLine($"{nama} si ayam {jenis} dengan bulu berwarna {warna} dan {jenisbulu} berumur {umur} tahun sangat suka bermain air");
        }
    }
}