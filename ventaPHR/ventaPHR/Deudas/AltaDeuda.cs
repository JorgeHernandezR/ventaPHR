/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 09/08/2022
 * Time: 10:19 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace ventaPHR
{
	/// <summary>
	/// Description of AltaDeuda.
	/// </summary>
	public partial class AltaDeuda : Form
	{
	static DataSet ds;
	int bandera = 0;
		public AltaDeuda()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			var dateAndTime = DateTime.Now;
			var date= dateAndTime.Date.ToString("yyyy-MM-dd");	

			lblFecha.Text=date;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public AltaDeuda(string nombre,string precio,int band){
			InitializeComponent();
			txtNombreCliente.Text = nombre;
			txtTotal.Text = precio;
			bandera= band;
		}
		
		void conexionDatabase(string sql){
			string conexion = "server = localhost; userid = root; password = ; database = ventaphr";
				var cnx = new MySqlConnection(conexion);
				cnx.Open();
				MySqlCommand comando = new MySqlCommand(sql,cnx);
			comando.ExecuteNonQuery();
			cnx.Close();
		}
		
		
		void BtnAgregarClienteClick(object sender, EventArgs e)
		{
			Cliente ventanaCliente = new Cliente(txtNombreCliente, 1);
			ventanaCliente.ShowDialog();
//			AltaCliente ventanaAgregarCliente = new AltaCliente();
//			ventanaAgregarCliente.ShowDialog();
//			const string conexion = "server= localhost; userid=root ; password= ; database= ventaphr";
//			var cnx = new MySqlConnection(conexion);
//			cnx.Open();
//			string consulta = "SELECT nombre_cliente, id_cliente FROM cliente WHERE id_cliente = (SELECT MAX(id_cliente) FROM cliente);";
//			var adaptador = new MySqlDataAdapter(consulta,cnx);
//
//			 ds = new DataSet();
//			 adaptador.Fill(ds);	
//			 txtNombreCliente.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
			
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			int totales=0 ;
			string fecha = lblFecha.Text.ToString();
			string precio = txtTotal.Text.ToString().Trim();
			MessageBox.Show(fecha);
			
			string sqlVenta = "INSERT INTO `credito` (`id_credito`, `fecha`, `id_usuario`) VALUES (DEFAULT, '"+fecha+"' ,1);";
				conexionDatabase(sqlVenta);
				
				
				
			
	for (int i = 0; i <dataGridViewProductosDeuda.Rows.Count-1; i++) {
					totales += int.Parse(dataGridViewProductosDeuda.Rows[i].Cells[2].Value.ToString());
				
			string conexion2 = "server = localhost; userid = root; password = ; database = ventaphr";
				var cnx2 = new MySqlConnection(conexion2);
				cnx2.Open();
				string sqlDetalleVenta = "INSERT INTO `productodeuda` (`id_credito`, `nombre`, `cantidad`, `precio`) VALUES ((SELECT MAX(id_credito) FROM credito) , '"+dataGridViewProductosDeuda.Rows[i].Cells[1].Value.ToString()+"', 1, "+dataGridViewProductosDeuda.Rows[i].Cells[2].Value.ToString()+");";
			MySqlCommand comando2 = new MySqlCommand(sqlDetalleVenta,cnx2);
			comando2.ExecuteNonQuery();
			cnx2.Close();
			
			   }
				string sqlFechaVenta = "INSERT INTO `creditocliente`(`id_credito`, `id_cliente`, `total`, `totalIva`) VALUES ((SELECT MAX(id_credito) FROM credito) ,'"+ds.Tables[0].Rows[0].ItemArray[1].ToString()+"',"+totales+",total*0.05);";
				conexionDatabase(sqlFechaVenta);
			
			

			
			
			
		}
			
			
		}
	}



