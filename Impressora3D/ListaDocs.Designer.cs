namespace Impressora3D
{
    partial class ListaDocs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPastaInicial = new System.Windows.Forms.TextBox();
            this.cboPadraoArquivos = new System.Windows.Forms.ComboBox();
            this.lblArquivos = new System.Windows.Forms.ListBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDirectorioInicial = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arquivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Padrão de Arquivos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Arquivos da Pasta";
            // 
            // txtPastaInicial
            // 
            this.txtPastaInicial.Location = new System.Drawing.Point(124, 46);
            this.txtPastaInicial.Name = "txtPastaInicial";
            this.txtPastaInicial.Size = new System.Drawing.Size(401, 20);
            this.txtPastaInicial.TabIndex = 3;
            // 
            // cboPadraoArquivos
            // 
            this.cboPadraoArquivos.FormattingEnabled = true;
            this.cboPadraoArquivos.Items.AddRange(new object[] {
            "HTML (*.htm;*.html)",
            "JPEG (*.jpg)",
            "PNG(*.png)",
            "JP2(*.pj2)"});
            this.cboPadraoArquivos.Location = new System.Drawing.Point(124, 87);
            this.cboPadraoArquivos.Name = "cboPadraoArquivos";
            this.cboPadraoArquivos.Size = new System.Drawing.Size(401, 21);
            this.cboPadraoArquivos.TabIndex = 4;
            // 
            // lblArquivos
            // 
            this.lblArquivos.FormattingEnabled = true;
            this.lblArquivos.Location = new System.Drawing.Point(12, 134);
            this.lblArquivos.Name = "lblArquivos";
            this.lblArquivos.Size = new System.Drawing.Size(587, 173);
            this.lblArquivos.TabIndex = 6;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(12, 341);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(136, 41);
            this.btnLocalizar.TabIndex = 7;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(463, 341);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(136, 41);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDirectorioInicial
            // 
            this.btnDirectorioInicial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDirectorioInicial.Location = new System.Drawing.Point(531, 45);
            this.btnDirectorioInicial.Name = "btnDirectorioInicial";
            this.btnDirectorioInicial.Size = new System.Drawing.Size(68, 21);
            this.btnDirectorioInicial.TabIndex = 5;
            this.btnDirectorioInicial.Text = "Procurar";
            this.btnDirectorioInicial.UseVisualStyleBackColor = true;
            this.btnDirectorioInicial.Click += new System.EventHandler(this.btnDirectorioInicial_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Projetos do Banco";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "3D HUB";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ListaDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 390);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.lblArquivos);
            this.Controls.Add(this.btnDirectorioInicial);
            this.Controls.Add(this.cboPadraoArquivos);
            this.Controls.Add(this.txtPastaInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListaDocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressora 3D";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPastaInicial;
        private System.Windows.Forms.ComboBox cboPadraoArquivos;
        private System.Windows.Forms.Button btnDirectorioInicial;
        private System.Windows.Forms.ListBox lblArquivos;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

