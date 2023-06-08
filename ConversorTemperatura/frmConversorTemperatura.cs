using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorTemperatura
{
    public partial class frmConversorTemperatura : MaterialForm
    {
        public frmConversorTemperatura()
        {
            InitializeComponent();


            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            var unidadeInicialIsNotNull = Double.TryParse(txtUnidadeInicial.Text, out double unidadeInicial);
            double unidadeConvertida;

            if ( cboUnidadeInicial.Text == "" || cboUnidadeConvertida.Text == "" )
            {
                MessageBox.Show("Preencha todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUnidadeConvertida.Clear();
            }

            else if ( cboUnidadeInicial.Text == cboUnidadeConvertida.Text )
            {
                txtUnidadeConvertida.Text = txtUnidadeInicial.Text;
                MessageBox.Show("Unidades de medidas iguais", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if ( !unidadeInicialIsNotNull )
            {
                MessageBox.Show("Preencha o valor com dados válidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUnidadeInicial.Clear();
                txtUnidadeConvertida.Clear();
            }

            else
            {
                if (cboUnidadeInicial.Text == "Celsius")
                {
                    if (cboUnidadeConvertida.Text == "Fahrenheit")
                    {
                        unidadeConvertida = (unidadeInicial * 9 / 5) + 32;
                    }
                    else
                    {
                        unidadeConvertida = unidadeInicial + 273.15;
                    }
                }

                else if (cboUnidadeInicial.Text == "Fahrenheit")
                {
                    if (cboUnidadeConvertida.Text == "Celsius")
                    {
                        unidadeConvertida = ((unidadeInicial - 32) * 5) / 9;
                    }
                    else
                    {
                        unidadeConvertida = ((unidadeInicial - 32) * 5) / 9 + 273.15;
                    }
                }

                else
                {
                    if (cboUnidadeConvertida.Text == "Celsius")
                    {
                        unidadeConvertida = unidadeInicial - 273.15;
                    }
                    else
                    {
                        unidadeConvertida = ((unidadeInicial - 273) * 9) / 5 + 32;
                    }
                }

                txtUnidadeConvertida.Text = unidadeConvertida.ToString("N2");

            }
        }
    }
}
