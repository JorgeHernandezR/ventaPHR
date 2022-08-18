/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 02/08/2022
 * Time: 12:57 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ventaPHR
{
	partial class consultarDeuda
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
			this.dataGridViewProductosDeuda = new System.Windows.Forms.DataGridView();
			this.lblCliente = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.idProductoDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductosDeuda)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewProductosDeuda
			// 
			this.dataGridViewProductosDeuda.AllowUserToAddRows = false;
			this.dataGridViewProductosDeuda.AllowUserToResizeColumns = false;
			this.dataGridViewProductosDeuda.AllowUserToResizeRows = false;
			this.dataGridViewProductosDeuda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewProductosDeuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProductosDeuda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.idProductoDeuda,
									this.cantidad,
									this.nombre,
									this.precio,
									this.fecha});
			this.dataGridViewProductosDeuda.Location = new System.Drawing.Point(12, 51);
			this.dataGridViewProductosDeuda.MultiSelect = false;
			this.dataGridViewProductosDeuda.Name = "dataGridViewProductosDeuda";
			this.dataGridViewProductosDeuda.RowHeadersVisible = false;
			this.dataGridViewProductosDeuda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewProductosDeuda.Size = new System.Drawing.Size(444, 287);
			this.dataGridViewProductosDeuda.TabIndex = 0;
			// 
			// lblCliente
			// 
			this.lblCliente.Location = new System.Drawing.Point(21, 9);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(100, 23);
			this.lblCliente.TabIndex = 1;
			this.lblCliente.Text = "Nombre Cliente";
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(390, 344);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(12, 344);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(75, 23);
			this.btnModificar.TabIndex = 3;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// idProductoDeuda
			// 
			this.idProductoDeuda.HeaderText = "ID";
			this.idProductoDeuda.Name = "idProductoDeuda";
			this.idProductoDeuda.Visible = false;
			// 
			// cantidad
			// 
			this.cantidad.HeaderText = "Cantidad";
			this.cantidad.Name = "cantidad";
			this.cantidad.ReadOnly = true;
			// 
			// nombre
			// 
			this.nombre.HeaderText = "Producto";
			this.nombre.Name = "nombre";
			// 
			// precio
			// 
			this.precio.HeaderText = "Precio";
			this.precio.Name = "precio";
			// 
			// fecha
			// 
			this.fecha.HeaderText = "Fecha";
			this.fecha.Name = "fecha";
			this.fecha.ReadOnly = true;
			// 
			// consultarDeuda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 379);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.lblCliente);
			this.Controls.Add(this.dataGridViewProductosDeuda);
			this.Name = "consultarDeuda";
			this.Text = "consultarDeuda";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductosDeuda)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDeuda;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn precio;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
		private System.Windows.Forms.DataGridView dataGridViewProductosDeuda;
	}
}
