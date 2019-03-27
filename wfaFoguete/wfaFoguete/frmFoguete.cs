using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaFoguete
{
    public partial class frmFoguete : Form
    {
        bool choque = false;
        public frmFoguete()
        {
            InitializeComponent();
        }
        private void frmFoguete_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picForguete.Top = this.ClientSize.Height - picForguete.Height;
        }

        private void btnDispara_Click(object sender, EventArgs e)
        {
            /*int i;
            this.Cursor = Cursors.WaitCursor;
            for (i=1; i < 30000; i++)
            {
                Application.DoEvents();
                picForguete.Top = picForguete.Top - 1;
                picForguete.Left = picForguete.Left + 1;
            }
            this.Cursor = Cursors.Default;*/
            timer1.Enabled = true;
        }

        private void btnPara_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            if (choque == true)
            {
                picExplosao.Visible = !picExplosao.Visible;
                picExplosao.Width -= 2;
                picExplosao.Height -= 2;
                picExplosao.Top -= 1;
                picExplosao.Left += 1;
            }
            picForguete.Top = picForguete.Top - 1;
            picForguete.Left = picForguete.Left + 3;

            picAviao.Top = picAviao.Top + 1;
            picAviao.Left = picAviao.Left + 3;

            if (picForguete.Top % 7 == 0)
            {
                picForguete.Height = picForguete.Height - 1;
                picForguete.Width = picForguete.Width - 1;
                picAviao.Height = picAviao.Height + 1;
                picAviao.Width = picAviao.Width + 1;
            }

            if((Math.Abs(picForguete.Top - picAviao.Top) < 40) && (Math.Abs(picForguete.Left - picAviao.Left) < 40))
            {
                choque = true;
                picForguete.Visible = false;
                picAviao.Visible = false;
            }
            if ((Math.Abs(picExplosao.Height)) < 80)
            {
                picParaquedista.Visible = true;
                picParaquedista.Top += 1;
            }
            if (picParaquedista.Bottom > ClientSize.Height)
            {
                picParaquedista.Visible = false;
                picGlub1.Visible = !picGlub1.Visible;
                picGlub2.Visible = !picGlub2.Visible;
            }

            
        }
        private void btnAcelera_Click(object sender, EventArgs e)
        {
            picAviao.Left += 10;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que quer sair?", "Confirmação de saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
                this.Close();
        }
 
    }
}
