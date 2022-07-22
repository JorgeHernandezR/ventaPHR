/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 19/07/2022
 * Time: 07:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ventaPHR
{
	partial class Buscar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSalir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFiltro = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewProductos
			// 
			this.dataGridViewProductos.AllowUserToAddRows = false;
			this.dataGridViewProductos.AllowUserToDeleteRows = false;
			this.dataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.id,
									this.nombre,
									this.precio,
									this.cantidad,
									this.codigo,
									this.existencia});
			this.dataGridViewProductos.Location = new System.Drawing.Point(60, 38);
			this.dataGridViewProductos.MultiSelect = false;
			this.dataGridViewProductos.Name = "dataGridViewProductos";
			this.dataGridViewProductos.ReadOnly = true;
			this.dataGridViewProductos.RowHeadersVisible = false;
			this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewProductos.Size = new System.Drawing.Size(599, 315);
			this.dataGridViewProductos.TabIndex = 2;
			// 
			// id
			// 
			this.id.HeaderText = "id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			// 
			// nombre
			// 
			this.nombre.HeaderText = "nombre";
			this.nombre.Name = "nombre";
			this.nombre.ReadOnly = true;
			// 
			// precio
			// 
			this.precio.HeaderText = "Precio";
			this.precio.Name = "precio";
			this.precio.ReadOnly = true;
			// 
			// cantidad
			// 
			this.cantidad.HeaderText = "Existencias";
			this.cantidad.Name = "cantidad";
			this.cantidad.ReadOnly = true;
			// 
			// codigo
			// 
			this.codigo.HeaderText = "Codigo";
			this.codigo.Name = "codigo";
			this.codigo.ReadOnly = true;
			// 
			// existencia
			// 
			this.existencia.HeaderText = "Existencia";
			this.existencia.Name = "existencia";
			this.existencia.ReadOnly = true;
			this.existencia.Visible = false;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(658, 384);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 3;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(60, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Filtro:";
			// 
			// txtFiltro
			// 
			this.txtFiltro.Location = new System.Drawing.Point(98, 8);
			this.txtFiltro.Name = "txtFiltro";
			this.txtFiltro.Size = new System.Drawing.Size(346, 20);
			this.txtFiltro.TabIndex = 5;
			this.txtFiltro.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// Buscar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(745, 419);
			this.Controls.Add(this.txtFiltro);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.dataGridViewProductos);
			this.Name = "Buscar";
			this.Text = "Buscar";
			this.Load += new System.EventHandler(this.BuscarLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtFiltro;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.DataGridViewTextBoxColumn existencia;
		private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn precio;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridView dataGridViewProductos;
	}
}
