using System;
using System.Collections.Generic;

namespace PAW_Proiect.clase
{
    public class AnUniversitar : ICloneable
    {
        private int an;
        private List<Materie> materiiList;
        private int crediteTotale;
        private float mediaAnuala;

        public AnUniversitar()
        {
            this.an = 0;
            this.materiiList = new List<Materie>();
            this.crediteTotale = 0;
            this.mediaAnuala = 0;
        }

        public AnUniversitar(int an, List<Materie> materiiList)
        {
            this.an = an;
            this.materiiList = materiiList;
            int medie = 0;
            foreach (Materie m in this.materiiList)
            {
                this.crediteTotale += m.Credite;
                medie += m.Nota;
                this.mediaAnuala = (float) medie / materiiList.Count;
            }
        }

        #region operatori
        
        public static AnUniversitar operator +(AnUniversitar an, Materie m)
        {
            an.materiiList.Add(m);
            return an;
        }

        public Materie this[int index]
        {
            get
            {
                if (materiiList != null && index >= 0 && index < materiiList.Count)
                    return materiiList[index];
                return null;
            }
            set
            {
                if (materiiList != null && index > 0 && index <= materiiList.Count)
                    materiiList[index] = value;
            }
        }

        #endregion

        #region interfete

        public object Clone()
        {
            AnUniversitar clona = (AnUniversitar) MemberwiseClone();
            List<Materie> listaNoua = new List<Materie>();

            foreach (Materie m in materiiList)
                listaNoua.Add((Materie) m.Clone());

            clona.materiiList = listaNoua;
            return clona;
        }

        #endregion

        #region access si toString

        public int An
        {
            get => an;
            set
            {
                if (value >= 1 && value <= 3) an = value;
            }
        }

        public List<Materie> MateriiList
        {
            get => materiiList;
            set
            {
                if (value != null) this.materiiList = value;
            }
        }

        public int calculCrediteTotale()
        {
            var suma = 0;
            foreach (Materie m in this.materiiList)
                suma += m.Credite;
            return suma;
        }

        public int CrediteTotale => crediteTotale = calculCrediteTotale();

        public float calculMedieAnuala()
        {
            int suma = 0;
            foreach (Materie m in this.materiiList)
                suma += m.Nota;
            return (float) suma / materiiList.Count;
        }

        public float MediaGenerala => mediaAnuala = calculMedieAnuala();

        public override string ToString()
        {
            string rezultat = "An: " + this.An + "\nMaterii: " + Environment.NewLine;
            foreach (Materie m in materiiList)
                rezultat += m.ToString() + Environment.NewLine;
            rezultat += "Credite Totale: " + this.CrediteTotale + " | Media Anuala: " + MediaAnuala;
            return Environment.NewLine + rezultat;
        }

        #endregion
    }
}