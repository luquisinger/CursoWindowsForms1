namespace CursoWindowsForms
{
    partial class frm_HelloWorld
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_sair = new System.Windows.Forms.Button();
            this.Btn_ModificaLabel = new System.Windows.Forms.Button();
            this.Txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(113, 19);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "VS .NET version";
            this.lbl_Titulo.Click += new System.EventHandler(this.lbl_Titulo_Click);
            // 
            // Btn_sair
            // 
            this.Btn_sair.Location = new System.Drawing.Point(12, 415);
            this.Btn_sair.Name = "Btn_sair";
            this.Btn_sair.Size = new System.Drawing.Size(75, 23);
            this.Btn_sair.TabIndex = 1;
            this.Btn_sair.Text = "Sair";
            this.Btn_sair.UseVisualStyleBackColor = true;
            this.Btn_sair.Click += new System.EventHandler(this.Btn_sair_Click);
            // 
            // Btn_ModificaLabel
            // 
            this.Btn_ModificaLabel.Location = new System.Drawing.Point(16, 44);
            this.Btn_ModificaLabel.Name = "Btn_ModificaLabel";
            this.Btn_ModificaLabel.Size = new System.Drawing.Size(109, 23);
            this.Btn_ModificaLabel.TabIndex = 2;
            this.Btn_ModificaLabel.Text = "Modifica Label";
            this.Btn_ModificaLabel.UseVisualStyleBackColor = true;
            this.Btn_ModificaLabel.Click += new System.EventHandler(this.Btn_ModificaLabel_Click);
            // 
            // Txt_ConteudoLabel
            // 
            this.Txt_ConteudoLabel.Location = new System.Drawing.Point(16, 73);
            this.Txt_ConteudoLabel.Name = "Txt_ConteudoLabel";
            this.Txt_ConteudoLabel.Size = new System.Drawing.Size(454, 22);
            this.Txt_ConteudoLabel.TabIndex = 3;
            this.Txt_ConteudoLabel.TextChanged += new System.EventHandler(this.Txt_ConteudoLabel_TextChanged);
            // 
            // frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_ConteudoLabel);
            this.Controls.Add(this.Btn_ModificaLabel);
            this.Controls.Add(this.Btn_sair);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "frm_HelloWorld";
            this.Text = "Hello Wolrd";
            this.Load += new System.EventHandler(this.frm_HelloWorld_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button Btn_sair;
        private System.Windows.Forms.Button Btn_ModificaLabel;
        private System.Windows.Forms.TextBox Txt_ConteudoLabel;
    }
}

