using System;
using System.Collections.Generic;


namespace PAW_Proiect.clase
{
    internal class ClasaStudenti : ICloneable
    {
        private string denumire;
        private List<Student> studentList;

        public ClasaStudenti()
        {
            denumire = "Clasa Anonima";
            studentList = new List<Student>();
        }

        public ClasaStudenti(string nume, List<Student> studentList)
        {
            denumire = nume;
            this.studentList = studentList;
        }

        public string Nume
        {
            get => denumire;
            set
            {
                if (value.Length >= 0) denumire = value;
            }
        }

        public List<Student> StudentList
        {
            get => studentList;
            set
            {
                if (value != null) studentList = value;
            }
        }

        public Student this[int index]
        {
            get
            {
                if (studentList != null && index >= 0 && index < studentList.Count)
                    return studentList[index];
                return null;
            }
            set
            {
                if (studentList != null && index > 0 && index <= studentList.Count)
                    studentList[index] = value;
            }
        }

        public object Clone()
        {
            ClasaStudenti clona = (ClasaStudenti) MemberwiseClone();
            List<Student> listaNoua = new List<Student>();

            foreach (Student s in studentList)
                listaNoua.Add((Student) s.Clone());

            clona.studentList = listaNoua;
            return clona;
        }

        public override string ToString()
        {
            string rezultat = "Lista: " + Environment.NewLine;
            foreach (var s in studentList)
                rezultat += s + Environment.NewLine;

            return Environment.NewLine + rezultat;
        }
    }
}