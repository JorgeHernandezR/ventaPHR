/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 02/08/2022
 * Time: 01:55 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ventaPHR
{
	partial class creditoCliente
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
			this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
			this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAgregarCliente = new System.Windows.Forms.Button();
			this.btnAbonar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewCliente
			// 
			this.dataGridViewCliente.AllowUserToAddRows = false;
			this.dataGridViewCliente.AllowUserToDeleteRows = false;
			this.dataGridViewCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.idCliente,
									this.nombreCliente,
									this.telefonoCliente});
			this.dataGridViewCliente.Location = new System.Drawing.Point(12, 12);
			this.dataGridViewCliente.MultiSelect = false;
			this.dataGridViewCliente.Name = "dataGridViewCliente";
			this.dataGridViewCliente.ReadOnly = true;
			this.dataGridViewCliente.RowHeadersVisible = false;
			this.dataGridViewCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewCliente.Size = new System.Drawing.Size(384, 300);
			this.dataGridViewCliente.TabIndex = 0;
			// 
			// idCliente
			// 
			this.idCliente.HeaderText = "ID";
			this.idCliente.Name = "idCliente";
			this.idCliente.ReadOnly = true;
			this.idCliente.Visible = false;
			// 
			// nombreCliente
			// 
			this.nombreCliente.HeaderText = "Nombre";
			this.nombreCliente.Name = "nombreCliente";
			this.nombreCliente.ReadOnly = true;
			// 
			// telefonoCliente
			// 
			this.telefonoCliente.HeaderText = "Telefono";
			this.telefonoCliente.Name = "telefonoCliente";
			this.telefonoCliente.ReadOnly = true;
			// 
			// btnAgregarCliente
			// 
			this.btnAgregarCliente.Location = new System.Drawing.Point(475, 12);
			this.btnAgregarCliente.Name = "btnAgregarCliente";
			this.btnAgregarCliente.Size = new System.Drawing.Size(75, 23);
			this.btnAgregarCliente.TabIndex = 1;
			this.btnAgregarCliente.Text = "Agregar";
			this.btnAgregarCliente.UseVisualStyleBackColor = true;
			// 
			// btnAbonar
			// 
			this.btnAbonar.Location = new System.Drawing.Point(475, 68);
			this.btnAbonar.Name = "btnAbonar";
			this.btnAbonar.Size = new System.Drawing.Size(75, 23);
			this.btnAbonar.TabIndex = 2;
			this.btnAbonar.Text = "Abonar";
			this.btnAbonar.UseVisualStyleBackColor = true;
			this.btnAbonar.Click += new System.EventHandler(this.BtnAbonarClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(475, 289);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 3;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			// 
			// creditoCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(572, 331);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnAbonar);
			this.Controls.Add(this.btnAgregarCliente);
			this.Controls.Add(this.dataGridViewCliente);
			this.Name = "creditoCliente";
			this.Text = "creditoCliente";
			this.Load += new System.EventHandler(this.CreditoClienteLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnAbonar;
		private System.Windows.Forms.Button btnAgregarCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefonoCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
		private System.Windows.Forms.DataGridView dataGridViewCliente;
	}
}
