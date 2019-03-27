using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaCalculaArea_RafaelDaigo2
{
    public partial class frmAreasVolumes : Form
    {
        public frmAreasVolumes()
        {
            InitializeComponent();
        }


        #region Métodos

        float area(float x)
        {
            return x * x;
        }

        float area(float x, float y)
        {
            return x * y;
        }

        float area(float x, float y, float z)
        {
            return x * y * z; 
        }


        #endregion

        #region Eventos

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            float x, y, z;
            if (rdbQuadrado.Checked)
            {
                if (txtX.Text.Trim() != ""){
                    x = float.Parse(txtX.Text);
                    lblResult.Text = area(x).ToString();
                }
                else
                {
                    MessageBox.Show("Preechimento Obrigatório de X");
                    txtX.Focus();
                    return;
                }
            }
        }
        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {/*
            if (e.KeyChar == ',')
                e.KeyChar = testes.soUmaVirgula(txtX.Text);

            e.KeyChar = testes.consistNum(e.KeyChar);
        */
            e.KeyChar = testes.consistNumReal(e.KeyChar, txtX.Text);
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtX.Text = "";
            txtY.Text = "";
            txtX.Text = "";
            lblResult.Text = "";
            txtX.Focus();
            rdbQuadrado.Checked = true;

        }

        private void rdbRetangulo_CheckedChanged(object sender, EventArgs e)
        {
            txtX.Enabled = true;
            txtY.Enabled = true;
            txtZ.Enabled = false;
        }
        private void rdbQuadrado_CheckedChanged(object sender, EventArgs e)
        {
            txtX.Enabled = true;
            txtY.Enabled = false;
            txtZ.Enabled = false;
        }

        private void rdbParalelepipedo_CheckedChanged(object sender, EventArgs e)
        {
            txtX.Enabled = true;
            txtY.Enabled = true;
            txtZ.Enabled = true;
        }

        private void frmAreasVolumes_Load(object sender, EventArgs e)
        {
            rdbRetangulo.Checked = true;
            btnLimpa.PerformClick();
        }
    }
    #endregion

    #region Testes
    public class testes
    {
        public static char consistNumReal(char c, string texto)
        {
            if (c == ',')
                c = soUmaVirgula(texto);
            else
                c = consistNum(c);
           


            return c;

        }

        public static char consistNum(char c)
        {
            if ((c < '0' || c > '9') && c != ',' && c != (char)8)
            {
                MessageBox.Show("Teclas Inválidas!");
                c = (char)0;
            }
            return c;
        }

        public static char soUmaVirgula(string texto)
        {
            int i;
            i = texto.IndexOf(',');
            if (i >= 0)
            {
                MessageBox.Show("Vírgula ja existente");
                return (char)0;
            }
            else
                return ',';
        }

    }
#endregion


}
