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
    public partial class Form_Inicial : MetroFramework.Forms.MetroForm
    {
        public Form_Inicial()
        {
            InitializeComponent();
        }
        private void Form_Inicial_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form_consultorios consultorios = new Form_consultorios();
            consultorios.Show();
            Hide();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            Form_consultorios consultorios = new Form_consultorios();
            consultorios.Show();
            Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form_consultorios consultorios = new Form_consultorios();
            consultorios.Show();
            Hide();
        }
    }
}
