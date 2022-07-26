/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 25/07/2022
 * Time: 08:59 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ventaPHR
{
	partial class Pago
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
			this.lblTotal = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtEfectivo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblVuelto = new System.Windows.Forms.Label();
			this.btnPagar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTotal
			// 
			this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(66, 9);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(158, 31);
			this.lblTotal.TabIndex = 9;
			this.lblTotal.Text = "Total: $0.00";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Recibo: ";
			// 
			// txtEfectivo
			// 
			this.txtEfectivo.Location = new System.Drawing.Point(65, 71);
			this.txtEfectivo.Name = "txtEfectivo";
			this.txtEfectivo.Size = new System.Drawing.Size(100, 20);
			this.txtEfectivo.TabIndex = 11;
			this.txtEfectivo.TextChanged += new System.EventHandler(this.TxtEfectivoTextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(184, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Vuelto:";
			// 
			// lblVuelto
			// 
			this.lblVuelto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblVuelto.AutoSize = true;
			this.lblVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVuelto.Location = new System.Drawing.Point(230, 60);
			this.lblVuelto.Name = "lblVuelto";
			this.lblVuelto.Size = new System.Drawing.Size(82, 31);
			this.lblVuelto.TabIndex = 13;
			this.lblVuelto.Text = "$0.00";
			// 
			// btnPagar
			// 
			this.btnPagar.Enabled = false;
			this.btnPagar.Location = new System.Drawing.Point(12, 134);
			this.btnPagar.Name = "btnPagar";
			this.btnPagar.Size = new System.Drawing.Size(75, 23);
			this.btnPagar.TabIndex = 14;
			this.btnPagar.Text = "Pagar";
			this.btnPagar.UseVisualStyleBackColor = true;
			this.btnPagar.Click += new System.EventHandler(this.BtnPagarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(237, 134);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 15;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// Pago
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(367, 179);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnPagar);
			this.Controls.Add(this.lblVuelto);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtEfectivo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTotal);
			this.Name = "Pago";
			this.Text = "Pago";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnPagar;
		private System.Windows.Forms.Label lblVuelto;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEfectivo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblTotal;
	}
}
