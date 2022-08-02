/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 30/07/2022
 * Time: 07:31 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ventaPHR
{
	partial class corteCaja
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
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precio_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblGanancia = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.lblFecha = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
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
									this.nombre,
									this.id_producto,
									this.precio_venta,
									this.precio_compra,
									this.cantidad});
			this.dataGridViewProductos.Location = new System.Drawing.Point(12, 28);
			this.dataGridViewProductos.MultiSelect = false;
			this.dataGridViewProductos.Name = "dataGridViewProductos";
			this.dataGridViewProductos.ReadOnly = true;
			this.dataGridViewProductos.RowHeadersVisible = false;
			this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewProductos.Size = new System.Drawing.Size(350, 484);
			this.dataGridViewProductos.TabIndex = 0;
			// 
			// nombre
			// 
			this.nombre.FillWeight = 203.0457F;
			this.nombre.HeaderText = "Nombre";
			this.nombre.Name = "nombre";
			this.nombre.ReadOnly = true;
			// 
			// id_producto
			// 
			this.id_producto.FillWeight = 74.23858F;
			this.id_producto.HeaderText = "Codigo";
			this.id_producto.Name = "id_producto";
			this.id_producto.ReadOnly = true;
			// 
			// precio_venta
			// 
			this.precio_venta.FillWeight = 74.23858F;
			this.precio_venta.HeaderText = "Precio Venta";
			this.precio_venta.Name = "precio_venta";
			this.precio_venta.ReadOnly = true;
			// 
			// precio_compra
			// 
			this.precio_compra.FillWeight = 74.23858F;
			this.precio_compra.HeaderText = "Precio Compra";
			this.precio_compra.Name = "precio_compra";
			this.precio_compra.ReadOnly = true;
			// 
			// cantidad
			// 
			this.cantidad.FillWeight = 74.23858F;
			this.cantidad.HeaderText = "Cantidad";
			this.cantidad.Name = "cantidad";
			this.cantidad.ReadOnly = true;
			// 
			// lblTotal
			// 
			this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(375, 100);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(158, 31);
			this.lblTotal.TabIndex = 9;
			this.lblTotal.Text = "Total: $0.00";
			// 
			// lblGanancia
			// 
			this.lblGanancia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lblGanancia.AutoSize = true;
			this.lblGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGanancia.Location = new System.Drawing.Point(375, 246);
			this.lblGanancia.Name = "lblGanancia";
			this.lblGanancia.Size = new System.Drawing.Size(158, 31);
			this.lblGanancia.TabIndex = 10;
			this.lblGanancia.Text = "Total: $0.00";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(375, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Total de venta:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(375, 223);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Total de ganancia:";
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(411, 489);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 13;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Location = new System.Drawing.Point(437, 9);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(34, 13);
			this.lblFecha.TabIndex = 14;
			this.lblFecha.Text = "fecha";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(375, 25);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(200, 20);
			this.dtpFecha.TabIndex = 15;
			this.dtpFecha.Value = new System.DateTime(2022, 8, 1, 21, 36, 34, 0);
			this.dtpFecha.ValueChanged += new System.EventHandler(this.DtpFechaValueChanged);
			// 
			// corteCaja
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 532);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblGanancia);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.dataGridViewProductos);
			this.Name = "corteCaja";
			this.Text = "corteCaja";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblGanancia;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn precio_compra;
		private System.Windows.Forms.DataGridViewTextBoxColumn precio_venta;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
		private System.Windows.Forms.DataGridView dataGridViewProductos;
	}
}
