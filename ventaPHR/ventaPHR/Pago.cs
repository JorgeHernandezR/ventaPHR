﻿/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 25/07/2022
 * Time: 08:59 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ventaPHR
{
	/// <summary>
	/// Description of Pago.
	/// </summary>
	public partial class Pago : Form
	{
		static string datos1;
		static string fecha1;
		static string total1;
		static int venta;
		static DataGridView ds1;
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
		public Pago(string total,string datos, string fecha, DataGridView ds){
			
			InitializeComponent();
			lblTotal.Text = total;
			datos1 = datos;
			fecha1=fecha;
			total1= total;
			ds1=ds;
			
			//Conectar a base de datos para obtener el numero de venta
			string conexion = "server = localhost; userid = root; password = ; database = ventaphr";
				var cnx = new MySqlConnection(conexion);
				cnx.Open();
			string numeroVenta ="SELECT MAX(id_venta)+1 FROM venta ;";
			MySqlDataAdapter adaptador = new MySqlDataAdapter(numeroVenta,cnx);
			DataSet ds2 = new DataSet();
			adaptador.Fill(ds2);
			cnx.Close();
			lblVenta.Text= "Venta: "+ ds2.Tables[0].Rows[0].ItemArray[0].ToString();
			venta = int.Parse(ds2.Tables[0].Rows[0].ItemArray[0].ToString());
		
			
		}
		void conexionDatabase(string sql){
			string conexion = "server = localhost; userid = root; password = ; database = ventaphr";
				var cnx = new MySqlConnection(conexion);
				cnx.Open();
				MySqlCommand comando = new MySqlCommand(sql,cnx);
			comando.ExecuteNonQuery();
			cnx.Close();
		}
		
		void TxtEfectivoTextChanged(object sender, EventArgs e)
		{
			
			double total = Convert.ToDouble(lblTotal.Text.Substring(8));
			double efectivo = Convert.ToDouble(txtEfectivo.Text);
			double cambio = total - efectivo;
			if (efectivo < total) {
				lblEtiqueta.Text= "Falta :";
				lblVuelto.Text = cambio.ToString();
			}if (efectivo > total) {
				lblEtiqueta.Text= "Vuelto :";
					lblVuelto.Text = cambio.ToString().Replace('-',' ');
			} else {
				lblEtiqueta.Text= "Vuelto :";
					lblVuelto.Text = cambio.ToString();
			}
			
			btnPagar.Enabled = true;
			
		}
		
		void BtnPagarClick(object sender, EventArgs e)
		{
				
			string sqlVenta = "INSERT INTO `venta`(`id_venta`, `total`) VALUES (NULL,'"+total1.Substring(8)+"'); ";
				conexionDatabase(sqlVenta);
				string sqlFechaVenta = "INSERT INTO `fechaventa`(`id_usuario`, `id_venta`, `fecha`) VALUES ('1',"+venta+",'"+fecha1+"');";
				conexionDatabase(sqlFechaVenta);
				
				
			
	for (int i = 0; i <ds1.Rows.Count; i++) {
				
			string conexion2 = "server = localhost; userid = root; password = ; database = ventaphr";
				var cnx2 = new MySqlConnection(conexion2);
				cnx2.Open();
				string sqlDetalleVenta = "INSERT INTO `detalleventa` (`id_venta`, `id_producto`, `cantidad`) VALUES ("+venta+", '"+ds1.Rows[i].Cells[0].Value+"', '"+ds1.Rows[i].Cells[3].Value+"') ;";
			MySqlCommand comando2 = new MySqlCommand(sqlDetalleVenta,cnx2);
			comando2.ExecuteNonQuery();
			cnx2.Close();
			
			
			
			
		}
				
			MessageBox.Show("Pago realizado con exito","Alerta", MessageBoxButtons.OK,MessageBoxIcon.Information);
			this.Close();
			

// ESTO LO OCUPARE DESPUES
// SELECT fechaventa.fecha, SUM(venta.total) from venta INNER JOIN fechaventa ON venta.id_venta = fechaventa.id_venta  WHERE fechaventa.fecha = 2022-07-28;
 
			
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
			
		}
	}
}
