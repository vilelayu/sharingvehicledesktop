namespace sharingvehicledesktop.Apresentacao
{
    partial class Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbDataHora = new System.Windows.Forms.MaskedTextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtCodveiculo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btSolicitar = new System.Windows.Forms.Button();
            this.Btcancela = new System.Windows.Forms.Button();
            this.mtbDataHoraSaida = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcogmotorista = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Solicitar carro:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 39);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(0, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 30);
            this.panel1.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(573, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Sharing Vehicle | ImagineCup";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-4, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 43);
            this.panel2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Veículo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Data/Hora de saida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Observação:";
            // 
            // mtbDataHora
            // 
            this.mtbDataHora.Location = new System.Drawing.Point(174, 302);
            this.mtbDataHora.Mask = "00/00/0000 90:00";
            this.mtbDataHora.Name = "mtbDataHora";
            this.mtbDataHora.Size = new System.Drawing.Size(145, 20);
            this.mtbDataHora.TabIndex = 26;
            this.mtbDataHora.ValidatingType = typeof(System.DateTime);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(122, 342);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(554, 20);
            this.txtObs.TabIndex = 27;
            // 
            // txtCodveiculo
            // 
            this.txtCodveiculo.HideSelection = false;
            this.txtCodveiculo.Location = new System.Drawing.Point(108, 256);
            this.txtCodveiculo.Name = "txtCodveiculo";
            this.txtCodveiculo.Size = new System.Drawing.Size(100, 20);
            this.txtCodveiculo.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 150);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Escolha um veículo:";
            // 
            // btSolicitar
            // 
            this.btSolicitar.BackColor = System.Drawing.Color.White;
            this.btSolicitar.FlatAppearance.BorderSize = 0;
            this.btSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSolicitar.Location = new System.Drawing.Point(508, 389);
            this.btSolicitar.Name = "btSolicitar";
            this.btSolicitar.Size = new System.Drawing.Size(75, 23);
            this.btSolicitar.TabIndex = 31;
            this.btSolicitar.Text = "Solicitar";
            this.btSolicitar.UseVisualStyleBackColor = false;
            this.btSolicitar.Click += new System.EventHandler(this.btSolicitar_Click);
            // 
            // Btcancela
            // 
            this.Btcancela.BackColor = System.Drawing.Color.White;
            this.Btcancela.FlatAppearance.BorderSize = 0;
            this.Btcancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btcancela.Location = new System.Drawing.Point(601, 389);
            this.Btcancela.Name = "Btcancela";
            this.Btcancela.Size = new System.Drawing.Size(75, 23);
            this.Btcancela.TabIndex = 32;
            this.Btcancela.Text = "Cancelar";
            this.Btcancela.UseVisualStyleBackColor = false;
            this.Btcancela.Click += new System.EventHandler(this.Btcancela_Click);
            // 
            // mtbDataHoraSaida
            // 
            this.mtbDataHoraSaida.Location = new System.Drawing.Point(531, 305);
            this.mtbDataHoraSaida.Mask = "00/00/0000 90:00";
            this.mtbDataHoraSaida.Name = "mtbDataHoraSaida";
            this.mtbDataHoraSaida.Size = new System.Drawing.Size(145, 20);
            this.mtbDataHoraSaida.TabIndex = 34;
            this.mtbDataHoraSaida.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(348, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Data/Hora de devolução:";
            // 
            // txtcogmotorista
            // 
            this.txtcogmotorista.HideSelection = false;
            this.txtcogmotorista.Location = new System.Drawing.Point(576, 256);
            this.txtcogmotorista.Name = "txtcogmotorista";
            this.txtcogmotorista.Size = new System.Drawing.Size(100, 20);
            this.txtcogmotorista.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(402, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Código do Motorista:";
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(749, 489);
            this.Controls.Add(this.txtcogmotorista);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtbDataHoraSaida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btcancela);
            this.Controls.Add(this.btSolicitar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCodveiculo);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.mtbDataHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbDataHora;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtCodveiculo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSolicitar;
        private System.Windows.Forms.Button Btcancela;
        private System.Windows.Forms.MaskedTextBox mtbDataHoraSaida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcogmotorista;
        private System.Windows.Forms.Label label7;
    }
}