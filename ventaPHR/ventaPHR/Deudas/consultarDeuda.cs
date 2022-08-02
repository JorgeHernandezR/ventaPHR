/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 02/08/2022
 * Time: 12:57 p. m.
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

namespace ventaPHR
{
	/// <summary>
	/// Description of consultarDeuda.
	/// </summary>
	public partial class consultarDeuda : Form
	{
		static DataSet ds; 
		public consultarDeuda()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
					
				
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void llenarLista(string id){
			const string conexion = "server= localhost; userid=root ; password= ; database= ventaphr";
			var cnx = new MySqlConnection(conexion);
			cnx.Open();
			string sql = "SELECT productodeuda.cantidad, productodeuda.nombre, productodeuda.precio,credito.fecha, creditocliente.id_cliente FROM productodeuda INNER JOIN creditocliente on productodeuda.id_credito= creditocliente.id_credito INNER JOIN credito on creditocliente.id_credito = credito.id_credito WHERE creditocliente.id_cliente= "+id+" ORDER BY credito.fecha; "; 
			var adaptador = new MySqlDataAdapter(sql,cnx);
			ds = new DataSet();
			adaptador.Fill(ds);		
			//MessageBox.Show(ds.Tables[0].Rows[0].ItemArray[0].ToString());
			cnx.Close();
			
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				
					dataGridViewProductosDeuda.Rows.Add(ds.Tables[0].Rows[i].ItemArray);
			
		}
		}
		
		
		
		
		
		public consultarDeuda(string id)
		{
			InitializeComponent();
			llenarLista(id);
			
	}
}
}

