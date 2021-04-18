using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TomasBlencioTp02.BL;

namespace TomasBlencioTp02.WindowsForms
{
    public partial class FormularioAE : Form
    {
        public FormularioAE()
        {
            InitializeComponent();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        Hexagono hexagono;
        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (hexagono==null)
                {
                    hexagono = new Hexagono(); 
                }
                hexagono.Lado = double.Parse(LadoHexágonoTextBox.Text);
                hexagono.Borde = BordeComboBox.SelectedItem.ToString();
                DialogResult = DialogResult.OK; 
            }
        }

        private bool validarDatos()
        {
            var valido = true;
            if (!double.TryParse(LadoHexágonoTextBox.Text, out var lado))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(LadoHexágonoTextBox, "El lado debe ser un numero");
                valido = false;
            }
            else if (lado<=0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(LadoHexágonoTextBox, "El lado debe ser positivo");
                valido = false;
            }

            return valido;
        }

        internal Hexagono GetHexagono()
        {
            return hexagono;
        }

        protected override void OnLoad(EventArgs e)
        {
            if (hexagono!=null)
            {
                LadoHexágonoTextBox.Text = hexagono.Lado.ToString();
                //BordeComboBox.Text = hexagono.Borde.ToString(); 
                
            }
        }

        internal void SetHexagono(Hexagono hexagono)
        {
            this.hexagono = hexagono;           
        }
    }
}
