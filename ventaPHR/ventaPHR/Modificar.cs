/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 22/07/2022
 * Time: 02:37 p. m.
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
	/// Description of Modificar.
	/// </summary>
	public partial class Modificar : Form
	{
		DataSet ds;
		public Modificar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public Modificar(string codigo){
			InitializeComponent();
			const string conexion = "server= localhost; userid=root ; password= ; database= ventaphr";
			var cnx = new MySqlConnection(conexion);
			cnx.Open();
			string sql = "SELECT * FROM producto WHERE codigo_barras_producto = '"+codigo+"';";
			var adaptador = new MySqlDataAdapter(sql,cnx);
			ds = new DataSet();
			adaptador.Fill(ds);		
			cnx.Close();
			txtCodigoBarras.Text=codigo;
			txtNombre.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
			txtPrecioVenta.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
			txtPrecioCompra.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
			txtExistencia.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
			
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			string codigBarras= txtCodigoBarras.Text;
			string nombre = txtNombre.Text;
			string precioVenta = txtPrecioVenta.Text;
			string precioCompra = txtPrecioCompra.Text;
			string existencia = txtExistencia.Text;
			string conexion = "server = localhost; userid = root; password = ; database = ventaphr";
			var cnx = new MySqlConnection(conexion);
			cnx.Open();
			string sqlMod = "UPDATE producto SET nombre_producto= '"+nombre+"', precio_venta = '"+precioVenta+"', precio_compra = '"+precioCompra+"', existencia = '"+existencia+"' WHERE codigo_barras_producto = '"+codigBarras+"';";
			MySqlCommand comando = new MySqlCommand(sqlMod,cnx);
			comando.ExecuteNonQuery();
			cnx.Close();
			MessageBox.Show("Producto modificado Exitosamente","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);
			this.Close();
			
		}
		
		void BtnSalirAltaClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
