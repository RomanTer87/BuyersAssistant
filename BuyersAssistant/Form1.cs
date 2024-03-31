using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BuyersAssistant
{
	public partial class Form1 : Form
	{
		string connectionString;
		SqlConnection connection;
		DataTable tableStock;
		DataTable tableCarts;
		SqlDataReader reader;

		public Form1()
		{
			InitializeComponent();

			connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);
			LoadProductsGroupToComboBox();
			SelectProducts();
		}
		void LoadProductsGroupToComboBox()
		{
			string commandLine = @"SELECT products_group_name FROM ProductsGroup";
			SqlCommand cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			reader = cmd.ExecuteReader();
			while(reader.Read())
			{
				cbProductsGroupInStock.Items.Add(reader[0]);
			}
			reader.Close();
			connection.Close();
		}

		void SelectProducts(string products_group = "")
		{
			string commandLine = @"
SELECT 
	products_id, products_name, products_group_name, quantity_in_stock, cost 
FROM Products JOIN ProductsGroup ON Products.products_group=ProductsGroup.products_group_id";
			if (products_group.Length != 0) commandLine += $" WHERE [products_group]=(SELECT products_group_id FROM ProductsGroup WHERE products_group_name='{products_group}')";
			SqlCommand cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			reader = cmd.ExecuteReader();
			tableStock = new DataTable();
			tableCarts= new DataTable();
			for (int i = 0; i < reader.FieldCount; i++)
			{
				tableStock.Columns.Add(reader.GetName(i));
				tableCarts.Columns.Add(reader.GetName(i));
			}
			while (reader.Read())
			{
				DataRow row = tableStock.NewRow();
				for (int i = 0; i < reader.FieldCount; i++)
				{
					row[i] = reader[i];
				}
				tableStock.Rows.Add(row);
			}
			dgvProductsInStock.DataSource = tableStock;
			dgvShoppingCart.DataSource= tableCarts;
			reader.Close();
			connection.Close();
		}


		private void cbProductsGroupInStock_SelectedIndexChanged(object sender, EventArgs e)
		{
			SelectProducts(cbProductsGroupInStock.SelectedItem.ToString());
		}

		private void btnAddProductInCarts_Click(object sender, EventArgs e)
		{
			DataGridViewSelectedRowCollection rows = dgvProductsInStock.SelectedRows;
			foreach(DataGridViewRow row in rows)
			{
				DataRow newRow = tableCarts.NewRow();
				for(int i=0;i<row.Cells.Count;i++)
				{
					newRow[i] = row.Cells[i].Value;
				}
				tableCarts.Rows.Add(newRow);
			}
			//var sqlQuery = "UPDATE Products SET quantity_in_stock = quantity_in_stock - 1";

			//using(var connection = new SqlConnection(connectionString))
			//{
			//	connection.Open();
			//	var command = new SqlCommand(sqlQuery, connection);
			//	int addRowsCount = command.ExecuteNonQuery();
			//	Console.WriteLine("Обновлено строк: {0}", addRowsCount);
			//}

			/////////////////////////////
			string commandLine = $@"UPDATE Products SET quantity_in_stock = quantity_in_stock-1
WHERE [products_id]='" + Convert.ToInt32(dgvProductsInStock[0, dgvProductsInStock.CurrentCell.RowIndex].Value) + "'";
			//WHERE [quantity_in_stock] = '" + Convert.ToInt32(dgvProductsInStock[2, dgvProductsInStock.CurrentCell.RowIndex].Value)+"'";
			SqlCommand cmd = new SqlCommand(commandLine, connection);
		connection.Open();
		cmd.ExecuteNonQuery();
		
		connection.Close();
		}


		private void btnDeleteProductFromCarts_Click(object sender, EventArgs e)
		{
			int rowIndex = dgvShoppingCart.CurrentCell.RowIndex;
			dgvShoppingCart.Rows.RemoveAt(rowIndex);
		}
	}
}
