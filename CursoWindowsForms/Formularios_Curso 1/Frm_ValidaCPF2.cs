using CursoWindowsFormsBiblioteca;
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
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }
        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            string vConteudo = Msk_CPF.Text;
            vConteudo = vConteudo.Replace(".","").Replace("-", "");
            vConteudo = vConteudo.Trim();
            if(vConteudo == "")
            {
                MessageBox.Show("CPF vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if(vConteudo.Length != 11)
                {
                    MessageBox.Show("CPF deve ter 11 dígitos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Voce deseja realmente validar o cpf?","Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                    {

                        bool validaCPF = false;
                        validaCPF = Cls_Uteis.Valida(Msk_CPF.Text);
                        if (validaCPF)
                        {
                            MessageBox.Show("CPF válido", "Mensagem de Validacao", MessageBoxButtons.OK, MessageBoxIcon.Information );            
                        }
                        else
                        {
                            MessageBox.Show("CPF inválido", "Mensagem de Validacao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }

            }


        }

        private void Btn_Reset_Click_1(object sender, EventArgs e)
        {
            Msk_CPF.Text = string.Empty;
        }

        private void Frm_ValidaCPF2_Load(object sender, EventArgs e)
        {

        }
    }
}
