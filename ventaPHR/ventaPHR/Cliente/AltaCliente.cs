/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 04/08/2022
 * Time: 05:29 p. m.
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
	/// Description of AltaCliente.
	/// </summary>
	public partial class AltaCliente : Form
	{
		
		public AltaCliente()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public AltaCliente(string nombre,string numero){
			InitializeComponent();
			txtNombre.Text = nombre;
			txtTelefono.Text = numero.ToString();
			
		}
		
	
		void conexionDatabase(string sql){
			string conexion = "server = localhost; userid = root; password = ; database = ventaphr";
				var cnx = new MySqlConnection(conexion);
				cnx.Open();
				MySqlCommand comando = new MySqlCommand(sql,cnx);
			comando.ExecuteNonQuery();
			cnx.Close();
		}
		
		DataSet verificarDatos(){
			const string conexion = "server= localhost; userid=root ; password= ; database= ventaphr";
			var cnx = new MySqlConnection(conexion);
			cnx.Open();
			string consulta = "SELECT COUNT(nombre_cliente) from cliente where nombre_cliente = '"+txtNombre.Text.ToString().Trim()+"';";
			var adaptador = new MySqlDataAdapter(consulta,cnx);

			var ds = new DataSet();
			 adaptador.Fill(ds);	
			 return ds;
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			DataSet ds = verificarDatos();
			if(ds.Tables[0].Rows[0].ItemArray[0].ToString().Equals("1")){
			   	DialogResult btn =MessageBox.Show("Ese nombre ya existe, desea modificar","ATENCION",MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2);
			   	if(btn == DialogResult.Yes)
			   	{
			   		AltaCliente ventanaAltaCliente = new AltaCliente(txtNombre.Text,txtTelefono.Text);
			   		ventanaAltaCliente.ShowDialog();
			   	}
			   	
			   }else{
			   	string sql = "INSERT INTO cliente (id_cliente,nombre_cliente,telefono) VALUES (DEFAULT,'"+txtNombre.Text.ToString()+"','"+txtTelefono.Text.ToString()+"')";
			conexionDatabase(sql);
			MessageBox.Show("Cliente agregado con exito");
			this.Close();
			   }
			
			
			
		}
	}
}
