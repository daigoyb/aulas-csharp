namespace wfaEditor_RafaelDaigo
{
    partial class frmEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditor));
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.rbPreto = new System.Windows.Forms.RadioButton();
            this.rbVerde = new System.Windows.Forms.RadioButton();
            this.rbVermelho = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSublinhado = new System.Windows.Forms.CheckBox();
            this.cbNegrito = new System.Windows.Forms.CheckBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(12, 12);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(478, 361);
            this.txtTexto.TabIndex = 0;
            // 
            // rbPreto
            // 
            this.rbPreto.AutoSize = true;
            this.rbPreto.Location = new System.Drawing.Point(25, 32);
            this.rbPreto.Name = "rbPreto";
            this.rbPreto.Size = new System.Drawing.Size(50, 17);
            this.rbPreto.TabIndex = 1;
            this.rbPreto.TabStop = true;
            this.rbPreto.Text = "Preto";
            this.rbPreto.UseVisualStyleBackColor = true;
            this.rbPreto.CheckedChanged += new System.EventHandler(this.rbPreto_CheckedChanged);
            // 
            // rbVerde
            // 
            this.rbVerde.AutoSize = true;
            this.rbVerde.Location = new System.Drawing.Point(25, 66);
            this.rbVerde.Name = "rbVerde";
            this.rbVerde.Size = new System.Drawing.Size(53, 17);
            this.rbVerde.TabIndex = 2;
            this.rbVerde.TabStop = true;
            this.rbVerde.Text = "Verde";
            this.rbVerde.UseVisualStyleBackColor = true;
            this.rbVerde.CheckedChanged += new System.EventHandler(this.rbVerde_CheckedChanged);
            // 
            // rbVermelho
            // 
            this.rbVermelho.AutoSize = true;
            this.rbVermelho.Location = new System.Drawing.Point(25, 100);
            this.rbVermelho.Name = "rbVermelho";
            this.rbVermelho.Size = new System.Drawing.Size(69, 17);
            this.rbVermelho.TabIndex = 3;
            this.rbVermelho.TabStop = true;
            this.rbVermelho.Text = "Vermelho";
            this.rbVermelho.UseVisualStyleBackColor = true;
            this.rbVermelho.CheckedChanged += new System.EventHandler(this.rbVermelho_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPreto);
            this.groupBox1.Controls.Add(this.rbVermelho);
            this.groupBox1.Controls.Add(this.rbVerde);
            this.groupBox1.Location = new System.Drawing.Point(513, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 133);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cor da Fonte";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSublinhado);
            this.groupBox2.Controls.Add(this.cbNegrito);
            this.groupBox2.Location = new System.Drawing.Point(513, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Formato";
            // 
            // cbSublinhado
            // 
            this.cbSublinhado.AutoSize = true;
            this.cbSublinhado.Location = new System.Drawing.Point(25, 66);
            this.cbSublinhado.Name = "cbSublinhado";
            this.cbSublinhado.Size = new System.Drawing.Size(79, 17);
            this.cbSublinhado.TabIndex = 1;
            this.cbSublinhado.Text = "Sublinhado";
            this.cbSublinhado.UseVisualStyleBackColor = true;
            this.cbSublinhado.CheckedChanged += new System.EventHandler(this.cbSublinhado_CheckedChanged);
            // 
            // cbNegrito
            // 
            this.cbNegrito.AutoSize = true;
            this.cbNegrito.Location = new System.Drawing.Point(25, 31);
            this.cbNegrito.Name = "cbNegrito";
            this.cbNegrito.Size = new System.Drawing.Size(60, 17);
            this.cbNegrito.TabIndex = 0;
            this.cbNegrito.Text = "Negrito";
            this.cbNegrito.UseVisualStyleBackColor = true;
            this.cbNegrito.CheckedChanged += new System.EventHandler(this.cbNegrito_CheckedChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(532, 286);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 34);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(532, 326);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 34);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 423);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTexto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditor";
            this.Text = "Editor Simples";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.RadioButton rbPreto;
        private System.Windows.Forms.RadioButton rbVerde;
        private System.Windows.Forms.RadioButton rbVermelho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbSublinhado;
        private System.Windows.Forms.CheckBox cbNegrito;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

