using System;
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
    public partial class frm_HelloWorld : Form
    {
        public frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void lbl_Titulo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_ModificaLabel_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = Txt_ConteudoLabel.Text;
        }

        private void frm_HelloWorld_Load(object sender, EventArgs e)
        {

        }

        private void Txt_ConteudoLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
