namespace SuperMarket
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_Exit_ProductForm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_ID_Error = new System.Windows.Forms.Label();
            this.label_Name_Erorr = new System.Windows.Forms.Label();
            this.label_Price_Erorr = new System.Windows.Forms.Label();
            this.label_Quantity_Erorr = new System.Windows.Forms.Label();
            this.dataGridView_Prodoct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label_ManageProduct = new System.Windows.Forms.Label();
            this.ComboBox_Searsh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.ComboBox_Category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_Category = new System.Windows.Forms.Label();
            this.TextBox_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.TextBox_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_Price = new System.Windows.Forms.Label();
            this.TextBox_Quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_Quantity = new System.Windows.Forms.Label();
            this.TextBox_ID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.button_Seller = new System.Windows.Forms.Button();
            this.button_Category = new System.Windows.Forms.Button();
            this.button_Selling = new System.Windows.Forms.Button();
            this.label_Logout = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Prodoct)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Exit_ProductForm
            // 
            this.label_Exit_ProductForm.AutoSize = true;
            this.label_Exit_ProductForm.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exit_ProductForm.ForeColor = System.Drawing.Color.Teal;
            this.label_Exit_ProductForm.Location = new System.Drawing.Point(1053, 0);
            this.label_Exit_ProductForm.Name = "label_Exit_ProductForm";
            this.label_Exit_ProductForm.Size = new System.Drawing.Size(28, 28);
            this.label_Exit_ProductForm.TabIndex = 9;
            this.label_Exit_ProductForm.Text = "X";
            this.label_Exit_ProductForm.Click += new System.EventHandler(this.label_Exit_ProductForm_Click);
            this.label_Exit_ProductForm.MouseEnter += new System.EventHandler(this.label_Exit_ProductForm_MouseHover);
            this.label_Exit_ProductForm.MouseLeave += new System.EventHandler(this.label_Exit_ProductForm_MouseLeave);
            this.label_Exit_ProductForm.MouseHover += new System.EventHandler(this.label_Exit_ProductForm_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label_ID_Error);
            this.panel1.Controls.Add(this.label_Name_Erorr);
            this.panel1.Controls.Add(this.label_Price_Erorr);
            this.panel1.Controls.Add(this.label_Quantity_Erorr);
            this.panel1.Controls.Add(this.dataGridView_Prodoct);
            this.panel1.Controls.Add(this.label_ManageProduct);
            this.panel1.Controls.Add(this.ComboBox_Searsh);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.ComboBox_Category);
            this.panel1.Controls.Add(this.label_Category);
            this.panel1.Controls.Add(this.TextBox_Name);
            this.panel1.Controls.Add(this.label_Name);
            this.panel1.Controls.Add(this.TextBox_Price);
            this.panel1.Controls.Add(this.label_Price);
            this.panel1.Controls.Add(this.TextBox_Quantity);
            this.panel1.Controls.Add(this.label_Quantity);
            this.panel1.Controls.Add(this.TextBox_ID);
            this.panel1.Controls.Add(this.label_ID);
            this.panel1.Location = new System.Drawing.Point(159, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 561);
            this.panel1.TabIndex = 10;
            // 
            // label_ID_Error
            // 
            this.label_ID_Error.AutoSize = true;
            this.label_ID_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_ID_Error.Location = new System.Drawing.Point(87, 350);
            this.label_ID_Error.Name = "label_ID_Error";
            this.label_ID_Error.Size = new System.Drawing.Size(0, 24);
            this.label_ID_Error.TabIndex = 24;
            // 
            // label_Name_Erorr
            // 
            this.label_Name_Erorr.AutoSize = true;
            this.label_Name_Erorr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_Name_Erorr.Location = new System.Drawing.Point(87, 377);
            this.label_Name_Erorr.Name = "label_Name_Erorr";
            this.label_Name_Erorr.Size = new System.Drawing.Size(0, 24);
            this.label_Name_Erorr.TabIndex = 23;
            // 
            // label_Price_Erorr
            // 
            this.label_Price_Erorr.AutoSize = true;
            this.label_Price_Erorr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_Price_Erorr.Location = new System.Drawing.Point(87, 404);
            this.label_Price_Erorr.Name = "label_Price_Erorr";
            this.label_Price_Erorr.Size = new System.Drawing.Size(0, 24);
            this.label_Price_Erorr.TabIndex = 22;
            // 
            // label_Quantity_Erorr
            // 
            this.label_Quantity_Erorr.AutoSize = true;
            this.label_Quantity_Erorr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_Quantity_Erorr.Location = new System.Drawing.Point(87, 431);
            this.label_Quantity_Erorr.Name = "label_Quantity_Erorr";
            this.label_Quantity_Erorr.Size = new System.Drawing.Size(0, 24);
            this.label_Quantity_Erorr.TabIndex = 21;
            // 
            // dataGridView_Prodoct
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_Prodoct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Prodoct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Prodoct.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Prodoct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Prodoct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Prodoct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Prodoct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Prodoct.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Prodoct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Prodoct.EnableHeadersVisualStyles = false;
            this.dataGridView_Prodoct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Prodoct.Location = new System.Drawing.Point(354, 92);
            this.dataGridView_Prodoct.Name = "dataGridView_Prodoct";
            this.dataGridView_Prodoct.RowHeadersVisible = false;
            this.dataGridView_Prodoct.RowHeadersWidth = 51;
            this.dataGridView_Prodoct.RowTemplate.Height = 26;
            this.dataGridView_Prodoct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Prodoct.Size = new System.Drawing.Size(551, 466);
            this.dataGridView_Prodoct.TabIndex = 20;
            this.dataGridView_Prodoct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Prodoct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_Prodoct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Prodoct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_Prodoct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Prodoct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Prodoct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Prodoct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_Prodoct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Prodoct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_Prodoct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_Prodoct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_Prodoct.ThemeStyle.HeaderStyle.Height = 24;
            this.dataGridView_Prodoct.ThemeStyle.ReadOnly = false;
            this.dataGridView_Prodoct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Prodoct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Prodoct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_Prodoct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_Prodoct.ThemeStyle.RowsStyle.Height = 26;
            this.dataGridView_Prodoct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Prodoct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_Prodoct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Prodoct_CellContentClick);
            this.dataGridView_Prodoct.Click += new System.EventHandler(this.dataGridView_Prodoct_Click);
            // 
            // label_ManageProduct
            // 
            this.label_ManageProduct.AutoSize = true;
            this.label_ManageProduct.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ManageProduct.Location = new System.Drawing.Point(271, 8);
            this.label_ManageProduct.Name = "label_ManageProduct";
            this.label_ManageProduct.Size = new System.Drawing.Size(239, 25);
            this.label_ManageProduct.TabIndex = 18;
            this.label_ManageProduct.Text = "MANAGE PRODUCT";
            // 
            // ComboBox_Searsh
            // 
            this.ComboBox_Searsh.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_Searsh.BorderRadius = 17;
            this.ComboBox_Searsh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Searsh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Searsh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Searsh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox_Searsh.FocusedState.Parent = this.ComboBox_Searsh;
            this.ComboBox_Searsh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_Searsh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox_Searsh.HoverState.Parent = this.ComboBox_Searsh;
            this.ComboBox_Searsh.ItemHeight = 30;
            this.ComboBox_Searsh.ItemsAppearance.Parent = this.ComboBox_Searsh;
            this.ComboBox_Searsh.Location = new System.Drawing.Point(463, 45);
            this.ComboBox_Searsh.Name = "ComboBox_Searsh";
            this.ComboBox_Searsh.ShadowDecoration.Parent = this.ComboBox_Searsh;
            this.ComboBox_Searsh.Size = new System.Drawing.Size(200, 36);
            this.ComboBox_Searsh.TabIndex = 17;
            this.ComboBox_Searsh.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Searsh_SelectedIndexChanged);
            this.ComboBox_Searsh.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_Searsh_SelectionChangeCommitted);
            // 
            // button_refresh
            // 
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Location = new System.Drawing.Point(699, 37);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(91, 53);
            this.button_refresh.TabIndex = 16;
            this.button_refresh.Text = " Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_update
            // 
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Location = new System.Drawing.Point(133, 474);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(91, 53);
            this.button_update.TabIndex = 14;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Location = new System.Drawing.Point(241, 474);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(91, 53);
            this.button_Delete.TabIndex = 13;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_add
            // 
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Location = new System.Drawing.Point(36, 474);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(91, 53);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
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
            this.ComboBox_Category.Location = new System.Drawing.Point(132, 294);
            this.ComboBox_Category.Name = "ComboBox_Category";
            this.ComboBox_Category.ShadowDecoration.Parent = this.ComboBox_Category;
            this.ComboBox_Category.Size = new System.Drawing.Size(200, 36);
            this.ComboBox_Category.TabIndex = 11;
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Location = new System.Drawing.Point(34, 300);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(90, 24);
            this.label_Category.TabIndex = 10;
            this.label_Category.Text = "Category";
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.BorderRadius = 17;
            this.TextBox_Name.BorderThickness = 2;
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
            this.TextBox_Name.Location = new System.Drawing.Point(132, 152);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.PasswordChar = '\0';
            this.TextBox_Name.PlaceholderText = "";
            this.TextBox_Name.SelectedText = "";
            this.TextBox_Name.ShadowDecoration.Parent = this.TextBox_Name;
            this.TextBox_Name.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Name.TabIndex = 9;
            this.TextBox_Name.TextChanged += new System.EventHandler(this.TextBox_Name_TextChanged);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(34, 158);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(62, 24);
            this.label_Name.TabIndex = 8;
            this.label_Name.Text = "Name";
            // 
            // TextBox_Price
            // 
            this.TextBox_Price.BorderRadius = 17;
            this.TextBox_Price.BorderThickness = 2;
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
            this.TextBox_Price.Location = new System.Drawing.Point(132, 198);
            this.TextBox_Price.Name = "TextBox_Price";
            this.TextBox_Price.PasswordChar = '\0';
            this.TextBox_Price.PlaceholderText = "";
            this.TextBox_Price.SelectedText = "";
            this.TextBox_Price.ShadowDecoration.Parent = this.TextBox_Price;
            this.TextBox_Price.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Price.TabIndex = 7;
            this.TextBox_Price.TextChanged += new System.EventHandler(this.TextBox_Price_TextChanged);
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(34, 204);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(53, 24);
            this.label_Price.TabIndex = 6;
            this.label_Price.Text = "Price";
            // 
            // TextBox_Quantity
            // 
            this.TextBox_Quantity.BorderRadius = 17;
            this.TextBox_Quantity.BorderThickness = 2;
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
            this.TextBox_Quantity.Location = new System.Drawing.Point(132, 243);
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
            this.label_Quantity.Location = new System.Drawing.Point(32, 249);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(86, 24);
            this.label_Quantity.TabIndex = 4;
            this.label_Quantity.Text = "Quantity";
            // 
            // TextBox_ID
            // 
            this.TextBox_ID.BorderRadius = 17;
            this.TextBox_ID.BorderThickness = 2;
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
            this.TextBox_ID.Location = new System.Drawing.Point(132, 107);
            this.TextBox_ID.Name = "TextBox_ID";
            this.TextBox_ID.PasswordChar = '\0';
            this.TextBox_ID.PlaceholderText = "";
            this.TextBox_ID.SelectedText = "";
            this.TextBox_ID.ShadowDecoration.Parent = this.TextBox_ID;
            this.TextBox_ID.Size = new System.Drawing.Size(200, 36);
            this.TextBox_ID.TabIndex = 1;
            this.TextBox_ID.TextChanged += new System.EventHandler(this.TextBox_ID_TextChanged);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(34, 113);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(31, 24);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "ID";
            // 
            // button_Seller
            // 
            this.button_Seller.FlatAppearance.BorderSize = 0;
            this.button_Seller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Seller.ForeColor = System.Drawing.Color.Teal;
            this.button_Seller.Location = new System.Drawing.Point(27, 41);
            this.button_Seller.Name = "button_Seller";
            this.button_Seller.Size = new System.Drawing.Size(91, 53);
            this.button_Seller.TabIndex = 19;
            this.button_Seller.Text = "Seller";
            this.button_Seller.UseVisualStyleBackColor = true;
            this.button_Seller.Click += new System.EventHandler(this.button_Seller_Click);
            // 
            // button_Category
            // 
            this.button_Category.FlatAppearance.BorderSize = 0;
            this.button_Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Category.ForeColor = System.Drawing.Color.Teal;
            this.button_Category.Location = new System.Drawing.Point(24, 113);
            this.button_Category.Name = "button_Category";
            this.button_Category.Size = new System.Drawing.Size(101, 53);
            this.button_Category.TabIndex = 20;
            this.button_Category.Text = "Category";
            this.button_Category.UseVisualStyleBackColor = true;
            this.button_Category.Click += new System.EventHandler(this.button_Category_Click);
            // 
            // button_Selling
            // 
            this.button_Selling.FlatAppearance.BorderSize = 0;
            this.button_Selling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Selling.ForeColor = System.Drawing.Color.Teal;
            this.button_Selling.Location = new System.Drawing.Point(29, 187);
            this.button_Selling.Name = "button_Selling";
            this.button_Selling.Size = new System.Drawing.Size(91, 53);
            this.button_Selling.TabIndex = 21;
            this.button_Selling.Text = "Selling";
            this.button_Selling.UseVisualStyleBackColor = true;
            this.button_Selling.Click += new System.EventHandler(this.button_Selling_Click);
            // 
            // label_Logout
            // 
            this.label_Logout.AutoSize = true;
            this.label_Logout.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Logout.ForeColor = System.Drawing.Color.Teal;
            this.label_Logout.Location = new System.Drawing.Point(19, 550);
            this.label_Logout.Name = "label_Logout";
            this.label_Logout.Size = new System.Drawing.Size(92, 28);
            this.label_Logout.TabIndex = 22;
            this.label_Logout.Text = "Logout";
            this.label_Logout.Click += new System.EventHandler(this.label_Logout_Click);
            this.label_Logout.MouseEnter += new System.EventHandler(this.label_Logout_MouseEnter);
            this.label_Logout.MouseLeave += new System.EventHandler(this.label_Logout_MouseLeave);
            this.label_Logout.MouseHover += new System.EventHandler(this.label_Logout_MouseEnter);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.label_Logout);
            this.Controls.Add(this.button_Selling);
            this.Controls.Add(this.button_Category);
            this.Controls.Add(this.button_Seller);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Exit_ProductForm);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Prodoct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Exit_ProductForm;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_ID;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_ManageProduct;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_Searsh;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_add;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_Category;
        private System.Windows.Forms.Label label_Category;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Name;
        private System.Windows.Forms.Label label_Name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Price;
        private System.Windows.Forms.Label label_Price;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Quantity;
        private System.Windows.Forms.Label label_Quantity;
        private System.Windows.Forms.Button button_Seller;
        private System.Windows.Forms.Button button_Category;
        private System.Windows.Forms.Button button_Selling;
        private System.Windows.Forms.Label label_Logout;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_Prodoct;
        private System.Windows.Forms.Label label_ID_Error;
        private System.Windows.Forms.Label label_Name_Erorr;
        private System.Windows.Forms.Label label_Price_Erorr;
        private System.Windows.Forms.Label label_Quantity_Erorr;
    }
}