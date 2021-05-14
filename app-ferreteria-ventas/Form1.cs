using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace app_ferreteria_ventas
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		//MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);

		//SqlConnection cn = new SqlConnection(
		//		"server=ivasal;database=ferreteria;uid=sa;pwd=katetodd");

		//MySqlConnection MySql = new MySqlConnection(
		//		"server=localhost; database=bd_melamine_accesorios; uid=root; pwd=katetodd");

		MySqlConnection MySql = new MySqlConnection(
				"server=bxxauu3bcus6ake96yfg-mysql.services.clever-cloud.com; database=bxxauu3bcus6ake96yfg; uid=u18h0xxkihex83cc; pwd=cJS0Qy5VRVmzx3NhQATK");
		private void Form1_Load(object sender, EventArgs e)
		{
			//SqlDataAdapter da = new SqlDataAdapter("select * from tb_producto", cn);
			//DataTable tb = new DataTable();
			//da.Fill(tb);
			//dgProductos.DataSource = tb;

			MySqlDataAdapter datos = new MySqlDataAdapter("select * from PRODUCTO", MySql);
			DataTable tb = new DataTable();
			datos.Fill(tb);
			dgProductos.DataSource = tb;
		}
	}
}
