﻿/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 10/07/2022
 * Time: 03:49 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;


namespace ventaPHR
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>a2
	public partial class MainForm : Form
	{
		static byte rol=0;
		float total=0;
		static Login l = new Login();
		static Buscar ventanaBuscar= new Buscar();
		static Inventario ventanaInventario = new Inventario();
			
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			l.ShowDialog();
			InitializeComponent();
			//Obtener fecha 
			var dateAndTime = DateTime.Now;
			var date= dateAndTime.Date.ToString("dd-MM-yyyy");
			lblFecha.Text=date;
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
			
			
		}
		public void agregarProducto(string codigo)
		{
			const string conexion = "server= localhost; userid=root ; password= ; database= ventaphr";
			MySqlConnection cnx = new MySqlConnection(conexion);
			cnx.Open();
			string sql = "SELECT id_producto,nombre_producto, precio_venta,1 AS cantidad,codigo_barras_producto,existencia FROM producto WHERE codigo_barras_producto = '"+codigo+ "'";
			MySqlDataAdapter adaptador = new MySqlDataAdapter(sql,cnx);
			DataSet ds = new DataSet();
			adaptador.Fill(ds);		
			//MessageBox.Show(ds.Tables[0].Rows[0].ItemArray[0].ToString());
			cnx.Close();
			int existencias;
			
			
			if(btnEliminarProducto.Enabled==false){
				btnEliminarProducto.Enabled=true;
			}
			if(txtCantidad.Text=="")
			{
			
			
			if(ds.Tables[0].Rows.Count == 1)
			{
				existencias=int.Parse( ds.Tables[0].Rows[0].ItemArray[5].ToString());
				
				for(int i= 0; i<dataGridViewProductos.Rows.Count;i++)
				{
					if(dataGridViewProductos.Rows[i].Cells[4].Value.ToString() == txtCodigo.Text)
					   existencias--;
						
					}
					if(existencias>0)
					{
						dataGridViewProductos.Rows.Add(ds.Tables[0].Rows[0].ItemArray);
						total += float.Parse(ds.Tables[0].Rows[0].ItemArray[2].ToString());
						lblTotal.Text="Total: "+total.ToString("c");
						txtCodigo.Clear();
				
					}else{
						MessageBox.Show("No hay existencias");
					}
					
					
					
			}else{
				MessageBox.Show("Codigo no localizado");
			}
			}else{
				string precio = txtCantidad.Text;
				string sql2 = "SELECT id_producto,nombre_producto, precio_venta,1 AS cantidad,codigo_barras_producto,existencia FROM producto WHERE codigo_barras_producto = '"+codigo+ "'";
			MySqlDataAdapter adaptador2 = new MySqlDataAdapter(sql2,cnx);
			DataSet ds2 = new DataSet();
			adaptador.Fill(ds2);		
			//MessageBox.Show(ds.Tables[0].Rows[0].ItemArray[0].ToString());
			cnx.Close();
			dataGridViewProductos.Rows.Add(ds.Tables[0].Rows[0].ItemArray[0].ToString(),ds.Tables[0].Rows[0].ItemArray[1].ToString(),precio);
			
				}
				
			
		}
	
		
		
		
		void BtnBuscarClick(object sender, EventArgs e)
		{
		
			ventanaBuscar.ShowDialog();
		}
		
		void BtnInventarioClick(object sender, EventArgs e)
		{
			ventanaInventario.ShowDialog();
			
		}
		
		
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			agregarProducto(txtCodigo.Text);
		}
		
		void TxtCodigoKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyData == Keys.Enter)
			{
				BtnAgregarClick(null,null);
			}
		}
	}
}
