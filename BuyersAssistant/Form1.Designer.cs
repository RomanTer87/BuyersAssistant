namespace BuyersAssistant
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageClients = new System.Windows.Forms.TabPage();
			this.labelProductsCategory = new System.Windows.Forms.Label();
			this.dgvProductsInStock = new System.Windows.Forms.DataGridView();
			this.cbProductsGroupInStock = new System.Windows.Forms.ComboBox();
			this.tabPageSeller = new System.Windows.Forms.TabPage();
			this.labelProductsList = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPageClients.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductsInStock)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageClients);
			this.tabControl1.Controls.Add(this.tabPageSeller);
			this.tabControl1.Location = new System.Drawing.Point(13, 13);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1306, 531);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPageClients
			// 
			this.tabPageClients.BackColor = System.Drawing.SystemColors.Control;
			this.tabPageClients.Controls.Add(this.labelProductsList);
			this.tabPageClients.Controls.Add(this.labelProductsCategory);
			this.tabPageClients.Controls.Add(this.dgvProductsInStock);
			this.tabPageClients.Controls.Add(this.cbProductsGroupInStock);
			this.tabPageClients.Location = new System.Drawing.Point(4, 22);
			this.tabPageClients.Name = "tabPageClients";
			this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageClients.Size = new System.Drawing.Size(1298, 505);
			this.tabPageClients.TabIndex = 0;
			this.tabPageClients.Text = "Client";
			// 
			// labelProductsCategory
			// 
			this.labelProductsCategory.AutoSize = true;
			this.labelProductsCategory.Location = new System.Drawing.Point(7, 5);
			this.labelProductsCategory.Name = "labelProductsCategory";
			this.labelProductsCategory.Size = new System.Drawing.Size(107, 13);
			this.labelProductsCategory.TabIndex = 2;
			this.labelProductsCategory.Text = "Категория товаров:";
			// 
			// dgvProductsInStock
			// 
			this.dgvProductsInStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductsInStock.Location = new System.Drawing.Point(7, 71);
			this.dgvProductsInStock.Name = "dgvProductsInStock";
			this.dgvProductsInStock.Size = new System.Drawing.Size(655, 414);
			this.dgvProductsInStock.TabIndex = 1;
			// 
			// cbProductsGroupInStock
			// 
			this.cbProductsGroupInStock.FormattingEnabled = true;
			this.cbProductsGroupInStock.Location = new System.Drawing.Point(7, 24);
			this.cbProductsGroupInStock.Name = "cbProductsGroupInStock";
			this.cbProductsGroupInStock.Size = new System.Drawing.Size(424, 21);
			this.cbProductsGroupInStock.TabIndex = 0;
			// 
			// tabPageSeller
			// 
			this.tabPageSeller.BackColor = System.Drawing.SystemColors.Control;
			this.tabPageSeller.Location = new System.Drawing.Point(4, 22);
			this.tabPageSeller.Name = "tabPageSeller";
			this.tabPageSeller.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSeller.Size = new System.Drawing.Size(1298, 505);
			this.tabPageSeller.TabIndex = 1;
			this.tabPageSeller.Text = "Seller";
			// 
			// labelProductsList
			// 
			this.labelProductsList.AutoSize = true;
			this.labelProductsList.Location = new System.Drawing.Point(7, 52);
			this.labelProductsList.Name = "labelProductsList";
			this.labelProductsList.Size = new System.Drawing.Size(91, 13);
			this.labelProductsList.TabIndex = 3;
			this.labelProductsList.Text = "Список товаров:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1331, 556);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.tabPageClients.ResumeLayout(false);
			this.tabPageClients.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductsInStock)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageClients;
		private System.Windows.Forms.DataGridView dgvProductsInStock;
		private System.Windows.Forms.ComboBox cbProductsGroupInStock;
		private System.Windows.Forms.TabPage tabPageSeller;
		private System.Windows.Forms.Label labelProductsCategory;
		private System.Windows.Forms.Label labelProductsList;
	}
}

