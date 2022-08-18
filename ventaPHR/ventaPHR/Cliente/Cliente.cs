/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 04/08/2022
 * Time: 04:07 p. m.
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
	/// Description of Cliente.
	/// </summary>
	public partial class Cliente : Form
	{
		DataSet ds;
		TextBox texto; 
		int band = 0;
		
		public Cliente()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public Cliente(TextBox text, int numero){
			this.texto = text;
			band = numero;
			InitializeComponent();
			
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
		
		void ClienteLoad(object sender, EventArgs e)
		{
			llenarLista();
		}
		
		void BtnAltaClick(object sender, EventArgs e)
		{
			AltaCliente ventanaAltaCliente = new AltaCliente();
			ventanaAltaCliente.ShowDialog();
			llenarLista();
		}
		
		void BtnModificarClick(object sender, EventArgs e)
		{
			AltaCliente ventanAltaCliente = new AltaCliente(dataGridViewCliente.SelectedRows[0].Cells[1].Value.ToString(),dataGridViewCliente.SelectedRows[0].Cells[2].Value.ToString());
			ventanAltaCliente.ShowDialog();
			llenarLista();
			
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			string cliente = dataGridViewCliente.SelectedRows[0].Cells[1].Value.ToString();
			DialogResult opcion = MessageBox.Show("Estas seguro de eliminar a este cliente: "+cliente,"ALERTA",MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2);
			if(opcion.Equals(DialogResult.Yes)){
			   	string conexion = "server = localhost; userid = root; password = ; database = ventaphr";
				var cnx = new MySqlConnection(conexion);
				cnx.Open();
				string sqlMod = "DELETE FROM cliente WHERE nombre_cliente = '"+cliente+"';";
				MySqlCommand comando = new MySqlCommand(sqlMod,cnx);
				comando.ExecuteNonQuery();
				cnx.Close();
				MessageBox.Show("Cliente ELIMINADO satisfactoriamente","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);
				llenarLista();
			   }
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		
		
		void DataGridViewClienteCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(band == 1)
			{
			texto.Text = dataGridViewCliente.SelectedRows[0].Cells[1].Value.ToString();
			this.Close();
			}
			
		}
	}
}
