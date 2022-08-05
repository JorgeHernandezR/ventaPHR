/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 10/07/2022
 * Time: 03:49 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ventaPHR
{
	partial class MainForm
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
			this.lblFecha = new System.Windows.Forms.Label();
			this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnEliminarProducto = new System.Windows.Forms.Button();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.btnPagar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnInventario = new System.Windows.Forms.Button();
			this.btnCorteCaja = new System.Windows.Forms.Button();
			this.btnDeuda = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnCredito = new System.Windows.Forms.Button();
			this.btnCliente = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// lblFecha
			// 
			this.lblFecha.Location = new System.Drawing.Point(12, 9);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(100, 23);
			this.lblFecha.TabIndex = 0;
			this.lblFecha.Text = "FECHA";
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
			this.dataGridViewProductos.Location = new System.Drawing.Point(28, 36);
			this.dataGridViewProductos.MultiSelect = false;
			this.dataGridViewProductos.Name = "dataGridViewProductos";
			this.dataGridViewProductos.ReadOnly = true;
			this.dataGridViewProductos.RowHeadersVisible = false;
			this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewProductos.Size = new System.Drawing.Size(599, 315);
			this.dataGridViewProductos.TabIndex = 1;
			// 
			// id
			// 
			this.id.HeaderText = "id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
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
			this.cantidad.HeaderText = "Cantidad";
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
			// lblTotal
			// 
			this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(454, 354);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(158, 31);
			this.lblTotal.TabIndex = 8;
			this.lblTotal.Text = "Total: $0.00";
			// 
			// btnEliminarProducto
			// 
			this.btnEliminarProducto.AutoSize = true;
			this.btnEliminarProducto.Enabled = false;
			this.btnEliminarProducto.Location = new System.Drawing.Point(28, 364);
			this.btnEliminarProducto.Name = "btnEliminarProducto";
			this.btnEliminarProducto.Size = new System.Drawing.Size(98, 23);
			this.btnEliminarProducto.TabIndex = 9;
			this.btnEliminarProducto.Text = "Eliminar producto";
			this.btnEliminarProducto.UseVisualStyleBackColor = true;
			this.btnEliminarProducto.Click += new System.EventHandler(this.BtnEliminarProductoClick);
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(633, 62);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(100, 20);
			this.txtCodigo.TabIndex = 10;
			this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigoKeyDown);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(633, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "Codigo:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(633, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 12;
			this.label3.Text = "Cantidad:";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(633, 125);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(100, 20);
			this.txtCantidad.TabIndex = 13;
			this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCantidadKeyDown);
			// 
			// btnPagar
			// 
			this.btnPagar.Enabled = false;
			this.btnPagar.Location = new System.Drawing.Point(537, 388);
			this.btnPagar.Name = "btnPagar";
			this.btnPagar.Size = new System.Drawing.Size(75, 23);
			this.btnPagar.TabIndex = 14;
			this.btnPagar.Text = "Pagar";
			this.btnPagar.UseVisualStyleBackColor = true;
			this.btnPagar.Click += new System.EventHandler(this.BtnPagarClick);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(810, 36);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 16;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
			// 
			// btnInventario
			// 
			this.btnInventario.Location = new System.Drawing.Point(809, 111);
			this.btnInventario.Name = "btnInventario";
			this.btnInventario.Size = new System.Drawing.Size(75, 23);
			this.btnInventario.TabIndex = 17;
			this.btnInventario.Text = "Inventario";
			this.btnInventario.UseVisualStyleBackColor = true;
			this.btnInventario.Click += new System.EventHandler(this.BtnInventarioClick);
			// 
			// btnCorteCaja
			// 
			this.btnCorteCaja.AutoSize = true;
			this.btnCorteCaja.Location = new System.Drawing.Point(808, 174);
			this.btnCorteCaja.Name = "btnCorteCaja";
			this.btnCorteCaja.Size = new System.Drawing.Size(81, 23);
			this.btnCorteCaja.TabIndex = 18;
			this.btnCorteCaja.Text = "Corte de Caja";
			this.btnCorteCaja.UseVisualStyleBackColor = true;
			this.btnCorteCaja.Click += new System.EventHandler(this.BtnCorteCajaClick);
			// 
			// btnDeuda
			// 
			this.btnDeuda.Location = new System.Drawing.Point(809, 247);
			this.btnDeuda.Name = "btnDeuda";
			this.btnDeuda.Size = new System.Drawing.Size(75, 23);
			this.btnDeuda.TabIndex = 19;
			this.btnDeuda.Text = "Deuda";
			this.btnDeuda.UseVisualStyleBackColor = true;
			this.btnDeuda.Click += new System.EventHandler(this.BtnDeudaClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(810, 476);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 20;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.AutoSize = true;
			this.btnAgregar.Location = new System.Drawing.Point(739, 60);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(23, 23);
			this.btnAgregar.TabIndex = 21;
			this.btnAgregar.Text = "+";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnCredito
			// 
			this.btnCredito.Enabled = false;
			this.btnCredito.Location = new System.Drawing.Point(537, 439);
			this.btnCredito.Name = "btnCredito";
			this.btnCredito.Size = new System.Drawing.Size(75, 23);
			this.btnCredito.TabIndex = 22;
			this.btnCredito.Text = "Credito";
			this.btnCredito.UseVisualStyleBackColor = true;
			this.btnCredito.Click += new System.EventHandler(this.BtnCreditoClick);
			// 
			// btnCliente
			// 
			this.btnCliente.Location = new System.Drawing.Point(814, 314);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(75, 23);
			this.btnCliente.TabIndex = 23;
			this.btnCliente.Text = "Cliente";
			this.btnCliente.UseVisualStyleBackColor = true;
			this.btnCliente.Click += new System.EventHandler(this.BtnClienteClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(897, 511);
			this.Controls.Add(this.btnCliente);
			this.Controls.Add(this.btnCredito);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnDeuda);
			this.Controls.Add(this.btnCorteCaja);
			this.Controls.Add(this.btnInventario);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnPagar);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.btnEliminarProducto);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.dataGridViewProductos);
			this.Controls.Add(this.lblFecha);
			this.Name = "MainForm";
			this.Text = "ventaPHR";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCliente;
		private System.Windows.Forms.Button btnCredito;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnDeuda;
		private System.Windows.Forms.Button btnCorteCaja;
		private System.Windows.Forms.Button btnInventario;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnPagar;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Button btnEliminarProducto;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn existencia;
		private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn precio;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridView dataGridViewProductos;
		private System.Windows.Forms.Label lblFecha;
	}
}
