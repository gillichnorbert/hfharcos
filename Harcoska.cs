using System;
namespace Harcosos
{
	public class Harcos
	{
        private string nev;
        private int eletEro;
		private int harciEro;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public int Eletero
        {
            get { return eletEro; }
            set { eletEro = value; }
        }

        public int HarciEro
        {
            get { return harciEro; }
            set { harciEro = value; }
        }

        public Harcos(string nev, int harciEro, int eletEro)
		{
            this.nev = nev;
            this.eletEro = eletEro;
            this.harciEro = harciEro;
        }
        public bool Harcol(Harcos masikHarcos)
        {
            masikHarcos.eletEro -= this.harciEro;
            this.eletEro -= masikHarcos.HarciEro;

            if (this.eletEro <= 0 || masikHarcos.eletEro <= 0)
                return true;
            else
                return false;
        }

        public override string? ToString()
        {
            return $"Név: {nev}, Életerő: {eletEro}, Harci erő: {harciEro}";
        }




    }

}

