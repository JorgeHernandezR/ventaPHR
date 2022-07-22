﻿/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 19/07/2022
 * Time: 07:41 p. m.
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
	/// Description of Inventario.
	/// </summary>
	public partial class Inventario : Form
	{
		DataSet ds;
		public Inventario()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void llenarLista()
		{
			const string conexion = "server= localhost; userid=root ; password= ; database= ventaphr";
			var cnx = new MySqlConnection(conexion);
			cnx.Open();
			string sql = "SELECT id_producto,codigo_barras_producto,nombre_producto,precio_venta,precio_compra,existencia FROM `producto`ORDER BY nombre_producto;";
			var adaptador = new MySqlDataAdapter(sql,cnx);
			ds = new DataSet();
			adaptador.Fill(ds);		
			//MessageBox.Show(ds.Tables[0].Rows[0].ItemArray[0].ToString());
			cnx.Close();
			string patron = txtFiltro.Text;
			dataGridViewProductos.Rows.Clear();
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				if(ds.Tables[0].Rows[i].ItemArray[1].ToString().Contains(patron)|| ds.Tables[0].Rows[i].ItemArray[4].ToString().Contains(patron))
				{
					dataGridViewProductos.Rows.Add(ds.Tables[0].Rows[i].ItemArray);
					
				}
			
			
		
		
			}
		}
		void InventarioLoad(object sender, EventArgs e){
			llenarLista();
		}
	
		
		void BtnAltaClick(object sender, EventArgs e)
		{
			
		}
	}
}
