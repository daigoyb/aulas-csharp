namespace wfaFoguete
{
    partial class frmFoguete
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFoguete));
            this.picForguete = new System.Windows.Forms.PictureBox();
            this.btnDispara = new System.Windows.Forms.Button();
            this.btnPara = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picAviao = new System.Windows.Forms.PictureBox();
            this.picExplosao = new System.Windows.Forms.PictureBox();
            this.picParaquedista = new System.Windows.Forms.PictureBox();
            this.picGlub1 = new System.Windows.Forms.PictureBox();
            this.picGlub2 = new System.Windows.Forms.PictureBox();
            this.btnAcelera = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picForguete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAviao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExplosao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParaquedista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGlub1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGlub2)).BeginInit();
            this.SuspendLayout();
            // 
            // picForguete
            // 
            this.picForguete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picForguete.ErrorImage = null;
            this.picForguete.Image = ((System.Drawing.Image)(resources.GetObject("picForguete.Image")));
            this.picForguete.Location = new System.Drawing.Point(32, 173);
            this.picForguete.Name = "picForguete";
            this.picForguete.Size = new System.Drawing.Size(244, 246);
            this.picForguete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picForguete.TabIndex = 0;
            this.picForguete.TabStop = false;
            // 
            // btnDispara
            // 
            this.btnDispara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDispara.Location = new System.Drawing.Point(423, 263);
            this.btnDispara.Name = "btnDispara";
            this.btnDispara.Size = new System.Drawing.Size(101, 48);
            this.btnDispara.TabIndex = 1;
            this.btnDispara.Text = "Dispara";
            this.btnDispara.UseVisualStyleBackColor = true;
            this.btnDispara.Click += new System.EventHandler(this.btnDispara_Click);
            // 
            // btnPara
            // 
            this.btnPara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPara.Location = new System.Drawing.Point(423, 317);
            this.btnPara.Name = "btnPara";
            this.btnPara.Size = new System.Drawing.Size(101, 48);
            this.btnPara.TabIndex = 2;
            this.btnPara.Text = "Para";
            this.btnPara.UseVisualStyleBackColor = true;
            this.btnPara.Click += new System.EventHandler(this.btnPara_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picAviao
            // 
            this.picAviao.Image = ((System.Drawing.Image)(resources.GetObject("picAviao.Image")));
            this.picAviao.Location = new System.Drawing.Point(32, 22);
            this.picAviao.Name = "picAviao";
            this.picAviao.Size = new System.Drawing.Size(55, 50);
            this.picAviao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAviao.TabIndex = 3;
            this.picAviao.TabStop = false;
            // 
            // picExplosao
            // 
            this.picExplosao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picExplosao.Image = ((System.Drawing.Image)(resources.GetObject("picExplosao.Image")));
            this.picExplosao.Location = new System.Drawing.Point(169, 55);
            this.picExplosao.Name = "picExplosao";
            this.picExplosao.Size = new System.Drawing.Size(253, 220);
            this.picExplosao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExplosao.TabIndex = 4;
            this.picExplosao.TabStop = false;
            this.picExplosao.Visible = false;
            // 
            // picParaquedista
            // 
            this.picParaquedista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picParaquedista.Image = ((System.Drawing.Image)(resources.GetObject("picParaquedista.Image")));
            this.picParaquedista.Location = new System.Drawing.Point(251, 117);
            this.picParaquedista.Name = "picParaquedista";
            this.picParaquedista.Size = new System.Drawing.Size(70, 65);
            this.picParaquedista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picParaquedista.TabIndex = 5;
            this.picParaquedista.TabStop = false;
            this.picParaquedista.Visible = false;
            // 
            // picGlub1
            // 
            this.picGlub1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picGlub1.Image = ((System.Drawing.Image)(resources.GetObject("picGlub1.Image")));
            this.picGlub1.Location = new System.Drawing.Point(237, 369);
            this.picGlub1.Name = "picGlub1";
            this.picGlub1.Size = new System.Drawing.Size(100, 50);
            this.picGlub1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGlub1.TabIndex = 6;
            this.picGlub1.TabStop = false;
            this.picGlub1.Visible = false;
            // 
            // picGlub2
            // 
            this.picGlub2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picGlub2.Image = ((System.Drawing.Image)(resources.GetObject("picGlub2.Image")));
            this.picGlub2.Location = new System.Drawing.Point(237, 369);
            this.picGlub2.Name = "picGlub2";
            this.picGlub2.Size = new System.Drawing.Size(100, 50);
            this.picGlub2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGlub2.TabIndex = 7;
            this.picGlub2.TabStop = false;
            this.picGlub2.Visible = false;
            // 
            // btnAcelera
            // 
            this.btnAcelera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcelera.Location = new System.Drawing.Point(423, 209);
            this.btnAcelera.Name = "btnAcelera";
            this.btnAcelera.Size = new System.Drawing.Size(101, 48);
            this.btnAcelera.TabIndex = 8;
            this.btnAcelera.Text = "Acelerar Avião";
            this.btnAcelera.UseVisualStyleBackColor = true;
            this.btnAcelera.Click += new System.EventHandler(this.btnAcelera_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(423, 371);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(101, 48);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmFoguete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(536, 440);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAcelera);
            this.Controls.Add(this.picGlub2);
            this.Controls.Add(this.picGlub1);
            this.Controls.Add(this.picParaquedista);
            this.Controls.Add(this.picExplosao);
            this.Controls.Add(this.picAviao);
            this.Controls.Add(this.btnPara);
            this.Controls.Add(this.btnDispara);
            this.Controls.Add(this.picForguete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFoguete";
            this.Text = "Acidente Aéreo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFoguete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picForguete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAviao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExplosao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picParaquedista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGlub1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGlub2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picForguete;
        private System.Windows.Forms.Button btnDispara;
        private System.Windows.Forms.Button btnPara;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picAviao;
        private System.Windows.Forms.PictureBox picExplosao;
        private System.Windows.Forms.PictureBox picParaquedista;
        private System.Windows.Forms.PictureBox picGlub1;
        private System.Windows.Forms.PictureBox picGlub2;
        private System.Windows.Forms.Button btnAcelera;
        private System.Windows.Forms.Button btnSair;
    }
}

