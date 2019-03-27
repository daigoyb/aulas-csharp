using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaEditor_RafaelDaigo
{
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
            rbPreto.Checked = true;
        }

        private void rbPreto_CheckedChanged(object sender, EventArgs e)
        {
            txtTexto.ForeColor = Color.Black;
        }

        private void rbVerde_CheckedChanged(object sender, EventArgs e)
        {
            txtTexto.ForeColor = Color.LawnGreen;
        }

        private void rbVermelho_CheckedChanged(object sender, EventArgs e)
        {
            txtTexto.ForeColor = Color.IndianRed;
        }

        private void cbNegrito_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNegrito.Checked && !cbSublinhado.Checked)
                txtTexto.Font = new Font(txtTexto.Font, FontStyle.Bold);

            if (cbNegrito.Checked && cbSublinhado.Checked)
                txtTexto.Font = new Font(txtTexto.Font, FontStyle.Bold | FontStyle.Underline);

            if (!cbNegrito.Checked && !cbSublinhado.Checked)
                txtTexto.Font = new Font(txtTexto.Font, FontStyle.Regular);

            if (!cbNegrito.Checked && cbSublinhado.Checked)
                txtTexto.Font = new Font(txtTexto.Font, FontStyle.Underline);
        }

        private void cbSublinhado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNegrito.Checked && !cbSublinhado.Checked)
                txtTexto.Font = new Font(txtTexto.Font, FontStyle.Bold);

            if (cbNegrito.Checked && cbSublinhado.Checked)
                txtTexto.Font = new Font(txtTexto.Font, FontStyle.Bold | FontStyle.Underline);

            if (!cbNegrito.Checked && !cbSublinhado.Checked)
                txtTexto.Font = new Font(txtTexto.Font, FontStyle.Regular);

            if (!cbNegrito.Checked && cbSublinhado.Checked)
                txtTexto.Font = new Font(txtTexto.Font, FontStyle.Underline);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja sair?", "Confirmação de Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
                this.Close();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTexto.Text = "";
            rbPreto.Checked = true;
            cbNegrito.Checked = false;
            cbSublinhado.Checked = false;
            txtTexto.Focus();
        }
    }
}
