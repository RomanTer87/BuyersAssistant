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
			this.components = new System.ComponentModel.Container();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageClients = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelShoppingCart = new System.Windows.Forms.Label();
			this.dgvShoppingCart = new System.Windows.Forms.DataGridView();
			this.btnAddProductInCarts = new System.Windows.Forms.Button();
			this.labelProductsList = new System.Windows.Forms.Label();
			this.labelProductsCategory = new System.Windows.Forms.Label();
			this.dgvProductsInStock = new System.Windows.Forms.DataGridView();
			this.cbProductsGroupInStock = new System.Windows.Forms.ComboBox();
			this.tabPageSeller = new System.Windows.Forms.TabPage();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPageClients.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvShoppingCart)).BeginInit();
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
			this.tabPageClients.Controls.Add(this.label2);
			this.tabPageClients.Controls.Add(this.label1);
			this.tabPageClients.Controls.Add(this.labelShoppingCart);
			this.tabPageClients.Controls.Add(this.dgvShoppingCart);
			this.tabPageClients.Controls.Add(this.btnAddProductInCarts);
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(725, 183);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "======>";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(725, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "======>";
			// 
			// labelShoppingCart
			// 
			this.labelShoppingCart.AutoSize = true;
			this.labelShoppingCart.Location = new System.Drawing.Point(805, 51);
			this.labelShoppingCart.Name = "labelShoppingCart";
			this.labelShoppingCart.Size = new System.Drawing.Size(114, 13);
			this.labelShoppingCart.TabIndex = 6;
			this.labelShoppingCart.Text = "Корзина покупателя:";
			// 
			// dgvShoppingCart
			// 
			this.dgvShoppingCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvShoppingCart.Location = new System.Drawing.Point(805, 71);
			this.dgvShoppingCart.Name = "dgvShoppingCart";
			this.dgvShoppingCart.Size = new System.Drawing.Size(475, 414);
			this.dgvShoppingCart.TabIndex = 5;
			// 
			// btnAddProductInCarts
			// 
			this.btnAddProductInCarts.Location = new System.Drawing.Point(709, 100);
			this.btnAddProductInCarts.Name = "btnAddProductInCarts";
			this.btnAddProductInCarts.Size = new System.Drawing.Size(75, 80);
			this.btnAddProductInCarts.TabIndex = 4;
			this.btnAddProductInCarts.Text = "Добавить товар в корзину";
			this.btnAddProductInCarts.UseVisualStyleBackColor = true;
			this.btnAddProductInCarts.Click += new System.EventHandler(this.btnAddProductInCarts_Click);
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
			this.dgvProductsInStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProductsInStock.Size = new System.Drawing.Size(683, 414);
			this.dgvProductsInStock.TabIndex = 1;
			// 
			// cbProductsGroupInStock
			// 
			this.cbProductsGroupInStock.FormattingEnabled = true;
			this.cbProductsGroupInStock.Location = new System.Drawing.Point(7, 24);
			this.cbProductsGroupInStock.Name = "cbProductsGroupInStock";
			this.cbProductsGroupInStock.Size = new System.Drawing.Size(424, 21);
			this.cbProductsGroupInStock.TabIndex = 0;
			this.cbProductsGroupInStock.SelectedIndexChanged += new System.EventHandler(this.cbProductsGroupInStock_SelectedIndexChanged);
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
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
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
			((System.ComponentModel.ISupportInitialize)(this.dgvShoppingCart)).EndInit();
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
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelShoppingCart;
		private System.Windows.Forms.DataGridView dgvShoppingCart;
		private System.Windows.Forms.Button btnAddProductInCarts;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
	}
}

