namespace abstrak
{
    //abstract
    public abstract class Hewan
    {
        public string nama;
        public string warna;
        public string tujuanpelihara;


        public Hewan(string nama, string warna, string tujuanpelihara)

        {
            this.nama = nama;
            this.warna = warna;
            this.tujuanpelihara = tujuanpelihara;
        }

        //metode yang digunakan pada abstract class
        public abstract void Pelihara();

        public virtual void Belihewan()
        {
            Console.WriteLine($"{nama} dengan warna {warna} dibeli untuk {tujuanpelihara}");
        }


    }

    // interface negara asal ayam
    interface INegaraasal
    {
        public void negarasal();
    }
}
