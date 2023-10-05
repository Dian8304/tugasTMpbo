using abstrak;

namespace Animal
{
    class Ayam
    {
        private string jenis;
        private string nama;
        private string warna;
        private string umur;
        private string jenisbulu;
        private string harga;

        public string Jenis
        {
            get { return jenis; }
            set { jenis = value; }
        }
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }
        public string Warna
        {
            get { return warna; }
            set { warna = value; }
        }
        public string Umur
        {
            get { return umur; }
            set { umur = value; }
        }
        public string Jenisbulu
        {
            get { return jenisbulu; }
            set { jenisbulu = value; }
        }
        public string Harga
        {
            get { return harga; }
            set { harga = value; }
        }

        public Ayam(string jenis, string nama, string warna, string umur, string jenisbulu, string harga)
        {
            Jenis = jenis;
            Nama = nama;
            Warna = warna;
            Umur = umur;
            Jenisbulu = jenisbulu;
            Harga = harga;
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
            Console.WriteLine($"{nama} si Ayam {jenis} berwarna {warna} suka makan.");
        }

        public virtual void Bersuara()
        {
            Console.WriteLine($"{nama} si Ayam {jenis} berwarna {warna} pernah berkata: ");
        }
    }


    //subclass cemani
    internal class Cemani : Ayam
    {
        public Cemani(string nama) : base("cemani", nama, "hitam", "2", "bulu hitam", "10000") { }

        public override void Bersuara()
        {
            Console.WriteLine($"Ayam {Jenis} kecil, si {Nama} bersuara Ciap Ciap Ciap");
        }
    }

    internal class Batik : Ayam
    {
        public Batik(string nama) : base("batik", nama, "hitam putih", "4", "bulu bercorak", "3000") { }

        //method
        public void AyamDijual()
        {
            Console.WriteLine($"{Nama} si ayam {Jenis} dengan bulu berwarna {Warna}, {Jenisbulu}, berumur {Umur} tahun dijual dengan harga Rp {Harga}");
        }

        public void AyamBermain()
        {
            Console.WriteLine($"{Nama} si ayam {Jenis} dengan bulu berwarna {Warna} berumur {Umur} tahun sangat suka bermain air");
        }
    }

    //subclass kapas
    internal class Kapas : Ayam, INegaraasal
    {
        public Kapas(string nama) : base("kapas", nama, "putih", "1", "bulu lebat", "8000") { }

        public override void Makan()
        {
            Console.WriteLine($"{Nama} si ayam {Jenis} sedang makan makanan bergizi sehingga 2 hari ke depan dapat dijual dengan harga {Harga} rupiah.");
        }

        public void negarasal()
        {
            Console.WriteLine($"{Nama} si ayam {Jenis} berasal dari negara Cina");
        }
    }
}