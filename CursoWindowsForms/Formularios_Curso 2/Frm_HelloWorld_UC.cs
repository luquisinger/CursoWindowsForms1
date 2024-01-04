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
    public partial class Frm_HelloWorld_UC : UserControl
    {
        public Frm_HelloWorld_UC()
        {
            InitializeComponent();
        }

        private void lbl_Titulo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ModificaLabel_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = Txt_ConteudoLabel.Text;
        }

        private void Txt_ConteudoLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Titulo_Click_1(object sender, EventArgs e)
        {

        }
    }
}
