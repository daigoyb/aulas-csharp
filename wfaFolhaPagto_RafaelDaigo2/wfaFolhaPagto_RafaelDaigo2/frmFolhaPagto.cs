using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaFolhaPagto_RafaelDaigo2
{
    public partial class frmFolhaPagto : Form
    {
        public frmFolhaPagto()
        {
            InitializeComponent();
        }

        #region Eventos
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtnomefunc.Text = "";
            txthorastrab.Text = "";
            txtNumDep.Text = "";
            txtvalorhora.Text = "";
            lblSalarioBruto.Text = "";
            lblImpostoRenda.Text = "";
            lblINSS.Text = "";
            lblSalarioLiquido.Text = "";
            txtnomefunc.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnomefunc.Text) || string.IsNullOrEmpty(txthorastrab.Text) || string.IsNullOrEmpty(txtvalorhora.Text) || string.IsNullOrEmpty(txtNumDep.Text))
            {
                MessageBox.Show("Caixas de Texto não podem estar vazias");
                txtnomefunc.Text = "";
                txthorastrab.Text = "";
                txtNumDep.Text = "";
                txtvalorhora.Text = "";
                txtnomefunc.Focus();
            }
            else
            {
                lblSalarioBruto.Text = Taxas.CalcularSalBruto(float.Parse(txthorastrab.Text), float.Parse(txtvalorhora.Text)).ToString("###,###,##0.00");
                lblINSS.Text = Taxas.CalcularINSS(float.Parse(lblSalarioBruto.Text)).ToString("###,###,##0.00");
                lblImpostoRenda.Text = Taxas.CalcularIRR(float.Parse(lblSalarioBruto.Text), float.Parse(lblINSS.Text), int.Parse(txtNumDep.Text)).ToString("###,###,##0.00");
                lblSalarioLiquido.Text = Taxas.CalcularSalLiquido(float.Parse(lblSalarioBruto.Text), float.Parse(lblINSS.Text), float.Parse(lblImpostoRenda.Text)).ToString("###,###,##0.00");
            }
        }
        private void txtnomefunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Validacao.ValidaCaracteres(txtnomefunc.Text, e.KeyChar);
            if (e.KeyChar == (char)13)
                txthorastrab.Focus();
            
        }
        private void txthorastrab_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Validacao.ValidaNumeroReal(txthorastrab.Text, e.KeyChar);
            if (e.KeyChar == (char)13)
                txtvalorhora.Focus();
            
        }
        private void txtvalorhora_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Validacao.ValidaNumeroReal(txtvalorhora.Text, e.KeyChar);
            if (e.KeyChar == (char)13)
                txtNumDep.Focus();
            
        }
        private void txtNumDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Validacao.ValidaNumeroNatural(txtNumDep.Text, e.KeyChar);
            if (e.KeyChar == (char)13)
                btnCalcular.PerformClick();
            if (e.KeyChar == (char)0)
            {
                MessageBox.Show("Tecla Inválida! Apenas número positivos e inteiros podem ser inseridos.");
                txtNumDep.Focus();
                txtNumDep.SelectAll();
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que quer sair?", "Confirmação de saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
                this.Close();
        }
        #endregion


    }
}
