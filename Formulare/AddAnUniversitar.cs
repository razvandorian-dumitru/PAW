using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PAW_Proiect.clase;

namespace PAW_Proiect.Formulare
{
    public partial class AddAnUniversitar : Form
    {
        private List<Materie> materiiList2;

        public AddAnUniversitar(List<Materie> materiiList)
        {
            InitializeComponent();
            materiiList2 = materiiList;
        }


        private void btAddAn_Click(object sender, EventArgs e)
        {
            if (cbAn.Text == "")
                errAn.SetError(cbAn, "Introduceti anul inscrierii!");
            else
            {
                int an = Convert.ToInt32(cbAn.Text);
            }
        }
    }
}