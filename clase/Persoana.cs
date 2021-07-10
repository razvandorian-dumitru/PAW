namespace PAW_Proiect.clase
{
    public abstract class Persoana
    {
        private int cod;
        private string nume;
        private int varsta;
        private string sex;
        private int an;

        public Persoana()
        {
            cod = 0;
            nume = "Anonim";
            varsta = 0;
            sex = "M";
            an = 0;
        }

        public Persoana(int cod, string nume, int varsta, string sex, int an)
        {
            if (cod >= 0)
                this.cod = cod;
            this.nume = nume;
            if (varsta >= 18)
                this.varsta = varsta;
            if (sex != null)
                this.sex = sex;
            if (an >= 1)
                this.an = an;
        }

        public int Cod
        {
            get { return this.cod; }
            set
            {
                if (value > 0)
                    cod = value;
            }
        }

        public string Nume
        {
            get { return this.nume; }
            set
            {
                if (value != null)
                    nume = value;
            }
        }

        public int Varsta
        {
            get { return this.varsta; }
            set
            {
                if (value >= 18)
                    varsta = value;
            }
        }

        public string Sex
        {
            get => sex;
            set => sex = value;
        }

        public int An
        {
            get => an;
            set => an = value;
        }

        public override string ToString()
        {
            return "Cod: " + cod + " | Nume: " + nume + " | Varsta: " + varsta;
        }
    }
}