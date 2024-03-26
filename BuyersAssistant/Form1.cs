﻿using System;
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
		DataTable table;
		SqlDataReader reader;

		public Form1()
		{
			InitializeComponent();

			connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);
			LoadProductsGroupToComboBox();
			SelectAllProducts();
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
		void SelectAllProducts()
		{
			string commandLine = @"
SELECT 
	products_name, products_group_name, quantity_in_stock, cost 
FROM Products JOIN ProductsGroup ON Products.products_group=ProductsGroup.products_group_id";
			SqlCommand cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			reader = cmd.ExecuteReader();
			table = new DataTable();
			for(int i=0;i<reader.FieldCount;i++)
			{
				table.Columns.Add(reader.GetName(i));
			}
			while (reader.Read())
			{
				DataRow row = table.NewRow();
				for(int i=0;i< reader.FieldCount;i++)
				{
					row[i] = reader[i];
				}
				table.Rows.Add(row);
			}
			dgvProductsInStock.DataSource = table;
			reader.Close();
			connection.Close();
		}

	}
}
