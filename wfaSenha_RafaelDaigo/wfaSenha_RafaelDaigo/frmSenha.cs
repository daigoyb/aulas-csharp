using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaSenha_RafaelDaigo
{
    public partial class frmSenha : Form
    {
        public frmSenha()
        {
            InitializeComponent();
        }
        #region Variáveis
        string senha = "";
        int contador_senha = 0;
        #endregion

        #region Eventos
        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (!(string.IsNullOrEmpty(txtNome.Text)) & !(string.IsNullOrEmpty(txtSenha.Text)))
                    btnTesouro.PerformClick();
            }
            else if (e.KeyChar == (char)8 && !(string.IsNullOrEmpty(senha))) {
                senha = senha.Substring(0, senha.Length - 1);
            }
            else
            {
                senha = senha + e.KeyChar;
                e.KeyChar = '*';
            }

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar !=(char)13)
                e.KeyChar = toMaiusc(txtNome.Text, e.KeyChar);
            if (e.KeyChar == (char)13)
            {
                txtNome.Text = txtNome.Text.Trim();
                if (txtNome.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Preenchimento Obrigatório");
                    txtNome.Focus();
                    return;
                }
                txtSenha.Focus();
            }
        }

        private void btnTesouro_Click(object sender, EventArgs e)
        {
            if (senha == "1234")
            {
                MessageBox.Show("Bem Vindo Sr(a). " + txtNome.Text);
            }
            else
            {
                contador_senha += 1;
                MessageBox.Show("Cai Fora!! Você tem mais " + (3 - contador_senha) + " tentativas");
                if (contador_senha > 2)
                {
                    MessageBox.Show("Quantidade Máxima de Tentativas Excedida");
                    this.Close();
                }
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSenha_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair do sistema?", "Confirmação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        #endregion

        #region Métodos

        public char toMaiusc(string texto, char tecla)
        {
            int i;
            i = (int)tecla;
            if (i >= 97 && i <= 122)
            {
                i = (i - 32);
                tecla = (char)i;
            }
            return tecla;
        }

#endregion


    }
}