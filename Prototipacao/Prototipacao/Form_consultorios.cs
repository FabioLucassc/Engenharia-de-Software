﻿using System;
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
    public partial class Form_consultorios : MetroFramework.Forms.MetroForm
    {
        public Form_consultorios()
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form_Centro centro = new Form_Centro();
            centro.Show();
            Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form_esperanca esperanca = new Form_esperanca();
            esperanca.Show();
            Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Form_nova nova = new Form_nova();
            nova.Show();
            Hide();
        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            Form_Inicial inicio = new Form_Inicial();
            inicio.Show();
            Hide();
        }
    }
}
