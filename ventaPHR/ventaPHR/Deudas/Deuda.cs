/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 01/08/2022
 * Time: 10:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace ventaPHR
{
	/// <summary>
	/// Description of Deuda.
	/// </summary>
	
	public partial class Deuda : Form
	{
		static DataSet ds;
		public Deuda()
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
			string sql = " SELECT cliente.id_cliente,cliente.nombre_cliente, SUM(creditocliente.total),SUM(creditocliente.total*0.05) FROM cliente INNER JOIN creditocliente ON cliente.id_cliente = creditocliente.id_cliente ORDER BY cliente.nombre_cliente;";
			var adaptador = new MySqlDataAdapter(sql,cnx);
			ds = new DataSet();
			adaptador.Fill(ds);		
			//MessageBox.Show(ds.Tables[0].Rows[0].ItemArray[0].ToString());
			cnx.Close();
			string patron = txtFiltro.Text;
			dataGridViewDeuda.Rows.Clear();
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				if(ds.Tables[0].Rows[i].ItemArray[0].ToString().Contains(patron))
				{
					dataGridViewDeuda.Rows.Add(ds.Tables[0].Rows[i].ItemArray);
					
				}
			
			
		
		
			}
		}
		
		void DeudaLoad(object sender, EventArgs e)
		{
			llenarLista();
		}
		
		void TxtFiltroTextChanged(object sender, EventArgs e)
		{
			llenarLista();
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnConsultarClick(object sender, EventArgs e)
		{
			string idCliente = dataGridViewDeuda.Rows[0].Cells[0].Value.ToString();
			consultarDeuda ventanaConsultarDeuda = new consultarDeuda(idCliente);
			ventanaConsultarDeuda.ShowDialog();
			
			
			
		}
	}
}
