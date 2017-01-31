namespace sharingvehicledesktop.Apresentacao
{
    partial class PesquisasNoMapa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.txtRegiaoDaPesquisa = new System.Windows.Forms.TextBox();
            this.btnCarregaPesquisa = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.PainelNotificacao = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(1, 1);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1042, 47);
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "O que deseja pesquisar? ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Região a ser pesquisada: ";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(159, 15);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(231, 20);
            this.txtPesquisa.TabIndex = 3;
            // 
            // txtRegiaoDaPesquisa
            // 
            this.txtRegiaoDaPesquisa.Location = new System.Drawing.Point(563, 15);
            this.txtRegiaoDaPesquisa.Name = "txtRegiaoDaPesquisa";
            this.txtRegiaoDaPesquisa.Size = new System.Drawing.Size(243, 20);
            this.txtRegiaoDaPesquisa.TabIndex = 4;
            // 
            // btnCarregaPesquisa
            // 
            this.btnCarregaPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregaPesquisa.BackColor = System.Drawing.SystemColors.Control;
            this.btnCarregaPesquisa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCarregaPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregaPesquisa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCarregaPesquisa.Location = new System.Drawing.Point(886, 15);
            this.btnCarregaPesquisa.Name = "btnCarregaPesquisa";
            this.btnCarregaPesquisa.Size = new System.Drawing.Size(138, 23);
            this.btnCarregaPesquisa.TabIndex = 5;
            this.btnCarregaPesquisa.Text = "Carregar Pesquisa ";
            this.btnCarregaPesquisa.UseVisualStyleBackColor = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(1, 50);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(840, 396);
            this.webBrowser1.TabIndex = 6;
            // 
            // PainelNotificacao
            // 
            this.PainelNotificacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PainelNotificacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PainelNotificacao.ForeColor = System.Drawing.SystemColors.Control;
            this.PainelNotificacao.Location = new System.Drawing.Point(847, 54);
            this.PainelNotificacao.Name = "PainelNotificacao";
            this.PainelNotificacao.Size = new System.Drawing.Size(183, 381);
            this.PainelNotificacao.TabIndex = 7;
            // 
            // PesquisasNoMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 447);
            this.Controls.Add(this.PainelNotificacao);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnCarregaPesquisa);
            this.Controls.Add(this.txtRegiaoDaPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Name = "PesquisasNoMapa";
            this.Text = "Pesquise no Mapa: ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.TextBox txtRegiaoDaPesquisa;
        private System.Windows.Forms.Button btnCarregaPesquisa;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel PainelNotificacao;
    }
}