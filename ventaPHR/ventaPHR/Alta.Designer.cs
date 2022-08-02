/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 20/07/2022
 * Time: 05:24 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ventaPHR
{
	partial class Alta
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCodigoBarras = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtPrecioCompra = new System.Windows.Forms.TextBox();
			this.txtPrecioVenta = new System.Windows.Forms.TextBox();
			this.txtExistencia = new System.Windows.Forms.TextBox();
			this.btnSalirAlta = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(76, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "PRODUCTO NUEVO ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Codigo de barras:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nombre:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Precio compra:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 177);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Precio venta:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 214);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Existencia:";
			// 
			// txtCodigoBarras
			// 
			this.txtCodigoBarras.Location = new System.Drawing.Point(123, 42);
			this.txtCodigoBarras.Name = "txtCodigoBarras";
			this.txtCodigoBarras.Size = new System.Drawing.Size(161, 20);
			this.txtCodigoBarras.TabIndex = 6;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(123, 87);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(161, 20);
			this.txtNombre.TabIndex = 7;
			// 
			// txtPrecioCompra
			// 
			this.txtPrecioCompra.Location = new System.Drawing.Point(123, 135);
			this.txtPrecioCompra.Name = "txtPrecioCompra";
			this.txtPrecioCompra.Size = new System.Drawing.Size(161, 20);
			this.txtPrecioCompra.TabIndex = 8;
			// 
			// txtPrecioVenta
			// 
			this.txtPrecioVenta.Location = new System.Drawing.Point(123, 174);
			this.txtPrecioVenta.Name = "txtPrecioVenta";
			this.txtPrecioVenta.Size = new System.Drawing.Size(161, 20);
			this.txtPrecioVenta.TabIndex = 9;
			// 
			// txtExistencia
			// 
			this.txtExistencia.Location = new System.Drawing.Point(123, 214);
			this.txtExistencia.Name = "txtExistencia";
			this.txtExistencia.Size = new System.Drawing.Size(161, 20);
			this.txtExistencia.TabIndex = 10;
			// 
			// btnSalirAlta
			// 
			this.btnSalirAlta.Location = new System.Drawing.Point(209, 264);
			this.btnSalirAlta.Name = "btnSalirAlta";
			this.btnSalirAlta.Size = new System.Drawing.Size(75, 23);
			this.btnSalirAlta.TabIndex = 11;
			this.btnSalirAlta.Text = "Salir";
			this.btnSalirAlta.UseVisualStyleBackColor = true;
			this.btnSalirAlta.Click += new System.EventHandler(this.BtnSalirAltaClick);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(28, 264);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 23);
			this.btnGuardar.TabIndex = 12;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// Alta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(310, 304);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnSalirAlta);
			this.Controls.Add(this.txtExistencia);
			this.Controls.Add(this.txtPrecioVenta);
			this.Controls.Add(this.txtPrecioCompra);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtCodigoBarras);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Alta";
			this.Text = "Alta";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnSalirAlta;
		private System.Windows.Forms.TextBox txtExistencia;
		private System.Windows.Forms.TextBox txtPrecioVenta;
		private System.Windows.Forms.TextBox txtPrecioCompra;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtCodigoBarras;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
		
	}
}
