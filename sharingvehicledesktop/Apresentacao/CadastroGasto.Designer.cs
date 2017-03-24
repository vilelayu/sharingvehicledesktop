namespace sharingvehicledesktop.Apresentacao
{
    partial class CadastroGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroGasto));
            this.btVolta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVParcela = new System.Windows.Forms.TextBox();
            this.txtcodCar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNParcelas = new System.Windows.Forms.TextBox();
            this.TxttipoGasto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btVolta
            // 
            this.btVolta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btVolta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVolta.Image = ((System.Drawing.Image)(resources.GetObject("btVolta.Image")));
            this.btVolta.Location = new System.Drawing.Point(12, 12);
            this.btVolta.Name = "btVolta";
            this.btVolta.Size = new System.Drawing.Size(46, 39);
            this.btVolta.TabIndex = 8;
            this.btVolta.UseVisualStyleBackColor = true;
            this.btVolta.Click += new System.EventHandler(this.btVolta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cadastro de Gastos";
            // 
            // txtVParcela
            // 
            this.txtVParcela.Location = new System.Drawing.Point(12, 287);
            this.txtVParcela.Name = "txtVParcela";
            this.txtVParcela.Size = new System.Drawing.Size(282, 20);
            this.txtVParcela.TabIndex = 30;
            // 
            // txtcodCar
            // 
            this.txtcodCar.Location = new System.Drawing.Point(17, 361);
            this.txtcodCar.Name = "txtcodCar";
            this.txtcodCar.Size = new System.Drawing.Size(282, 20);
            this.txtcodCar.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Valor da parcela";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Codigo do carro";
            // 
            // txtNParcelas
            // 
            this.txtNParcelas.Location = new System.Drawing.Point(17, 201);
            this.txtNParcelas.Name = "txtNParcelas";
            this.txtNParcelas.Size = new System.Drawing.Size(282, 20);
            this.txtNParcelas.TabIndex = 26;
            // 
            // TxttipoGasto
            // 
            this.TxttipoGasto.Location = new System.Drawing.Point(17, 124);
            this.TxttipoGasto.Name = "TxttipoGasto";
            this.TxttipoGasto.Size = new System.Drawing.Size(282, 20);
            this.TxttipoGasto.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Numero de parcelas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tipo de gasto:";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(224, 405);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 31;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.Location = new System.Drawing.Point(143, 405);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(75, 23);
            this.btcancelar.TabIndex = 32;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // CadastroGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(318, 441);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtVParcela);
            this.Controls.Add(this.txtcodCar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNParcelas);
            this.Controls.Add(this.TxttipoGasto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btVolta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroGasto";
            this.Text = "CadastroGasto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVolta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVParcela;
        private System.Windows.Forms.TextBox txtcodCar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNParcelas;
        private System.Windows.Forms.TextBox TxttipoGasto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btcancelar;
    }
}