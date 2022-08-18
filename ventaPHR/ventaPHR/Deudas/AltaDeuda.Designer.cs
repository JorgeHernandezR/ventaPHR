/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 09/08/2022
 * Time: 10:19 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ventaPHR
{
	partial class AltaDeuda
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
			this.btnAgregarCliente = new System.Windows.Forms.Button();
			this.txtNombreCliente = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.dataGridViewProductosDeuda = new System.Windows.Forms.DataGridView();
			this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.lblFecha = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductosDeuda)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAgregarCliente
			// 
			this.btnAgregarCliente.Location = new System.Drawing.Point(118, 30);
			this.btnAgregarCliente.Name = "btnAgregarCliente";
			this.btnAgregarCliente.Size = new System.Drawing.Size(21, 18);
			this.btnAgregarCliente.TabIndex = 0;
			this.btnAgregarCliente.Text = "+";
			this.btnAgregarCliente.UseVisualStyleBackColor = true;
			this.btnAgregarCliente.Click += new System.EventHandler(this.BtnAgregarClienteClick);
			// 
			// txtNombreCliente
			// 
			this.txtNombreCliente.Enabled = false;
			this.txtNombreCliente.Location = new System.Drawing.Point(12, 28);
			this.txtNombreCliente.Name = "txtNombreCliente";
			this.txtNombreCliente.ReadOnly = true;
			this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
			this.txtNombreCliente.TabIndex = 1;
			this.txtNombreCliente.Text = "Nombre Cliente:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(163, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Total: $";
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(212, 28);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(56, 20);
			this.txtTotal.TabIndex = 3;
			// 
			// dataGridViewProductosDeuda
			// 
			this.dataGridViewProductosDeuda.AllowUserToResizeColumns = false;
			this.dataGridViewProductosDeuda.AllowUserToResizeRows = false;
			this.dataGridViewProductosDeuda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewProductosDeuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProductosDeuda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.cantidad,
									this.nombre,
									this.precio,
									this.fecha});
			this.dataGridViewProductosDeuda.Location = new System.Drawing.Point(12, 108);
			this.dataGridViewProductosDeuda.MultiSelect = false;
			this.dataGridViewProductosDeuda.Name = "dataGridViewProductosDeuda";
			this.dataGridViewProductosDeuda.RowHeadersVisible = false;
			this.dataGridViewProductosDeuda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewProductosDeuda.Size = new System.Drawing.Size(491, 233);
			this.dataGridViewProductosDeuda.TabIndex = 4;
			// 
			// cantidad
			// 
			this.cantidad.HeaderText = "Cantidad";
			this.cantidad.Name = "cantidad";
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
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Productos:";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(12, 377);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 6;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(427, 377);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 7;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Location = new System.Drawing.Point(313, 25);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(40, 13);
			this.lblFecha.TabIndex = 8;
			this.lblFecha.Text = "Fecha:";
			// 
			// AltaDeuda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 412);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridViewProductosDeuda);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNombreCliente);
			this.Controls.Add(this.btnAgregarCliente);
			this.Name = "AltaDeuda";
			this.Text = "AltaDeuda";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductosDeuda)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn precio;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
		private System.Windows.Forms.DataGridView dataGridViewProductosDeuda;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombreCliente;
		private System.Windows.Forms.Button btnAgregarCliente;
	}
}
