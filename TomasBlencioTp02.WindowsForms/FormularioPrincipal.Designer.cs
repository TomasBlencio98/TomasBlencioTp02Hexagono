
namespace TomasBlencioTp02.WindowsForms
{
    partial class FormularioPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ActualizarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SalirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FiltroToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.FiltrarPorLadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltrarPorApotemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltrarPorBordeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnaLado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaBorde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaPerimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaApotema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.BorrarToolStripButton,
            this.EditarToolStripButton,
            this.ActualizarToolStripButton,
            this.SalirToolStripButton,
            this.FiltroToolStripDropDownButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(610, 70);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoToolStripButton.Image")));
            this.NuevoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(52, 67);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BorrarToolStripButton.Image")));
            this.BorrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(52, 67);
            this.BorrarToolStripButton.Text = "Borrar";
            this.BorrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarToolStripButton.Click += new System.EventHandler(this.BorrarToolStripButton_Click);
            // 
            // EditarToolStripButton
            // 
            this.EditarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EditarToolStripButton.Image")));
            this.EditarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarToolStripButton.Name = "EditarToolStripButton";
            this.EditarToolStripButton.Size = new System.Drawing.Size(52, 67);
            this.EditarToolStripButton.Text = "Editar";
            this.EditarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditarToolStripButton.Click += new System.EventHandler(this.EditarToolStripButton_Click);
            // 
            // ActualizarToolStripButton
            // 
            this.ActualizarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ActualizarToolStripButton.Image")));
            this.ActualizarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ActualizarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActualizarToolStripButton.Name = "ActualizarToolStripButton";
            this.ActualizarToolStripButton.Size = new System.Drawing.Size(63, 67);
            this.ActualizarToolStripButton.Text = "Actualizar";
            this.ActualizarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ActualizarToolStripButton.Click += new System.EventHandler(this.ActualizarToolStripButton_Click);
            // 
            // SalirToolStripButton
            // 
            this.SalirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SalirToolStripButton.Image")));
            this.SalirToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SalirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirToolStripButton.Name = "SalirToolStripButton";
            this.SalirToolStripButton.Size = new System.Drawing.Size(52, 67);
            this.SalirToolStripButton.Text = "Salir";
            this.SalirToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirToolStripButton.Click += new System.EventHandler(this.SalirToolStripButton_Click);
            // 
            // FiltroToolStripDropDownButton
            // 
            this.FiltroToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FiltrarPorLadoToolStripMenuItem,
            this.FiltrarPorApotemaToolStripMenuItem,
            this.FiltrarPorBordeToolStripMenuItem});
            this.FiltroToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("FiltroToolStripDropDownButton.Image")));
            this.FiltroToolStripDropDownButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FiltroToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltroToolStripDropDownButton.Name = "FiltroToolStripDropDownButton";
            this.FiltroToolStripDropDownButton.Size = new System.Drawing.Size(61, 67);
            this.FiltroToolStripDropDownButton.Text = "Filtro";
            this.FiltroToolStripDropDownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // FiltrarPorLadoToolStripMenuItem
            // 
            this.FiltrarPorLadoToolStripMenuItem.Name = "FiltrarPorLadoToolStripMenuItem";
            this.FiltrarPorLadoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.FiltrarPorLadoToolStripMenuItem.Text = "Por Lado";
            this.FiltrarPorLadoToolStripMenuItem.Click += new System.EventHandler(this.FiltrarPorLadoToolStripMenuItem_Click);
            // 
            // FiltrarPorApotemaToolStripMenuItem
            // 
            this.FiltrarPorApotemaToolStripMenuItem.Name = "FiltrarPorApotemaToolStripMenuItem";
            this.FiltrarPorApotemaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.FiltrarPorApotemaToolStripMenuItem.Text = "Por Apotema";
            this.FiltrarPorApotemaToolStripMenuItem.Click += new System.EventHandler(this.FiltrarPorApotemaToolStripMenuItem_Click);
            // 
            // FiltrarPorBordeToolStripMenuItem
            // 
            this.FiltrarPorBordeToolStripMenuItem.Name = "FiltrarPorBordeToolStripMenuItem";
            this.FiltrarPorBordeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.FiltrarPorBordeToolStripMenuItem.Text = "Por Borde";
            //this.FiltrarPorBordeToolStripMenuItem.Click += new System.EventHandler(this.FiltrarPorBordeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DatosDataGridView);
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 308);
            this.panel1.TabIndex = 1;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaLado,
            this.ColumnaBorde,
            this.ColumnaPerimetro,
            this.ColumnaArea,
            this.ColumnaApotema});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.RowTemplate.Height = 25;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(610, 308);
            this.DatosDataGridView.TabIndex = 0;
            // 
            // ColumnaLado
            // 
            this.ColumnaLado.HeaderText = "Lado";
            this.ColumnaLado.Name = "ColumnaLado";
            this.ColumnaLado.ReadOnly = true;
            // 
            // ColumnaBorde
            // 
            this.ColumnaBorde.HeaderText = "Borde";
            this.ColumnaBorde.Name = "ColumnaBorde";
            this.ColumnaBorde.ReadOnly = true;
            // 
            // ColumnaPerimetro
            // 
            this.ColumnaPerimetro.HeaderText = "Perimetro";
            this.ColumnaPerimetro.Name = "ColumnaPerimetro";
            this.ColumnaPerimetro.ReadOnly = true;
            // 
            // ColumnaArea
            // 
            this.ColumnaArea.HeaderText = "Area";
            this.ColumnaArea.Name = "ColumnaArea";
            this.ColumnaArea.ReadOnly = true;
            // 
            // ColumnaApotema
            // 
            this.ColumnaApotema.HeaderText = "Apotema";
            this.ColumnaApotema.Name = "ColumnaApotema";
            this.ColumnaApotema.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad Hexágonos: ";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(204, 421);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(71, 23);
            this.CantidadTextBox.TabIndex = 3;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 467);
            this.ControlBox = false;
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hexágonos";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton;
        private System.Windows.Forms.ToolStripButton ActualizarToolStripButton;
        private System.Windows.Forms.ToolStripButton SalirToolStripButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaLado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaBorde;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPerimetro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaApotema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.ToolStripDropDownButton FiltroToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem FiltrarPorLadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FiltrarPorApotemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FiltrarPorBordeToolStripMenuItem;
    }
}

