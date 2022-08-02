/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 02/08/2022
 * Time: 01:55 p. m.
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
	/// Description of creditoCliente.
	/// </summary>
	public partial class creditoCliente : Form
	{
		static DataSet ds;
		static string datos1;
		static string fecha1;
		static string total1;
		static int venta;
		static DataGridView ds1;
		public creditoCliente()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void llenarLista(){
			const string conexion = "server= localhost; userid=root ; password= ; database= ventaphr";
			var cnx = new MySqlConnection(conexion);
			cnx.Open();
			string sql = "SELECT * FROM cliente ORDER BY nombre_cliente;";
			var adaptador = new MySqlDataAdapter(sql,cnx);
			ds = new DataSet();
			adaptador.Fill(ds);		
			//MessageBox.Show(ds.Tables[0].Rows[0].ItemArray[0].ToString());
			cnx.Close();
			dataGridViewCliente.Rows.Clear();
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				
					dataGridViewCliente.Rows.Add(ds.Tables[0].Rows[i].ItemArray);
			}
				
		}
		public creditoCliente(string total,string datos, string fecha, DataGridView ds){
			
			InitializeComponent();
			//lblTotal.Text = total;
			datos1 = datos;
			fecha1=fecha;
			total1= total;
			ds1=ds;
//			
//			//Conectar a base de datos para obtener el numero de venta
//			string conexion = "server = localhost; userid = root; password = ; database = ventaphr";
//				var cnx = new MySqlConnection(conexion);
//				cnx.Open();
//			string numeroVenta ="SELECT MAX(id_venta)+1 FROM venta ;";
//			MySqlDataAdapter adaptador = new MySqlDataAdapter(numeroVenta,cnx);
//			DataSet ds2 = new DataSet();
//			adaptador.Fill(ds2);
//			cnx.Close();
//			lblVenta.Text= "Venta: "+ ds2.Tables[0].Rows[0].ItemArray[0].ToString();
//			venta = int.Parse(ds2.Tables[0].Rows[0].ItemArray[0].ToString());
		
			
		}
		
		void CreditoClienteLoad(object sender, EventArgs e)
		{
			
			llenarLista();
		}
		
		void BtnAbonarClick(object sender, EventArgs e)
		{
			DialogResult btn = MessageBox.Show("Abonar a: "+dataGridViewCliente.Rows[0].Cells[1].Value.ToString(),"Atención",MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2);
			
			if(btn.Equals(DialogResult.Yes)){
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
			
		}
	}
}
