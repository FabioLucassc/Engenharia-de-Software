using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipacao
{
    public partial class Form_agendamentos : MetroFramework.Forms.MetroForm
    {
        public Form_agendamentos()
        {
            InitializeComponent();
        }



        private void Form_consultorios_Load(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Form_Inicial inicio = new Form_Inicial();
            inicio.Show();
            Hide();

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            Form_Inicial inicio = new Form_Inicial();
            inicio.Show();
            Hide();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
