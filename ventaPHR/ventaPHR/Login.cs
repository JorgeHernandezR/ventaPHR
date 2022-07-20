
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
	/// Description of Login.
	/// </summary>
	public partial class Login : Form
	{
		public Login()
		{
			
			InitializeComponent();
			
		}
		
		
		void BtnEntrarClick(object sender, EventArgs e)
		{
			string contraseña= txtContraseña.Text;
			string conexion = "server=localhost; userid=root; password=; database= ventaphr";
			MySqlConnection cnx= new MySqlConnection(conexion);
			cnx.Open();
			string sql= "SELECT COUNT(*) FROM usuario WHERE nombre_usuario='Petra Hernandez Ramírez' and contraseña_usuario='"+contraseña+"'";
			MySqlDataAdapter adaptador= new MySqlDataAdapter(sql,cnx);
			DataSet ds = new DataSet();
			adaptador.Fill(ds);
			cnx.Close();
			byte valor= byte.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
			if(valor==1){
				MessageBox.Show("Acceso correcto");
				this.DialogResult = DialogResult.OK;
				
			 
			}
			
		}
	}
}
