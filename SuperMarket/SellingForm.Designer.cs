namespace SuperMarket
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_Order = new Guna.UI2.WinForms.Guna2DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Exit_Seller = new System.Windows.Forms.Label();
            this.label_Password_Erorr = new System.Windows.Forms.Label();
            this.label_ManageProduct = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox_ID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Ks = new System.Windows.Forms.Label();
            this.label_sellsLIST = new System.Windows.Forms.Label();
            this.label_Amount = new System.Windows.Forms.Label();
            this.DataGridView_SellList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ComboBox_Category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label_SellerName = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.DataGridView_Product = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button_Print = new System.Windows.Forms.Button();
            this.button_addOrder = new System.Windows.Forms.Button();
            this.TextBox_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.TextBox_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_Price = new System.Windows.Forms.Label();
            this.TextBox_Quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_Quantity = new System.Windows.Forms.Label();
            this.label_Logout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_SellList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Order
            // 
            dataGridViewCellStyle64.BackColor = System.Drawing.Color.White;
            this.dataGridView_Order.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle64;
            this.dataGridView_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Order.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Order.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle65.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle65.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle65.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle65.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle65.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle65;
            this.dataGridView_Order.ColumnHeadersHeight = 24;
            this.dataGridView_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.productPrice,
            this.productQuantity,
            this.total});
            dataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle66.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle66.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle66.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle66.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle66.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle66.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Order.DefaultCellStyle = dataGridViewCellStyle66;
            this.dataGridView_Order.EnableHeadersVisualStyles = false;
            this.dataGridView_Order.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Order.Location = new System.Drawing.Point(349, 63);
            this.dataGridView_Order.Name = "dataGridView_Order";
            this.dataGridView_Order.RowHeadersVisible = false;
            this.dataGridView_Order.RowHeadersWidth = 51;
            this.dataGridView_Order.RowTemplate.Height = 26;
            this.dataGridView_Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Order.Size = new System.Drawing.Size(551, 149);
            this.dataGridView_Order.TabIndex = 29;
            this.dataGridView_Order.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Order.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_Order.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Order.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_Order.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Order.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Order.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Order.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_Order.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Order.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_Order.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_Order.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_Order.ThemeStyle.HeaderStyle.Height = 24;
            this.dataGridView_Order.ThemeStyle.ReadOnly = false;
            this.dataGridView_Order.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Order.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Order.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_Order.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_Order.ThemeStyle.RowsStyle.Height = 26;
            this.dataGridView_Order.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Order.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // productID
            // 
            this.productID.HeaderText = "ProductID";
            this.productID.MinimumWidth = 6;
            this.productID.Name = "productID";
            // 
            // productName
            // 
            this.productName.HeaderText = "ProductName";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "ProductPrice";
            this.productPrice.MinimumWidth = 6;
            this.productPrice.Name = "productPrice";
            // 
            // productQuantity
            // 
            this.productQuantity.HeaderText = "Quantity";
            this.productQuantity.MinimumWidth = 6;
            this.productQuantity.Name = "productQuantity";
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            // 
            // label_Exit_Seller
            // 
            this.label_Exit_Seller.AutoSize = true;
            this.label_Exit_Seller.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exit_Seller.ForeColor = System.Drawing.Color.Teal;
            this.label_Exit_Seller.Location = new System.Drawing.Point(1049, 1);
            this.label_Exit_Seller.Name = "label_Exit_Seller";
            this.label_Exit_Seller.Size = new System.Drawing.Size(28, 28);
            this.label_Exit_Seller.TabIndex = 29;
            this.label_Exit_Seller.Text = "X";
            this.label_Exit_Seller.Click += new System.EventHandler(this.label_Exit_Seller_Click);
            this.label_Exit_Seller.MouseEnter += new System.EventHandler(this.label_Exit_Seller_MouseEnter);
            this.label_Exit_Seller.MouseLeave += new System.EventHandler(this.label_Exit_Seller_MouseLeave);
            this.label_Exit_Seller.MouseHover += new System.EventHandler(this.label_Exit_Seller_MouseEnter);
            // 
            // label_Password_Erorr
            // 
            this.label_Password_Erorr.AutoSize = true;
            this.label_Password_Erorr.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password_Erorr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_Password_Erorr.Location = new System.Drawing.Point(90, 472);
            this.label_Password_Erorr.Name = "label_Password_Erorr";
            this.label_Password_Erorr.Size = new System.Drawing.Size(0, 24);
            this.label_Password_Erorr.TabIndex = 27;
            // 
            // label_ManageProduct
            // 
            this.label_ManageProduct.AutoSize = true;
            this.label_ManageProduct.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ManageProduct.Location = new System.Drawing.Point(361, 15);
            this.label_ManageProduct.Name = "label_ManageProduct";
            this.label_ManageProduct.Size = new System.Drawing.Size(120, 25);
            this.label_ManageProduct.TabIndex = 18;
            this.label_ManageProduct.Text = " SELLING";
            // 
            // button_Add
            // 
            this.button_Add.FlatAppearance.BorderSize = 0;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(824, 288);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(67, 35);
            this.button_Add.TabIndex = 14;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.TextBox_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_Ks);
            this.panel1.Controls.Add(this.label_sellsLIST);
            this.panel1.Controls.Add(this.label_Amount);
            this.panel1.Controls.Add(this.DataGridView_SellList);
            this.panel1.Controls.Add(this.ComboBox_Category);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.label_SellerName);
            this.panel1.Controls.Add(this.label_Date);
            this.panel1.Controls.Add(this.DataGridView_Product);
            this.panel1.Controls.Add(this.dataGridView_Order);
            this.panel1.Controls.Add(this.label_Password_Erorr);
            this.panel1.Controls.Add(this.label_ManageProduct);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Controls.Add(this.button_Print);
            this.panel1.Controls.Add(this.button_addOrder);
            this.panel1.Controls.Add(this.TextBox_Name);
            this.panel1.Controls.Add(this.label_Name);
            this.panel1.Controls.Add(this.TextBox_Price);
            this.panel1.Controls.Add(this.label_Price);
            this.panel1.Controls.Add(this.TextBox_Quantity);
            this.panel1.Controls.Add(this.label_Quantity);
            this.panel1.Location = new System.Drawing.Point(160, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 561);
            this.panel1.TabIndex = 30;
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.BorderRadius = 17;
            this.TextBox_ID.BorderThickness = 0;
            this.TextBox_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_ID.DefaultText = "";
            this.TextBox_ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_ID.DisabledState.Parent = this.TextBox_ID;
            this.TextBox_ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_ID.FocusedState.Parent = this.TextBox_ID;
            this.TextBox_ID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_ID.HoverState.Parent = this.TextBox_ID;
            this.TextBox_ID.Location = new System.Drawing.Point(735, 287);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.PasswordChar = '\0';
            this.TextBox_ID.PlaceholderText = "";
            this.TextBox_ID.SelectedText = "";
            this.TextBox_ID.ShadowDecoration.Parent = this.TextBox_ID;
            this.TextBox_ID.Size = new System.Drawing.Size(86, 36);
            this.TextBox_ID.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(673, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "BillID";
            // 
            // label_Ks
            // 
            this.label_Ks.AutoSize = true;
            this.label_Ks.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ks.Location = new System.Drawing.Point(794, 237);
            this.label_Ks.Name = "label_Ks";
            this.label_Ks.Size = new System.Drawing.Size(31, 24);
            this.label_Ks.TabIndex = 38;
            this.label_Ks.Text = "Ks";
            // 
            // label_sellsLIST
            // 
            this.label_sellsLIST.AutoSize = true;
            this.label_sellsLIST.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sellsLIST.Location = new System.Drawing.Point(345, 299);
            this.label_sellsLIST.Name = "label_sellsLIST";
            this.label_sellsLIST.Size = new System.Drawing.Size(88, 24);
            this.label_sellsLIST.TabIndex = 37;
            this.label_sellsLIST.Text = "Sells List";
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Amount.Location = new System.Drawing.Point(589, 237);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(79, 24);
            this.label_Amount.TabIndex = 36;
            this.label_Amount.Text = "Amount";
            // 
            // DataGridView_SellList
            // 
            dataGridViewCellStyle67.BackColor = System.Drawing.Color.White;
            this.DataGridView_SellList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle67;
            this.DataGridView_SellList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_SellList.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_SellList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_SellList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_SellList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle68.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle68.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle68.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle68.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle68.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle68.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle68.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_SellList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle68;
            this.DataGridView_SellList.ColumnHeadersHeight = 24;
            dataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle69.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle69.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle69.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle69.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle69.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle69.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_SellList.DefaultCellStyle = dataGridViewCellStyle69;
            this.DataGridView_SellList.EnableHeadersVisualStyles = false;
            this.DataGridView_SellList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_SellList.Location = new System.Drawing.Point(349, 330);
            this.DataGridView_SellList.Name = "DataGridView_SellList";
            this.DataGridView_SellList.RowHeadersVisible = false;
            this.DataGridView_SellList.RowHeadersWidth = 51;
            this.DataGridView_SellList.RowTemplate.Height = 26;
            this.DataGridView_SellList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_SellList.Size = new System.Drawing.Size(551, 183);
            this.DataGridView_SellList.TabIndex = 35;
            this.DataGridView_SellList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_SellList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_SellList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_SellList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_SellList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_SellList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_SellList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_SellList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_SellList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_SellList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_SellList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_SellList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_SellList.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_SellList.ThemeStyle.ReadOnly = false;
            this.DataGridView_SellList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_SellList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_SellList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_SellList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_SellList.ThemeStyle.RowsStyle.Height = 26;
            this.DataGridView_SellList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_SellList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ComboBox_Category
            // 
            this.ComboBox_Category.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_Category.BorderRadius = 17;
            this.ComboBox_Category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Category.FocusedState.Parent = this.ComboBox_Category;
            this.ComboBox_Category.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_Category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox_Category.HoverState.Parent = this.ComboBox_Category;
            this.ComboBox_Category.ItemHeight = 30;
            this.ComboBox_Category.ItemsAppearance.Parent = this.ComboBox_Category;
            this.ComboBox_Category.Location = new System.Drawing.Point(19, 274);
            this.ComboBox_Category.Name = "ComboBox_Category";
            this.ComboBox_Category.ShadowDecoration.Parent = this.ComboBox_Category;
            this.ComboBox_Category.Size = new System.Drawing.Size(200, 36);
            this.ComboBox_Category.TabIndex = 34;
            this.ComboBox_Category.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_Category_SelectionChangeCommitted);
            // 
            // button_refresh
            // 
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.Location = new System.Drawing.Point(239, 268);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(91, 44);
            this.button_refresh.TabIndex = 33;
            this.button_refresh.Text = " Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // label_SellerName
            // 
            this.label_SellerName.AutoSize = true;
            this.label_SellerName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SellerName.Location = new System.Drawing.Point(32, 16);
            this.label_SellerName.Name = "label_SellerName";
            this.label_SellerName.Size = new System.Drawing.Size(125, 24);
            this.label_SellerName.TabIndex = 32;
            this.label_SellerName.Text = "Seller Name:";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(799, 15);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(60, 24);
            this.label_Date.TabIndex = 31;
            this.label_Date.Text = "Date:";
            // 
            // DataGridView_Product
            // 
            dataGridViewCellStyle70.BackColor = System.Drawing.Color.White;
            this.DataGridView_Product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle70;
            this.DataGridView_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Product.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_Product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_Product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_Product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle71.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle71.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle71.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle71.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle71.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle71.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle71;
            this.DataGridView_Product.ColumnHeadersHeight = 24;
            dataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle72.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle72.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle72.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle72.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle72.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle72.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Product.DefaultCellStyle = dataGridViewCellStyle72;
            this.DataGridView_Product.EnableHeadersVisualStyles = false;
            this.DataGridView_Product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Product.Location = new System.Drawing.Point(19, 324);
            this.DataGridView_Product.Name = "DataGridView_Product";
            this.DataGridView_Product.RowHeadersVisible = false;
            this.DataGridView_Product.RowHeadersWidth = 51;
            this.DataGridView_Product.RowTemplate.Height = 26;
            this.DataGridView_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Product.Size = new System.Drawing.Size(311, 227);
            this.DataGridView_Product.TabIndex = 30;
            this.DataGridView_Product.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_Product.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_Product.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_Product.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_Product.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_Product.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_Product.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Product.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_Product.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_Product.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_Product.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_Product.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_Product.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_Product.ThemeStyle.ReadOnly = false;
            this.DataGridView_Product.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_Product.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_Product.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_Product.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_Product.ThemeStyle.RowsStyle.Height = 26;
            this.DataGridView_Product.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Product.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_Product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Product_CellContentClick);
            // 
            // button_Print
            // 
            this.button_Print.FlatAppearance.BorderSize = 0;
            this.button_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Print.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Print.Location = new System.Drawing.Point(803, 505);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(91, 53);
            this.button_Print.TabIndex = 13;
            this.button_Print.Text = "Print";
            this.button_Print.UseVisualStyleBackColor = true;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // button_addOrder
            // 
            this.button_addOrder.FlatAppearance.BorderSize = 0;
            this.button_addOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addOrder.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addOrder.Location = new System.Drawing.Point(106, 211);
            this.button_addOrder.Name = "button_addOrder";
            this.button_addOrder.Size = new System.Drawing.Size(125, 31);
            this.button_addOrder.TabIndex = 12;
            this.button_addOrder.Text = "Add Order";
            this.button_addOrder.UseVisualStyleBackColor = true;
            this.button_addOrder.Click += new System.EventHandler(this.button_addOrder_Click);
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.BorderRadius = 17;
            this.TextBox_Name.BorderThickness = 0;
            this.TextBox_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Name.DefaultText = "";
            this.TextBox_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Name.DisabledState.Parent = this.TextBox_Name;
            this.TextBox_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Name.FocusedState.Parent = this.TextBox_Name;
            this.TextBox_Name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Name.HoverState.Parent = this.TextBox_Name;
            this.TextBox_Name.Location = new System.Drawing.Point(130, 74);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.PasswordChar = '\0';
            this.TextBox_Name.PlaceholderText = "";
            this.TextBox_Name.ReadOnly = true;
            this.TextBox_Name.SelectedText = "";
            this.TextBox_Name.ShadowDecoration.Parent = this.TextBox_Name;
            this.TextBox_Name.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Name.TabIndex = 9;
            this.TextBox_Name.TextChanged += new System.EventHandler(this.TextBox_Name_TextChanged);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(32, 80);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(62, 24);
            this.label_Name.TabIndex = 8;
            this.label_Name.Text = "Name";
            // 
            // TextBox_Price
            // 
            this.TextBox_Price.BorderRadius = 17;
            this.TextBox_Price.BorderThickness = 0;
            this.TextBox_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Price.DefaultText = "";
            this.TextBox_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Price.DisabledState.Parent = this.TextBox_Price;
            this.TextBox_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Price.FocusedState.Parent = this.TextBox_Price;
            this.TextBox_Price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Price.HoverState.Parent = this.TextBox_Price;
            this.TextBox_Price.Location = new System.Drawing.Point(130, 118);
            this.TextBox_Price.Name = "TextBox_Price";
            this.TextBox_Price.PasswordChar = '\0';
            this.TextBox_Price.PlaceholderText = "";
            this.TextBox_Price.ReadOnly = true;
            this.TextBox_Price.SelectedText = "";
            this.TextBox_Price.ShadowDecoration.Parent = this.TextBox_Price;
            this.TextBox_Price.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Price.TabIndex = 7;
            this.TextBox_Price.TextChanged += new System.EventHandler(this.TextBox_Price_TextChanged);
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Price.Location = new System.Drawing.Point(32, 124);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(53, 24);
            this.label_Price.TabIndex = 6;
            this.label_Price.Text = "Price";
            // 
            // TextBox_Quantity
            // 
            this.TextBox_Quantity.BorderRadius = 17;
            this.TextBox_Quantity.BorderThickness = 0;
            this.TextBox_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Quantity.DefaultText = "";
            this.TextBox_Quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Quantity.DisabledState.Parent = this.TextBox_Quantity;
            this.TextBox_Quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Quantity.FocusedState.Parent = this.TextBox_Quantity;
            this.TextBox_Quantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_Quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Quantity.HoverState.Parent = this.TextBox_Quantity;
            this.TextBox_Quantity.Location = new System.Drawing.Point(130, 162);
            this.TextBox_Quantity.Name = "TextBox_Quantity";
            this.TextBox_Quantity.PasswordChar = '\0';
            this.TextBox_Quantity.PlaceholderText = "";
            this.TextBox_Quantity.SelectedText = "";
            this.TextBox_Quantity.ShadowDecoration.Parent = this.TextBox_Quantity;
            this.TextBox_Quantity.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Quantity.TabIndex = 5;
            this.TextBox_Quantity.TextChanged += new System.EventHandler(this.TextBox_Quantity_TextChanged);
            // 
            // label_Quantity
            // 
            this.label_Quantity.AutoSize = true;
            this.label_Quantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Quantity.Location = new System.Drawing.Point(30, 168);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(86, 24);
            this.label_Quantity.TabIndex = 4;
            this.label_Quantity.Text = "Quantity";
            // 
            // label_Logout
            // 
            this.label_Logout.AutoSize = true;
            this.label_Logout.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Logout.ForeColor = System.Drawing.Color.Teal;
            this.label_Logout.Location = new System.Drawing.Point(15, 551);
            this.label_Logout.Name = "label_Logout";
            this.label_Logout.Size = new System.Drawing.Size(92, 28);
            this.label_Logout.TabIndex = 34;
            this.label_Logout.Text = "Logout";
            this.label_Logout.Click += new System.EventHandler(this.label_Logout_Click);
            this.label_Logout.MouseEnter += new System.EventHandler(this.label_Logout_MouseHover);
            this.label_Logout.MouseLeave += new System.EventHandler(this.label_Logout_MouseLeave);
            this.label_Logout.MouseHover += new System.EventHandler(this.label_Logout_MouseHover);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.label_Exit_Seller);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Logout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Order)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_SellList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_Order;
        private System.Windows.Forms.Label label_Exit_Seller;
        private System.Windows.Forms.Label label_Password_Erorr;
        private System.Windows.Forms.Label label_ManageProduct;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.Button button_addOrder;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Name;
        private System.Windows.Forms.Label label_Name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Price;
        private System.Windows.Forms.Label label_Price;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Quantity;
        private System.Windows.Forms.Label label_Quantity;
        private System.Windows.Forms.Label label_Logout;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_Product;
        private System.Windows.Forms.Label label_SellerName;
        private System.Windows.Forms.Label label_Date;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_Category;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label_Ks;
        private System.Windows.Forms.Label label_sellsLIST;
        private System.Windows.Forms.Label label_Amount;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_SellList;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_ID;
        private System.Windows.Forms.Label label1;
    }
}