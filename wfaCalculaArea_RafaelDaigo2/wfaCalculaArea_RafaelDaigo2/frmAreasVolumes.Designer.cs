namespace wfaCalculaArea_RafaelDaigo2
{
    partial class frmAreasVolumes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAreasVolumes));
            this.gpbFormas = new System.Windows.Forms.GroupBox();
            this.rdbParalelepipedo = new System.Windows.Forms.RadioButton();
            this.rdbRetangulo = new System.Windows.Forms.RadioButton();
            this.rdbQuadrado = new System.Windows.Forms.RadioButton();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblVarx = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.TextBox();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.gpbFormas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFormas
            // 
            this.gpbFormas.Controls.Add(this.rdbParalelepipedo);
            this.gpbFormas.Controls.Add(this.rdbRetangulo);
            this.gpbFormas.Controls.Add(this.rdbQuadrado);
            this.gpbFormas.Location = new System.Drawing.Point(28, 22);
            this.gpbFormas.Name = "gpbFormas";
            this.gpbFormas.Size = new System.Drawing.Size(130, 211);
            this.gpbFormas.TabIndex = 0;
            this.gpbFormas.TabStop = false;
            this.gpbFormas.Text = "Formas";
            // 
            // rdbParalelepipedo
            // 
            this.rdbParalelepipedo.AutoSize = true;
            this.rdbParalelepipedo.Location = new System.Drawing.Point(6, 168);
            this.rdbParalelepipedo.Name = "rdbParalelepipedo";
            this.rdbParalelepipedo.Size = new System.Drawing.Size(97, 17);
            this.rdbParalelepipedo.TabIndex = 6;
            this.rdbParalelepipedo.TabStop = true;
            this.rdbParalelepipedo.Text = "Paralelepípedo";
            this.rdbParalelepipedo.UseVisualStyleBackColor = true;
            this.rdbParalelepipedo.CheckedChanged += new System.EventHandler(this.rdbParalelepipedo_CheckedChanged);
            // 
            // rdbRetangulo
            // 
            this.rdbRetangulo.AutoSize = true;
            this.rdbRetangulo.Location = new System.Drawing.Point(6, 107);
            this.rdbRetangulo.Name = "rdbRetangulo";
            this.rdbRetangulo.Size = new System.Drawing.Size(74, 17);
            this.rdbRetangulo.TabIndex = 5;
            this.rdbRetangulo.TabStop = true;
            this.rdbRetangulo.Text = "Retângulo";
            this.rdbRetangulo.UseVisualStyleBackColor = true;
            this.rdbRetangulo.CheckedChanged += new System.EventHandler(this.rdbRetangulo_CheckedChanged);
            // 
            // rdbQuadrado
            // 
            this.rdbQuadrado.AutoSize = true;
            this.rdbQuadrado.Checked = true;
            this.rdbQuadrado.Location = new System.Drawing.Point(6, 51);
            this.rdbQuadrado.Name = "rdbQuadrado";
            this.rdbQuadrado.Size = new System.Drawing.Size(72, 17);
            this.rdbQuadrado.TabIndex = 4;
            this.rdbQuadrado.TabStop = true;
            this.rdbQuadrado.Text = "Quadrado";
            this.rdbQuadrado.UseVisualStyleBackColor = true;
            this.rdbQuadrado.CheckedChanged += new System.EventHandler(this.rdbQuadrado_CheckedChanged);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(230, 81);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(64, 20);
            this.txtX.TabIndex = 0;
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(441, 81);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(64, 20);
            this.txtZ.TabIndex = 2;
            this.txtZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(334, 81);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(64, 20);
            this.txtY.TabIndex = 1;
            this.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblVarx
            // 
            this.lblVarx.AutoSize = true;
            this.lblVarx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarx.Location = new System.Drawing.Point(253, 55);
            this.lblVarx.Name = "lblVarx";
            this.lblVarx.Size = new System.Drawing.Size(21, 20);
            this.lblVarx.TabIndex = 5;
            this.lblVarx.Text = "X";
            this.lblVarx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Área/Volume";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblResult.Enabled = false;
            this.lblResult.Location = new System.Drawing.Point(311, 136);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(194, 20);
            this.lblResult.TabIndex = 9;
            this.lblResult.TabStop = false;
            this.lblResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(323, 187);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo.TabIndex = 3;
            this.btnCalculo.Text = "Cálculo";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(430, 187);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(75, 23);
            this.btnLimpa.TabIndex = 7;
            this.btnLimpa.Text = "Limpa";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // frmAreasVolumes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 271);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVarx);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.gpbFormas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAreasVolumes";
            this.Text = "Cálculo de Áreas e Volumes";
            this.Load += new System.EventHandler(this.frmAreasVolumes_Load);
            this.gpbFormas.ResumeLayout(false);
            this.gpbFormas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFormas;
        private System.Windows.Forms.RadioButton rdbParalelepipedo;
        private System.Windows.Forms.RadioButton rdbRetangulo;
        private System.Windows.Forms.RadioButton rdbQuadrado;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblVarx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblResult;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Button btnLimpa;
    }
}

