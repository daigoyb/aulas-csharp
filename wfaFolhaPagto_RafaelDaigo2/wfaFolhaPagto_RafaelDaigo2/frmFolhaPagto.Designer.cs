namespace wfaFolhaPagto_RafaelDaigo2
{
    partial class frmFolhaPagto
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
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblImpostoRenda = new System.Windows.Forms.Label();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNumDep = new System.Windows.Forms.TextBox();
            this.txtvalorhora = new System.Windows.Forms.TextBox();
            this.txthorastrab = new System.Windows.Forms.TextBox();
            this.txtnomefunc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(177, 256);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Imposto de Renda";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(177, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Salário Bruto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(177, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "INSS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Salário Líquido";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(357, 289);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(222, 24);
            this.lblSalarioLiquido.TabIndex = 35;
            // 
            // lblImpostoRenda
            // 
            this.lblImpostoRenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblImpostoRenda.Location = new System.Drawing.Point(357, 255);
            this.lblImpostoRenda.Name = "lblImpostoRenda";
            this.lblImpostoRenda.Size = new System.Drawing.Size(222, 24);
            this.lblImpostoRenda.TabIndex = 34;
            // 
            // lblINSS
            // 
            this.lblINSS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblINSS.Location = new System.Drawing.Point(357, 221);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(222, 24);
            this.lblINSS.TabIndex = 33;
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalarioBruto.Location = new System.Drawing.Point(357, 187);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(222, 24);
            this.lblSalarioBruto.TabIndex = 32;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(430, 133);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(290, 133);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 30;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(143, 133);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 29;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNumDep
            // 
            this.txtNumDep.Location = new System.Drawing.Point(161, 96);
            this.txtNumDep.Name = "txtNumDep";
            this.txtNumDep.Size = new System.Drawing.Size(226, 20);
            this.txtNumDep.TabIndex = 28;
            this.txtNumDep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumDep_KeyPress);
            // 
            // txtvalorhora
            // 
            this.txtvalorhora.Location = new System.Drawing.Point(161, 68);
            this.txtvalorhora.Name = "txtvalorhora";
            this.txtvalorhora.Size = new System.Drawing.Size(226, 20);
            this.txtvalorhora.TabIndex = 27;
            this.txtvalorhora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalorhora_KeyPress);
            // 
            // txthorastrab
            // 
            this.txthorastrab.Location = new System.Drawing.Point(161, 40);
            this.txthorastrab.Name = "txthorastrab";
            this.txthorastrab.Size = new System.Drawing.Size(226, 20);
            this.txthorastrab.TabIndex = 26;
            this.txthorastrab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthorastrab_KeyPress);
            // 
            // txtnomefunc
            // 
            this.txtnomefunc.Location = new System.Drawing.Point(161, 12);
            this.txtnomefunc.Name = "txtnomefunc";
            this.txtnomefunc.Size = new System.Drawing.Size(450, 20);
            this.txtnomefunc.TabIndex = 25;
            this.txtnomefunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnomefunc_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Num. Dependentes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Valor da Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Horas Trabalhadas";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(47, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(564, 154);
            this.label2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome do Funcionário";
            // 
            // frmFolhaPagto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 333);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblImpostoRenda);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumDep);
            this.Controls.Add(this.txtvalorhora);
            this.Controls.Add(this.txthorastrab);
            this.Controls.Add(this.txtnomefunc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFolhaPagto";
            this.Text = "Folha de Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblImpostoRenda;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNumDep;
        private System.Windows.Forms.TextBox txtvalorhora;
        private System.Windows.Forms.TextBox txthorastrab;
        private System.Windows.Forms.TextBox txtnomefunc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

