/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 01/08/2022
 * Time: 10:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ventaPHR
{
	partial class Deuda
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
			this.dataGridViewDeuda = new System.Windows.Forms.DataGridView();
			this.btnPagar = new System.Windows.Forms.Button();
			this.btnAbonar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnAlta = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.txtFiltro = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.idCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeuda)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewDeuda
			// 
			this.dataGridViewDeuda.AllowUserToAddRows = false;
			this.dataGridViewDeuda.AllowUserToDeleteRows = false;
			this.dataGridViewDeuda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewDeuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDeuda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.idCredito,
									this.id_cliente,
									this.nombre,
									this.total,
									this.totalIva});
			this.dataGridViewDeuda.Location = new System.Drawing.Point(12, 59);
			this.dataGridViewDeuda.MultiSelect = false;
			this.dataGridViewDeuda.Name = "dataGridViewDeuda";
			this.dataGridViewDeuda.ReadOnly = true;
			this.dataGridViewDeuda.RowHeadersVisible = false;
			this.dataGridViewDeuda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewDeuda.Size = new System.Drawing.Size(297, 392);
			this.dataGridViewDeuda.TabIndex = 0;
			// 
			// btnPagar
			// 
			this.btnPagar.Location = new System.Drawing.Point(353, 275);
			this.btnPagar.Name = "btnPagar";
			this.btnPagar.Size = new System.Drawing.Size(75, 23);
			this.btnPagar.TabIndex = 1;
			this.btnPagar.Text = "Pagar";
			this.btnPagar.UseVisualStyleBackColor = true;
			this.btnPagar.Click += new System.EventHandler(this.BtnPagarClick);
			// 
			// btnAbonar
			// 
			this.btnAbonar.Location = new System.Drawing.Point(353, 318);
			this.btnAbonar.Name = "btnAbonar";
			this.btnAbonar.Size = new System.Drawing.Size(75, 23);
			this.btnAbonar.TabIndex = 2;
			this.btnAbonar.Text = "Abonar";
			this.btnAbonar.UseVisualStyleBackColor = true;
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(353, 441);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 3;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnAlta
			// 
			this.btnAlta.Location = new System.Drawing.Point(353, 122);
			this.btnAlta.Name = "btnAlta";
			this.btnAlta.Size = new System.Drawing.Size(75, 23);
			this.btnAlta.TabIndex = 4;
			this.btnAlta.Text = "Agregar";
			this.btnAlta.UseVisualStyleBackColor = true;
			this.btnAlta.Click += new System.EventHandler(this.BtnAltaClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(353, 176);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 5;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// txtFiltro
			// 
			this.txtFiltro.Location = new System.Drawing.Point(64, 26);
			this.txtFiltro.Name = "txtFiltro";
			this.txtFiltro.Size = new System.Drawing.Size(215, 20);
			this.txtFiltro.TabIndex = 15;
			this.txtFiltro.TextChanged += new System.EventHandler(this.TxtFiltroTextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Filtro:";
			// 
			// btnConsultar
			// 
			this.btnConsultar.Location = new System.Drawing.Point(353, 59);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(75, 23);
			this.btnConsultar.TabIndex = 16;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.BtnConsultarClick);
			// 
			// idCredito
			// 
			this.idCredito.HeaderText = "IDcredito";
			this.idCredito.Name = "idCredito";
			this.idCredito.ReadOnly = true;
			// 
			// id_cliente
			// 
			this.id_cliente.HeaderText = "Id";
			this.id_cliente.Name = "id_cliente";
			this.id_cliente.ReadOnly = true;
			// 
			// nombre
			// 
			this.nombre.HeaderText = "Nombre";
			this.nombre.Name = "nombre";
			this.nombre.ReadOnly = true;
			// 
			// total
			// 
			this.total.HeaderText = "Total";
			this.total.Name = "total";
			this.total.ReadOnly = true;
			// 
			// totalIva
			// 
			this.totalIva.HeaderText = "Total+IVA";
			this.totalIva.Name = "totalIva";
			this.totalIva.ReadOnly = true;
			// 
			// Deuda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(451, 476);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.txtFiltro);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnAlta);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnAbonar);
			this.Controls.Add(this.btnPagar);
			this.Controls.Add(this.dataGridViewDeuda);
			this.Name = "Deuda";
			this.Text = "Deuda";
			this.Load += new System.EventHandler(this.DeudaLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeuda)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn idCredito;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalIva;
		private System.Windows.Forms.DataGridViewTextBoxColumn total;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFiltro;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnAlta;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnAbonar;
		private System.Windows.Forms.Button btnPagar;
		private System.Windows.Forms.DataGridView dataGridViewDeuda;
	}
}
