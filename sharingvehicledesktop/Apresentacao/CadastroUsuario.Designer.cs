namespace sharingvehicledesktop.Apresentacao
{
    partial class CadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            this.btConfirma = new System.Windows.Forms.Button();
            this.lblCadastroUsuario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btVoltar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtRepeteSenha = new System.Windows.Forms.TextBox();
            this.BtnCancelaCadastroUsu = new System.Windows.Forms.Button();
            this.CbVisualizaSenha = new System.Windows.Forms.CheckBox();
            this.btnRedefinirSenha = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConfirma
            // 
            this.btConfirma.BackColor = System.Drawing.Color.White;
            this.btConfirma.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btConfirma.FlatAppearance.BorderSize = 0;
            this.btConfirma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btConfirma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirma.Location = new System.Drawing.Point(215, 273);
            this.btConfirma.Name = "btConfirma";
            this.btConfirma.Size = new System.Drawing.Size(75, 23);
            this.btConfirma.TabIndex = 0;
            this.btConfirma.Text = "Confirmar";
            this.btConfirma.UseVisualStyleBackColor = false;
            this.btConfirma.Click += new System.EventHandler(this.btConfirma_Click);
            // 
            // lblCadastroUsuario
            // 
            this.lblCadastroUsuario.AutoSize = true;
            this.lblCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblCadastroUsuario.Location = new System.Drawing.Point(44, 0);
            this.lblCadastroUsuario.Name = "lblCadastroUsuario";
            this.lblCadastroUsuario.Size = new System.Drawing.Size(286, 31);
            this.lblCadastroUsuario.TabIndex = 1;
            this.lblCadastroUsuario.Text = "Cadastro de usuario:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(16, 50);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(79, 25);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(19, 85);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(272, 20);
            this.txtNome.TabIndex = 4;
            // 
            // btVoltar
            // 
            this.btVoltar.BackgroundImage = global::sharingvehicledesktop.Properties.Resources._8395_32x32;
            this.btVoltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Location = new System.Drawing.Point(5, 2);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(33, 32);
            this.btVoltar.TabIndex = 6;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(19, 148);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(272, 20);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Repita a senha:";
            // 
            // TxtRepeteSenha
            // 
            this.TxtRepeteSenha.Location = new System.Drawing.Point(19, 210);
            this.TxtRepeteSenha.Name = "TxtRepeteSenha";
            this.TxtRepeteSenha.Size = new System.Drawing.Size(272, 20);
            this.TxtRepeteSenha.TabIndex = 8;
            this.TxtRepeteSenha.UseSystemPasswordChar = true;
            // 
            // BtnCancelaCadastroUsu
            // 
            this.BtnCancelaCadastroUsu.BackColor = System.Drawing.Color.White;
            this.BtnCancelaCadastroUsu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCancelaCadastroUsu.FlatAppearance.BorderSize = 0;
            this.BtnCancelaCadastroUsu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCancelaCadastroUsu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnCancelaCadastroUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelaCadastroUsu.Location = new System.Drawing.Point(134, 273);
            this.BtnCancelaCadastroUsu.Name = "BtnCancelaCadastroUsu";
            this.BtnCancelaCadastroUsu.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelaCadastroUsu.TabIndex = 9;
            this.BtnCancelaCadastroUsu.Text = "Cancelar";
            this.BtnCancelaCadastroUsu.UseVisualStyleBackColor = false;
            this.BtnCancelaCadastroUsu.Click += new System.EventHandler(this.BtnCancelaCadastroUsu_Click);
            // 
            // CbVisualizaSenha
            // 
            this.CbVisualizaSenha.AutoSize = true;
            this.CbVisualizaSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbVisualizaSenha.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbVisualizaSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CbVisualizaSenha.Location = new System.Drawing.Point(19, 237);
            this.CbVisualizaSenha.Name = "CbVisualizaSenha";
            this.CbVisualizaSenha.Size = new System.Drawing.Size(112, 20);
            this.CbVisualizaSenha.TabIndex = 10;
            this.CbVisualizaSenha.Text = "Visualizar senhas. ";
            this.CbVisualizaSenha.UseVisualStyleBackColor = true;
            this.CbVisualizaSenha.CheckedChanged += new System.EventHandler(this.VerificaSenha);
            // 
            // btnRedefinirSenha
            // 
            this.btnRedefinirSenha.BackColor = System.Drawing.Color.White;
            this.btnRedefinirSenha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRedefinirSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedefinirSenha.Location = new System.Drawing.Point(53, 273);
            this.btnRedefinirSenha.Name = "btnRedefinirSenha";
            this.btnRedefinirSenha.Size = new System.Drawing.Size(75, 23);
            this.btnRedefinirSenha.TabIndex = 11;
            this.btnRedefinirSenha.Text = "Redefinir";
            this.btnRedefinirSenha.UseVisualStyleBackColor = false;
            this.btnRedefinirSenha.Visible = false;
            this.btnRedefinirSenha.Click += new System.EventHandler(this.btnRedefinirSenha_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btVoltar);
            this.panel1.Controls.Add(this.lblCadastroUsuario);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 39);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(-4, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 30);
            this.panel2.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(169, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sharing Vehicle | ImagineCup";
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(334, 336);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRedefinirSenha);
            this.Controls.Add(this.CbVisualizaSenha);
            this.Controls.Add(this.BtnCancelaCadastroUsu);
            this.Controls.Add(this.TxtRepeteSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btConfirma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroUsuario";
            this.Text = "CadastroUsuario";
            this.Load += new System.EventHandler(this.CadastroUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConfirma;
        private System.Windows.Forms.Label lblCadastroUsuario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRepeteSenha;
        private System.Windows.Forms.Button BtnCancelaCadastroUsu;
        private System.Windows.Forms.CheckBox CbVisualizaSenha;
        private System.Windows.Forms.Button btnRedefinirSenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
    }
}