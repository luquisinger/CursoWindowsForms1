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
    public partial class Frm_Principal_Menu_UC : Form
    {
        int ControleHelloWorld = 0;
        int ControleDemonstracaoKey = 0;
        int ControleMascara = 0;
        int ControleValidaCPF;
        int ControleValidaCPF2;
        int ControleValidaSenha;
        int ControleArquivoImagem;
        int ControleCadastroClientes =0;
        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();

            novoToolStripMenuItem.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
            cadastrosToolStripMenuItem.Enabled = false;
        }
        private void Frm_Principal_Menu_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF += 1;

            Frm_ValidaCPF_UC U = new Frm_ValidaCPF_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida CPF " + ControleValidaCPF;
            TB.Text = "Valida CPF " + ControleValidaCPF;
            TB.ImageIndex = 3;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void demonstraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDemonstracaoKey += 1;
            Frm_DemonstracaoKey_UC U = new Frm_DemonstracaoKey_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "DemonstracaoKey " + ControleDemonstracaoKey;
            TB.Text = "DemonstracaoKey " + ControleDemonstracaoKey;
            TB.ImageIndex = 0;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWorld += 1;
            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Hello world " + ControleHelloWorld;
            TB.Text = "Hello World " + ControleHelloWorld;
            TB.ImageIndex = 1;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMascara += 1;
            Frm_Mascara_UC U = new Frm_Mascara_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Mascara " + ControleMascara;
            TB.Text = "Mascara " + ControleMascara;
            TB.ImageIndex = 2;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF2 += 1;
            Frm_ValidaCPF2_UC U = new Frm_ValidaCPF2_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "ValidaCPF2 " + ControleValidaCPF2;
            TB.Text = "ValidaCPF2 " + ControleValidaCPF2;
            TB.ImageIndex = 4;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void válidaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ControleValidaSenha += 1;
            Frm_ValidaSenha_UC U = new Frm_ValidaSenha_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "ValidaSenha " + ControleValidaSenha;
            TB.Text = "ValidaSenha " + ControleValidaSenha;
            TB.ImageIndex = 5;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaAba(Tbc_Aplicacoes.SelectedTab);
            }
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Db = new OpenFileDialog();
            Db.InitialDirectory = "C:\\Users\\mathe\\OneDrive\\Documentos\\PROJETOS\\ALURA\\C#\\CursoWindowsForms\\CursoWindowsForms\\Imagens";
            Db.Filter = "PNG|*.PNG";
            Db.Title = "Escolha a imagem";

            if (Db.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivoImagem = Db.FileName;


                ControleArquivoImagem += 1;
                Frm_ArquivoImagem_UC U = new Frm_ArquivoImagem_UC(nomeArquivoImagem);
                U.Dock = DockStyle.Fill;
                TabPage TB = new TabPage();
                TB.Name = "Abrir Imagem " + ControleArquivoImagem;
                TB.Text = "Abrir Imagem " + ControleArquivoImagem;
                TB.ImageIndex = 6;
                TB.Controls.Add(U);
                Tbc_Aplicacoes.TabPages.Add(TB);
            }


        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login F = new Frm_Login();
            F.ShowDialog();

            if (F.DialogResult == DialogResult.OK)
            {
                string senha = F.senha;
                string usuario = F.usuario;

                if (CursoWindowsFormsBiblioteca.Cls_Uteis.validaSenhaLogin(senha) == true)
                {
                    novoToolStripMenuItem.Enabled = true;
                    apagarAbaToolStripMenuItem.Enabled = true;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    conectarToolStripMenuItem.Enabled = false;
                    desconectarToolStripMenuItem.Enabled = true;
                    cadastrosToolStripMenuItem.Enabled = true;

                    MessageBox.Show("Bem vindo " + usuario + " !", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Senha Inválida" + " !", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frm_Questao Db = new Frm_Questao("icons8_ponto_de_interrogação_481", "Você deseja se desconectar?");
            Db.ShowDialog();

            if (Db.DialogResult == DialogResult.Yes)
            {

                for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i <= 0; i--)
                {
                    ApagaAba(Tbc_Aplicacoes.TabPages[i]);

                }

                novoToolStripMenuItem.Enabled = false;
                apagarAbaToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
                desconectarToolStripMenuItem.Enabled = false;
                cadastrosToolStripMenuItem.Enabled = false;
            }


        }

        private void Tbc_Aplicacoes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {

                //MessageBox.Show("Botao da direita em "+"x "+x+" y "+y);


                var ContextMenu = new ContextMenuStrip();
                var vToolTip001 = DesenhaItemMenu("Apagar a Aba", "DeleteTab");
                ContextMenu.Items.Add(vToolTip001);
                var vToolTip002 = DesenhaItemMenu("Apagar todas a esquerda", "DeleteLeft");
                ContextMenu.Items.Add(vToolTip002);
                var vToolTip003 = DesenhaItemMenu("Apagar todas a direita", "DeleteRight");
                ContextMenu.Items.Add(vToolTip003);
                var vToolTip004 = DesenhaItemMenu("Apagar todas menos esta", "DeleteAll");
                ContextMenu.Items.Add(vToolTip004);

                ContextMenu.Show(this, new Point(e.X, e.Y));
                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
                vToolTip003.Click += new System.EventHandler(vToolTip003_Click);
                vToolTip004.Click += new System.EventHandler(vToolTip004_Click);

            }
        }
        void vToolTip001_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }
        }
        void vToolTip002_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagarEsquerda(Tbc_Aplicacoes.SelectedIndex);
            }
        }
        void vToolTip003_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagarDireita(Tbc_Aplicacoes.SelectedIndex);
            }
        }
        void vToolTip004_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagarTudo(Tbc_Aplicacoes.SelectedIndex);
            }
        }
        void ApagarEsquerda(int ItemSelecionado)
        {
            for (int i = ItemSelecionado - 1; i >= 0; i--)
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
            }

        }
        void ApagarDireita(int ItemSelecionado)
        {
            for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i > ItemSelecionado; i--)
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
            }
        }
        void ApagarTudo(int ItemSelecionado)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagarDireita(Tbc_Aplicacoes.SelectedIndex);
                ApagarEsquerda(Tbc_Aplicacoes.SelectedIndex);
            }
        }
    

        ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = text;


            System.Drawing.Image MyImage = (System.Drawing.Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            vToolTip.Image = MyImage;
            return vToolTip;

        }

        private void clietesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ControleCadastroClientes ==0)
            {
            ControleCadastroClientes += 1;

            Frm_CadastroCliente_UC U = new Frm_CadastroCliente_UC();
            U.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Cadastro de Clientes";
            TB.Text = "Cadastro de Clientes";
            TB.ImageIndex = 7;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);

            } else
            {
                MessageBox.Show("Cadastro já está aberto", "Banco ByteBank" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void ApagaAba(TabPage Tb)
        {
            if(Tb.Name == "Cadastro de Clientes")
            {
                ControleCadastroClientes = 0;
            }
            Tbc_Aplicacoes.TabPages.Remove(Tb);
        }

		private void agenciaToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Frm_Agencia FForm = new Frm_Agencia();
            FForm.ShowDialog();
		}
	}   
}