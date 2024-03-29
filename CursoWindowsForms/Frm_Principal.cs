﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_DemonstracaoKey_Click(object sender, EventArgs e)
        {
            Frm_DemonstracaoKey f = new Frm_DemonstracaoKey();
            f.ShowDialog();
        }

        private void Btn_ValidaCPF_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF f4 = new Frm_ValidaCPF();
            f4.ShowDialog();
        }

        private void Btn_ValidaCPF2_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 f5 = new Frm_ValidaCPF2();
            f5.ShowDialog();
        }

        private void Btn_ValidaSenha_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha f6 = new Frm_ValidaSenha();
            f6.ShowDialog();
        }

        private void Btn_HelloWorld_Click(object sender, EventArgs e)
        {
            frm_HelloWorld f2 = new frm_HelloWorld();
            f2.ShowDialog();
        }

        private void Btn_Mascara_Click(object sender, EventArgs e)
        {
            Frm_Mascara f3 = new Frm_Mascara();
            f3.ShowDialog();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
