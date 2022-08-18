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
		void conexionDatabase(string sql){
			string conexion = "server = localhost; userid = root; password = ; database = ventaphr";
				var cnx = new MySqlConnection(conexion);
				cnx.Open();
				MySqlCommand comando = new MySqlCommand(sql,cnx);
			comando.ExecuteNonQuery();
			cnx.Close();
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
			MessageBox.Show(total1+"");
			ds1=ds;

			
		}
		
		void CreditoClienteLoad(object sender, EventArgs e)
		{
			
			llenarLista();
		}
		
		void BtnAbonarClick(object sender, EventArgs e)
		{
			DialogResult btn = MessageBox.Show("Abonar a: "+dataGridViewCliente.SelectedRows[0].Cells[1].Value.ToString(),"Atención",MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2);
			
			if(btn.Equals(DialogResult.Yes)){
				string sqlVenta = "INSERT INTO `credito` (`id_credito`, `fecha`, `id_usuario`) VALUES (NULL, '"+fecha1+"' , 1);";
				conexionDatabase(sqlVenta);
				string sqlFechaVenta = "INSERT INTO `creditocliente`(`id_credito`, `id_cliente`, `total`, `totalIva`) VALUES ((SELECT MAX(id_credito) FROM credito) ,'"+dataGridViewCliente.SelectedRows[0].Cells[0].Value.ToString()+"',"+total1.Substring(8)+",total*0.05);";
				conexionDatabase(sqlFechaVenta);
				
				
			
	for (int i = 0; i <ds1.Rows.Count; i++) {
				
			string conexion2 = "server = localhost; userid = root; password = ; database = ventaphr";
				var cnx2 = new MySqlConnection(conexion2);
				cnx2.Open();
				string sqlDetalleVenta = "INSERT INTO `productodeuda` (`id_credito`, `nombre`, `cantidad`, `precio`) VALUES ((SELECT MAX(id_credito) FROM credito) , '"+ds1.Rows[i].Cells[1].Value.ToString()+"', 1, '"+ds1.Rows[i].Cells[2].Value.ToString()+"');";
			MySqlCommand comando2 = new MySqlCommand(sqlDetalleVenta,cnx2);
			comando2.ExecuteNonQuery();
			cnx2.Close();
			
			   }
			
		}
	}
		
		void BtnAgregarClienteClick(object sender, EventArgs e)
		{
			
		}
}
}
