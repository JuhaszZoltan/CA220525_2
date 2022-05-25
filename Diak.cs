namespace CA220525_2
{
    internal class Diak
    {
        public string VezetekNev;
        public string KeresztNev;
        public int Magassag;
        public float Suly;
        public string Nem;

        public Diak(string sor)
        {
            string[] darabok = sor.Split(' ');

            this.VezetekNev = darabok[0];
            this.KeresztNev = darabok[1];
            this.Magassag = int.Parse(darabok[2]);
            this.Suly = float.Parse(darabok[3]);
            this.Nem = darabok[4];
        }
    }
}
