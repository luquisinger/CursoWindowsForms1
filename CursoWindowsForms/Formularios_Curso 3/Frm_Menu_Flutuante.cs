using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CursoWindowsForms
{
    public partial class Frm_Menu_Flutuante : Form
    {
        public Frm_Menu_Flutuante()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Flutuante_MouseDown(object sender, MouseEventArgs e)
        {
           

            if(e.Button == System.Windows.Forms.MouseButtons.Right)
            { 
                                
                //MessageBox.Show("Botao da direita em "+"x "+x+" y "+y);


                var ContextMenu = new ContextMenuStrip();
                var vToolTip001 =  DesenhaItemMenu("1", "key");               
                ContextMenu.Items.Add(vToolTip001);
                var vToolTip002 = DesenhaItemMenu("2", "Frm_Mascara");
                ContextMenu.Items.Add(vToolTip002);

                ContextMenu.Show(this, new Point(e.X,e.Y));
                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);

            }
            void vToolTip002_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("002");
            }
            void vToolTip001_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("001");
            }

            ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
            {               
                var vToolTip = new ToolStripMenuItem();
                vToolTip.Text = text;


                System.Drawing.Image MyImage = (System.Drawing.Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
                vToolTip.Image = MyImage;
                return vToolTip;

            }
        }
    }
}
