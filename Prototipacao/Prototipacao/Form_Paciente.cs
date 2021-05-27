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
    public partial class Form_Paciente : MetroFramework.Forms.MetroForm
    {
        public Form_Paciente()
        {
            InitializeComponent();
        }



        private void Form_Paciente_Load(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Form_Inicial inicio = new Form_Inicial();
            inicio.Show();
            Hide();

        }

        private void dtVencimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tggPago_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
