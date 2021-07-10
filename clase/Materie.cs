using System;

namespace PAW_Proiect.clase
{
    public enum TipExamen
    {
        VERIFICARE,
        EXAMEN
    };

    public class Materie : ICloneable, IComparable
    {
        private string denumire;
        private int credite;
        private int nota;
        private TipExamen tipExamen;

        public Materie()
        {
            this.denumire = "-";
            this.credite = 0;
            this.nota = 0;
            this.tipExamen = TipExamen.VERIFICARE;
        }

        public Materie(string denumire, int credite, int nota)
        {
            this.denumire = denumire;
            this.credite = credite;
            this.nota = nota;
            if (this.credite >= 4)
                tipExamen = TipExamen.EXAMEN;
            else tipExamen = TipExamen.VERIFICARE;
        }

        #region acces si toString

        public string Denumire
        {
            get => this.denumire;
            set
            {
                if (value.Length >= 0) denumire = value;
            }
        }

        public int Credite
        {
            get => credite;
            set
            {
                if (value >= 0) credite = value;
            }
        }

        public int Nota
        {
            get => nota;
            set
            {
                if (value >= 1) this.nota = value;
            }
        }

        public TipExamen calculTipExamen()
        {
            if (credite >= 4)
                tipExamen = TipExamen.EXAMEN;
            else tipExamen = TipExamen.VERIFICARE;
            return tipExamen;
        }

        public TipExamen TipExamen
        {
            get => calculTipExamen();
        }

        public object Clone()
        {
            Materie clona = (Materie) MemberwiseClone();
            return clona;
        }

        public int CompareTo(object obj)
        {
            Materie m = (Materie) obj;
            if (credite < m.credite)
                return -1;
            if (credite > m.credite)
                return 1;
            return string.Compare(this.denumire, m.denumire);
        }

        public override string ToString()
        {
            return Denumire + " | " + Credite + " | " + Nota + " | " + TipExamen;
        }

        #endregion
    }
}