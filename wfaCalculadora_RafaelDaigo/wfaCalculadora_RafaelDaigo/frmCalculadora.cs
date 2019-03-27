using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaCalculadora_RafaelDaigo
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }
        #region variáveis
        float valor1, valor2, resultado;
        #endregion

        #region Events
        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void frmCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '+':
                    soma();
                    e.KeyChar = (Char)0;
                    break;
                case '-':
                    subtrai();
                    e.KeyChar = (Char)0;
                    break;
                case '*':
                    multiplica();
                    e.KeyChar = (Char)0;
                    break;
                case '/':
                    divide();
                    e.KeyChar = (Char)0;
                    break;
                case (Char)8:
                    limpa();
                    e.KeyChar = (Char)0;
                    break;
            }
        }

        private void lblResult_TextChanged(object sender, EventArgs e)
        {
            if (lblResult.Text == "" || float.Parse(lblResult.Text) == 0 || float.Parse(lblResult.Text) > 0)
            {
                lblResult.ForeColor = Color.Black;
            }
            else lblResult.ForeColor = Color.Red;

                
            
        }

        private void txtN1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("Voce Digitou: " + e.KeyChar);
            int index = txtN1.Text.IndexOf(',');
            if (e.KeyChar == (Char)13)
            {
                txtN2.Focus();
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && e.KeyChar == (Char)8)
            {
                MessageBox.Show("Uma Tecla Inválida");
                e.KeyChar = (Char)0;
            }
            else if (e.KeyChar == ',')
            {
                index++;
                if(index > 1){
                    MessageBox.Show("Apenas uma vírgula é possível");
                    e.KeyChar = (Char)0;
                }
            }
        }


        private void txtN2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int index = txtN2.Text.IndexOf(',');
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',' && e.KeyChar == (Char)8){
                MessageBox.Show("Uma Tecla Inválida");
                e.KeyChar = (Char)0;
            }
            else if(e.KeyChar == (Char)13)
            {
                soma();
            }
            else if (e.KeyChar == ',')
            {
                index++;
                if (index > 1)
                {
                    MessageBox.Show("Apenas uma vírgula é possível");
                    e.KeyChar = (Char)0;
                }
            }



        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            soma();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            subtrai();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            multiplica();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            divide();
        }
        private void btnLimpa_Click(object sender, EventArgs e)
        {
            limpa();
        }
        
#endregion
       
        #region Métodos
        void soma()
        {
            try
            {

                valor1 = float.Parse(txtN1.Text);
                valor2 = float.Parse(txtN2.Text);

                resultado = valor1 + valor2;
                lblResult.Text = resultado.ToString();
            }
            catch (Exception err)
            {
                lblResult.Text = "";
                lblResult.Text = err.Message;
            }
        }

        void subtrai()
        {
            try
            {

                valor1 = float.Parse(txtN1.Text);
                valor2 = float.Parse(txtN2.Text);

                resultado = valor1 - valor2;
                lblResult.Text = resultado.ToString();
            }
            catch (Exception err)
            {
                lblResult.Text = "";
                lblResult.Text = err.Message;
            }
        }

        void multiplica()
        {
            try
            {

                valor1 = float.Parse(txtN1.Text);
                valor2 = float.Parse(txtN2.Text);

                resultado = valor1 * valor2;
                lblResult.Text = resultado.ToString();
            }
            catch (Exception err)
            {
                lblResult.Text = "";
                lblResult.Text = err.Message;
            }
        }



        void divide()
        {
            try
            {

                valor1 = float.Parse(txtN1.Text);
                valor2 = float.Parse(txtN2.Text);
                if (valor2 == 0.0)
                {
                    MessageBox.Show("Impossível dividir por zero");
                    txtN2.Focus();
                    txtN2.SelectAll();
                }
                resultado = valor1 / valor2;
                lblResult.Text = resultado.ToString();
            }
            catch (Exception err)
            {
                lblResult.Text = "";
                lblResult.Text = err.Message;
            }
        }
        void limpa()
        {
            txtN1.Text = "";
            txtN2.Text = "";
            lblResult.Text = "";
            txtN1.Focus();
        }

        #endregion


    }
}
