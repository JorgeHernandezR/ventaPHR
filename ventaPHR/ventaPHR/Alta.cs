/*
 * Created by SharpDevelop.
 * User: Jorge Hernandez
 * Date: 20/07/2022
 * Time: 05:24 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.CodeDom.Compiler;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace ventaPHR
{
	/// <summary>
	/// Description of Alta.
	/// </summary>
	public partial class Alta : Form
	{
		public Alta()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			string codigoBarra = txtCodigoBarras.Text;
			string nombre = txtNombre.Text;
			string precioCompra =txtPrecioCompra.Text;
			string precioVenta = txtPrecioVenta.Text;
			string existencia =txtExistencia.Text;
			
			const string conexion = "server= localhost; userid=root ; password= ; database= ventaphr";
			var cnx = new MySqlConnection(conexion);
			cnx.Open();
			string consulta = "SELECT COUNT(codigo_barras_producto)  FROM `producto` WHERE codigo_barras_producto like '"+codigoBarra+"'";
			var adaptador = new MySqlDataAdapter(consulta,cnx);

			var ds = new DataSet();
			 adaptador.Fill(ds);	
			 if(ds.Tables[0].Rows[0].ItemArray[0].ToString().Equals("0")){
				string sql = "INSERT INTO `producto` (`id_producto`, `codigo_barras_producto`, `nombre_producto`, `precio_venta`, `precio_compra`, `existencia`) VALUES (DEFAULT, '"+codigoBarra+"', '"+nombre+"', '"+precioCompra+"', '"+precioVenta+"', '"+existencia+"');";
			MySqlCommand comando = new MySqlCommand(sql,cnx);
			comando.ExecuteNonQuery();
			MessageBox.Show("Producto agregado exitosamente","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);			               
			 }else{
			 	DialogResult btn= MessageBox.Show("Ese producto ya existe \n Desea modificarlo?","Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2);
			 	if(btn== DialogResult.Yes){
			 		Modificar ventanaModificar = new Modificar(codigoBarra);
			 		ventanaModificar.ShowDialog();
			 	   }
			 }
			
			//MessageBox.Show(ds.Tables[0].Rows[0].ItemArray[0].ToString());
			cnx.Close();
			this.Close();
			}
			
		}
	}

		
	

