using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using PAW_Proiect;
using PAW_Proiect.clase;

// ReSharper disable ClassNeverInstantiated.Global

namespace PAW_Proiect.clase
{
    public enum Finantare
    {
        TAXA,
        BUGET,
        BURSA
    }

    public class Student : Persoana, ICloneable, IComparable
    {
        private List<Materie> materiiList;
        private int crediteTotale;
        private float medieGenerala;
        private Finantare finantare;

        public Student() : base()
        {
            materiiList = null;
            crediteTotale = 0;
            medieGenerala = 0;
            finantare = Finantare.TAXA;
        }

        public Student(int cod, string nume, int varsta, string sex, int an,
            List<Materie> materiiList) : base(cod, nume, varsta, sex, an)
        {
            this.materiiList = materiiList;
        }

        #region interfete

        public float calculMedieGenerala()
        {
            return (float) this;
        }

        public Finantare calculFinantare()
        {
            if (medieGenerala >= 9)
                finantare = Finantare.BURSA;
            else if (medieGenerala >= 6)
                finantare = Finantare.BUGET;
            else finantare = Finantare.TAXA;
            return finantare;
        }

        public int calculCredite()
        {
            if (materiiList != null)
            {
                int suma = 0;
                foreach (Materie materie in materiiList)
                    suma += materie.Credite;
                return suma;
            }

            return 0;
        }

        public object Clone()
        {
            var clona = (Student) MemberwiseClone();
            return clona;
        }

        public int CompareTo(object obj)
        {
            Student s = (Student) obj;
            if ((float) this < (float) s)
                return -1;
            if ((float) this > (float) s)
                return 1;
            return string.Compare(Nume, s.Nume);
        }

        #endregion

        #region operatori

        //cast la float  
        public static explicit operator float(Student s)
        {
            if (s.materiiList != null)
            {
                float suma = 0;
                foreach (Materie materie in s.materiiList)
                    suma += materie.Nota;
                return suma / s.materiiList.Count;
            }

            return 0;
        }

        //todo an nastere, poate o sa pot sa fac un autocomplete ceva la formuri

        public static Student operator +(Student s, Materie materie)
        {
            s.materiiList.Add(materie);
            return s;
        }

        #endregion

        #region acces si toString

        public List<Materie> MateriiList
        {
            get => materiiList;
            set
            {
                if (value != null) materiiList = value;
            }
        }

        public int CrediteTotale => crediteTotale = calculCredite();
        public float Medie => medieGenerala = calculMedieGenerala();
        public Finantare Finantare => finantare = calculFinantare();

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

        public override string ToString()
        {
            string final = "Cod: " + Cod + " | Nume: " + this.Nume + " | Varsta: " + this.Varsta + " |  Sex: " +
                           this.Sex + " |  An de Studiu: " + this.An + Environment.NewLine;
            final += "Materii: " + Environment.NewLine;
            foreach (Materie materie in materiiList)
                final += materie.ToString() + Environment.NewLine;
            final += "Medie: " + Medie + " | Nr. Total de Credite: " + CrediteTotale + " | Finantare: " + Finantare;
            return final;
        }

        #endregion
    }
}