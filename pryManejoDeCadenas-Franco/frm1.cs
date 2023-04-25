using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryManejoDeCadenas_Franco
{
    public partial class frm1 : Form
    {
        string textoA;
        string textoB;
        public frm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            textoA = txtA.Text;
            lblCantA.Text = textoA.Length.ToString();
            if (lblCantA.Text != "0") 
            {
                btnBuscar.Enabled = true;
               
            }
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            textoB = txtB.Text;
            lblCantB.Text = textoB.Length.ToString();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (textoA.IndexOf(txtBusqueda.Text) != -1)
            {
                txtBusqueda.BackColor = Color.Green;
            }
            else
            {
                txtBusqueda.BackColor = Color.Red;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Visible = true;
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            textoA = txtA.Text;
            textoB = txtB.Text;

            int resultado = string.Compare(textoA, textoB);
            if (resultado == 0)
            {
                MessageBox.Show("El contenido de los textos  es igual");
            }
            else
            {
                if (resultado < 0)
                {
                    MessageBox.Show("El texto B contiene mayor cantidad de caracteres");
                }
                else
                {
                    if (resultado > 0)
                    {
                        MessageBox.Show("El texto A contiene mayor cantidad de caracteres");
                    }
                }
            }
        }

        private void btnConver_Click(object sender, EventArgs e)
        {
            DateTime A = DTPicker.Value;
            string B = A.ToString("dd/MM/yyyy");
            lblFecha.Text = B;
        }

        private void btnRemplazo_Click(object sender, EventArgs e)
        {
            textoA = txtA.Text;
            string stringB = "";
            stringB = textoA.Replace(textoA, txtB.Text);
            txtA.Text = stringB;
            txtB.Clear();
        }
    }
}
