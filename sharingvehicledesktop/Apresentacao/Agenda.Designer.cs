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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCodigoMotorista = new System.Windows.Forms.TextBox();
            this.txtCodigoVeiculo = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.btnSalvarAgenda = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agenda";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 39);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(421, 287);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(452, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(452, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codigo do Motorista:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(455, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Codigo do veiculo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(452, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(634, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Horario";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(457, 95);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(282, 20);
            this.txtID.TabIndex = 9;
            // 
            // txtCodigoMotorista
            // 
            this.txtCodigoMotorista.Location = new System.Drawing.Point(457, 176);
            this.txtCodigoMotorista.Name = "txtCodigoMotorista";
            this.txtCodigoMotorista.Size = new System.Drawing.Size(282, 20);
            this.txtCodigoMotorista.TabIndex = 10;
            // 
            // txtCodigoVeiculo
            // 
            this.txtCodigoVeiculo.Location = new System.Drawing.Point(457, 241);
            this.txtCodigoVeiculo.Name = "txtCodigoVeiculo";
            this.txtCodigoVeiculo.Size = new System.Drawing.Size(282, 20);
            this.txtCodigoVeiculo.TabIndex = 11;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(457, 319);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 20);
            this.txtDia.TabIndex = 12;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(639, 319);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 13;
            // 
            // btnSalvarAgenda
            // 
            this.btnSalvarAgenda.Location = new System.Drawing.Point(581, 379);
            this.btnSalvarAgenda.Name = "btnSalvarAgenda";
            this.btnSalvarAgenda.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarAgenda.TabIndex = 14;
            this.btnSalvarAgenda.Text = "Salvar";
            this.btnSalvarAgenda.UseVisualStyleBackColor = true;
            this.btnSalvarAgenda.Click += new System.EventHandler(this.btnSalvarAgenda_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(664, 379);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 15;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(775, 414);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnSalvarAgenda);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtCodigoVeiculo);
            this.Controls.Add(this.txtCodigoMotorista);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agenda";
            this.Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCodigoMotorista;
        private System.Windows.Forms.TextBox txtCodigoVeiculo;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Button btnSalvarAgenda;
        private System.Windows.Forms.Button BtnCancelar;
    }
}