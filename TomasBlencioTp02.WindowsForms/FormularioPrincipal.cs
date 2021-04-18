using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomasBlencioTp02.BL;
using TomasBlencioTp02.DL;

namespace TomasBlencioTp02.WindowsForms
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private RepositorioHexagonos repositorio;
        private List<Hexagono> lista;
        

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            repositorio = new RepositorioHexagonos();
            lista = repositorio.GetLista();
            CantidadTextBox.Text = repositorio.GetCantidad().ToString();
            MostrarDatosEnGrilla();
        }
        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var hexagono in lista)
            {
                DataGridViewRow r = ConstruirFila();
                RellenarFila(r, hexagono);
                AgregarFila(r);
            }
        }
        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void RellenarFila(DataGridViewRow r, Hexagono hexagono)
        {
            r.Cells[ColumnaLado.Index].Value = hexagono.Lado;
            r.Cells[ColumnaBorde.Index].Value = hexagono.Borde;
            r.Cells[ColumnaPerimetro.Index].Value = hexagono.GetPerimetro();
            r.Cells[ColumnaArea.Index].Value = hexagono.GetArea();
            r.Cells[ColumnaApotema.Index].Value = hexagono.GetApotema();

            r.Tag = hexagono;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

        private void SalirToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            FormularioAE frm = new FormularioAE();
            frm.Text = "Agregar nuevo Hexágono";
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                Hexagono hexagono = frm.GetHexagono();
                DataGridViewRow r = ConstruirFila();
                RellenarFila(r, hexagono);
                AgregarFila(r);
                repositorio.Agregar(hexagono);
                CantidadTextBox.Text = repositorio.GetCantidad().ToString();
            }
        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = DatosDataGridView.SelectedRows[0];
            Hexagono hexagono = r.Tag as Hexagono;
            DialogResult dr=MessageBox.Show($"¿Estas seguro que desea eliminar completamente" +
                $"el Hexágono seleccionado, de lado {hexagono.Lado} y de borde " +
                $"{hexagono.Borde}?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.Yes)
            {
                DatosDataGridView.Rows.Remove(r);
                repositorio.Borrar(hexagono);
                CantidadTextBox.Text = repositorio.GetCantidad().ToString();

            }
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = DatosDataGridView.SelectedRows[0];
            Hexagono hexagono = r.Tag as Hexagono;
            FormularioAE frm = new FormularioAE();
            frm.SetHexagono(hexagono);
            DialogResult dr=frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                frm.GetHexagono();
                RellenarFila(r, hexagono);
                MessageBox.Show("Hexágono editado correctamente", "Mensaje",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void ActualizarToolStripButton_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetLista();
            MostrarDatosEnGrilla();
        }

        private void FiltrarPorLadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.OrdenarPorLado();
            MostrarDatosEnGrilla();
        }

        private void FiltrarPorApotemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.OrdenarPorApotema();
            MostrarDatosEnGrilla();
        }

        
    }
}
