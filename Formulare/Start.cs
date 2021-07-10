using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PAW_Proiect.clase;

namespace PAW_Proiect.Formulare
{
    public partial class Start : Form
    {
        private List<Student> studentList = new List<Student>();

        public Start()
        {
            InitializeComponent();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }

        private void listaStudentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentiForm studentiForm = new StudentiForm(studentList);
            studentiForm.Show();
        }

        private void Start_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.A)
            {
                optiuniToolStripMenuItem.PerformClick();
                addStudentToolStripMenuItem.PerformClick();
            }
        }
    }
}