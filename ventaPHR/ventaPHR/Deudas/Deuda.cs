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
		string fecha;
		public Deuda()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
				var dateAndTime = DateTime.Now;
			var date= dateAndTime.Date.ToString("yyyy-MM-dd");
			fecha = date.ToString();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void llenarLista(){
			const string conexion = "server= localhost; userid=root ; password= ; database= ventaphr";
			var cnx = new MySqlConnection(conexion);
			cnx.Open();
			string sql = "SELECT creditocliente.id_credito,cliente.id_cliente,cliente.nombre_cliente,  SUM(productodeuda.precio), ROUND(SUM(productodeuda.precio)+SUM(productodeuda.precio)*0.05) FROM  cliente INNER JOIN creditocliente ON cliente.id_cliente = creditocliente.id_cliente INNER JOIN productodeuda on creditocliente.id_credito = productodeuda.id_credito GROUP BY cliente.nombre_cliente ORDER BY cliente.nombre_cliente;";
			var adaptador = new MySqlDataAdapter(sql,cnx);
			ds = new DataSet();
			adaptador.Fill(ds);		
			//MessageBox.Show(ds.Tables[0].Rows[0].ItemArray[0].ToString());
			cnx.Close();
			string patron = txtFiltro.Text;
			dataGridViewDeuda.Rows.Clear();
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				if(ds.Tables[0].Rows[i].ItemArray[1].ToString().Contains(patron))
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
			string idCliente = dataGridViewDeuda.SelectedRows[0].Cells[1].Value.ToString();
			consultarDeuda ventanaConsultarDeuda = new consultarDeuda(idCliente,dataGridViewDeuda.SelectedRows[0].Cells[1].Value.ToString());
			ventanaConsultarDeuda.ShowDialog();
			llenarLista();
			
			
		}
		
		void BtnAltaClick(object sender, EventArgs e)
		{
			AltaDeuda ventanaAltaDeuda = new AltaDeuda();
			ventanaAltaDeuda.ShowDialog();
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			string id = dataGridViewDeuda.SelectedRows[0].Cells[0].Value.ToString();
			MessageBox.Show(id+"");
			DialogResult opcion = MessageBox.Show("Estas seguro de eliminar la deuda de: "+dataGridViewDeuda.SelectedRows[0].Cells[1].Value.ToString(),"Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2);
			if(opcion.Equals(DialogResult.Yes)){
			   	string conexion = "server = localhost; userid = root; password = ; database = ventaphr";
				var cnx = new MySqlConnection(conexion);
				cnx.Open();
				string sqlMod = "DELETE FROM `credito` WHERE id_credito = '"+id+"';";
				MySqlCommand comando = new MySqlCommand(sqlMod,cnx);
				comando.ExecuteNonQuery();
				cnx.Close();
				MessageBox.Show("Producto Eliminado satisfactoriamente","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);
				
			   }
			llenarLista();
			
			
		}
		void conexionDatabase(string sql){
			string conexion = "server = localhost; userid = root; password = ; database = ventaphr";
				var cnx = new MySqlConnection(conexion);
				cnx.Open();
				MySqlCommand comando = new MySqlCommand(sql,cnx);
			comando.ExecuteNonQuery();
			cnx.Close();
		}
		
		
		void BtnPagarClick(object sender, EventArgs e)
		{
			DialogResult result=MessageBox.Show("Está a punto de pagar la deuda de: "+dataGridViewDeuda.SelectedRows[0].Cells[2].Value.ToString()+" Total: $"+dataGridViewDeuda.SelectedRows[0].Cells[3].Value.ToString(),"Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2);
			
			if(result==DialogResult.Yes)
			{
				string sqlVenta = "INSERT INTO `ventaabono`(`id_ventaExtra`, `monto`, `fecha`) VALUES (Default,'"+dataGridViewDeuda.SelectedRows[0].Cells[4].Value.ToString()+"','"+fecha+"')";
				conexionDatabase(sqlVenta);
				string sqlEliminar = "DELETE FROM `credito` WHERE id_credito='"+dataGridViewDeuda.SelectedRows[0].Cells[0].Value.ToString()+"';";
				conexionDatabase(sqlEliminar);
				MessageBox.Show("Pago realizado con exito");
				llenarLista();
			}
			                                 
		}
	}
}
