﻿/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 30/07/2022
 * Time: 07:31 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace ventaPHR
{
	/// <summary>
	/// Description of corteCaja.
	/// </summary>
	public partial class corteCaja : Form
	{
		public corteCaja()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//Seleccionar la fecha de hoy 
			var dateAndTime = DateTime.Now;
			var date= dateAndTime.Date.ToString("yyyy-MM-dd");
			lblFecha.Text= date;
			
			//llenarLista();
			//total();
			//totalGanancia();
			
		
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void llenarLista(string fecha)
		{
			//muestra de productos
			const string conexion = "server= localhost; userid=root ; password= ; database= ventaphr";
			MySqlConnection cnx = new MySqlConnection(conexion);
			cnx.Open();
			string sql = "SELECT producto.nombre_producto,producto.codigo_barras_producto,producto.precio_venta, producto.precio_compra, detalleventa.cantidad FROM producto INNER JOIN detalleventa on producto.id_producto = detalleventa.id_producto  INNER JOIN fechaventa ON detalleventa.id_venta = fechaventa.id_venta WHERE detalleventa.id_venta = fechaventa.id_venta AND fechaventa.fecha = '"+fecha+"' ORDER BY producto.nombre_producto;";
			MySqlDataAdapter adaptador = new MySqlDataAdapter(sql,cnx);
			DataSet ds = new DataSet();
			adaptador.Fill(ds);		
			cnx.Close();
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				
					dataGridViewProductos.Rows.Add(ds.Tables[0].Rows[i].ItemArray);
					
			}
		}
		public void total(string fecha)
		{
			const string conexion = "server= localhost; userid=root ; password= ; database= ventaphr";
			MySqlConnection cnx = new MySqlConnection(conexion);
			cnx.Open();
			string sql = "SELECT SUM(venta.total) from venta INNER JOIN fechaventa ON venta.id_venta = fechaventa.id_venta  WHERE fechaventa.fecha = '"+fecha+"';";
			MySqlDataAdapter adaptador = new MySqlDataAdapter(sql,cnx);
			DataSet ds = new DataSet();
			adaptador.Fill(ds);		
			cnx.Close();
			
			lblTotal.Text = "Total: "+ ds.Tables[0].Rows[0].ItemArray[0].ToString();
			
			
					
					
			
		}
		
		public void totalGanancia(string fecha )
		{
			const string conexion = "server= localhost; userid=root ; password= ; database= ventaphr";
			MySqlConnection cnx = new MySqlConnection(conexion);
			cnx.Open();
			string sql = "SELECT SUM(producto.precio_venta-producto.precio_compra) FROM producto INNER JOIN detalleventa on producto.id_producto = detalleventa.id_producto  INNER JOIN fechaventa ON detalleventa.id_venta = fechaventa.id_venta WHERE  fechaventa.fecha = '"+fecha+"';";
			MySqlDataAdapter adaptador = new MySqlDataAdapter(sql,cnx);
			DataSet ds = new DataSet();
			adaptador.Fill(ds);		
			cnx.Close();
			
			lblGanancia.Text = "Ganancia: "+ ds.Tables[0].Rows[0].ItemArray[0].ToString();
		}
		
		
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void DtpFechaValueChanged(object sender, EventArgs e)
		{
			dataGridViewProductos.Rows.Clear();
			llenarLista(dtpFecha.Value.Year.ToString()+"/"+dtpFecha.Value.Month.ToString()+"/"+dtpFecha.Value.Day.ToString());
			total(dtpFecha.Value.Year.ToString()+"/"+dtpFecha.Value.Month.ToString()+"/"+dtpFecha.Value.Day.ToString());
			totalGanancia(dtpFecha.Value.Year.ToString()+"/"+dtpFecha.Value.Month.ToString()+"/"+dtpFecha.Value.Day.ToString());
			
			
		}
	}
}
