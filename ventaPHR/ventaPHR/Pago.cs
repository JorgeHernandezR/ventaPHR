/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 25/07/2022
 * Time: 08:59 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventaPHR
{
	/// <summary>
	/// Description of Pago.
	/// </summary>
	public partial class Pago : Form
	{
		public Pago()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public Pago(string total){
			InitializeComponent();
			lblTotal.Text = total;
		}
		
		void TxtEfectivoTextChanged(object sender, EventArgs e)
		{
			
			double total = Convert.ToDouble(lblTotal.Text.Substring(8));
			
			double efectivo = Convert.ToDouble(txtEfectivo.Text);
			double cambio = total - efectivo;
			lblVuelto.Text = cambio.ToString("c");
		}
	}
}
