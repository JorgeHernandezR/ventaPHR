/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 04/08/2022
 * Time: 04:07 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ventaPHR
{
	partial class Cliente
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
			this.btnAlta = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
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
			this.dataGridViewCliente.Location = new System.Drawing.Point(12, 24);
			this.dataGridViewCliente.MultiSelect = false;
			this.dataGridViewCliente.Name = "dataGridViewCliente";
			this.dataGridViewCliente.ReadOnly = true;
			this.dataGridViewCliente.RowHeadersVisible = false;
			this.dataGridViewCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewCliente.Size = new System.Drawing.Size(384, 300);
			this.dataGridViewCliente.TabIndex = 1;
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
			// btnAlta
			// 
			this.btnAlta.Location = new System.Drawing.Point(433, 24);
			this.btnAlta.Name = "btnAlta";
			this.btnAlta.Size = new System.Drawing.Size(75, 23);
			this.btnAlta.TabIndex = 2;
			this.btnAlta.Text = "Alta";
			this.btnAlta.UseVisualStyleBackColor = true;
			this.btnAlta.Click += new System.EventHandler(this.BtnAltaClick);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(433, 81);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(75, 23);
			this.btnModificar.TabIndex = 3;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(433, 135);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 4;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(433, 301);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// Cliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 348);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnAlta);
			this.Controls.Add(this.dataGridViewCliente);
			this.Name = "Cliente";
			this.Text = "Cliente";
			this.Load += new System.EventHandler(this.ClienteLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnAlta;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefonoCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
		private System.Windows.Forms.DataGridView dataGridViewCliente;
	}
}
