namespace SuperMarket
{
    partial class CategoryForm
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
            this.button_Selling = new System.Windows.Forms.Button();
            this.label_ManageCategory = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.TextBox_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_Product = new System.Windows.Forms.Button();
            this.button_Seller = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.TextBox_Description = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_ID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Name_Error = new System.Windows.Forms.Label();
            this.label_Desc_Error = new System.Windows.Forms.Label();
            this.label_ID_Error = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_Exit_ProductForm = new System.Windows.Forms.Label();
            this.label_Logout = new System.Windows.Forms.Label();
            this.dataGridView_Category = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Selling
            // 
            this.button_Selling.FlatAppearance.BorderSize = 0;
            this.button_Selling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Selling.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Selling.ForeColor = System.Drawing.Color.Teal;
            this.button_Selling.Location = new System.Drawing.Point(29, 187);
            this.button_Selling.Name = "button_Selling";
            this.button_Selling.Size = new System.Drawing.Size(91, 53);
            this.button_Selling.TabIndex = 27;
            this.button_Selling.Text = "Selling";
            this.button_Selling.UseVisualStyleBackColor = true;
            this.button_Selling.Click += new System.EventHandler(this.button_Selling_Click);
            // 
            // label_ManageCategory
            // 
            this.label_ManageCategory.AutoSize = true;
            this.label_ManageCategory.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ManageCategory.Location = new System.Drawing.Point(271, 15);
            this.label_ManageCategory.Name = "label_ManageCategory";
            this.label_ManageCategory.Size = new System.Drawing.Size(251, 25);
            this.label_ManageCategory.TabIndex = 18;
            this.label_ManageCategory.Text = "MANAGE CATEGORY";
            // 
            // button_update
            // 
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(122, 374);
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
            this.button_Delete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(230, 374);
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
            this.button_add.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(25, 374);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(91, 53);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
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
            // button_Product
            // 
            this.button_Product.FlatAppearance.BorderSize = 0;
            this.button_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Product.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Product.ForeColor = System.Drawing.Color.Teal;
            this.button_Product.Location = new System.Drawing.Point(24, 113);
            this.button_Product.Name = "button_Product";
            this.button_Product.Size = new System.Drawing.Size(101, 53);
            this.button_Product.TabIndex = 26;
            this.button_Product.Text = "Product";
            this.button_Product.UseVisualStyleBackColor = true;
            this.button_Product.Click += new System.EventHandler(this.button_Product_Click);
            // 
            // button_Seller
            // 
            this.button_Seller.FlatAppearance.BorderSize = 0;
            this.button_Seller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Seller.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Seller.ForeColor = System.Drawing.Color.Teal;
            this.button_Seller.Location = new System.Drawing.Point(27, 41);
            this.button_Seller.Name = "button_Seller";
            this.button_Seller.Size = new System.Drawing.Size(91, 53);
            this.button_Seller.TabIndex = 25;
            this.button_Seller.Text = "Seller";
            this.button_Seller.UseVisualStyleBackColor = true;
            this.button_Seller.Click += new System.EventHandler(this.button_Seller_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(18, 158);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(62, 24);
            this.label_Name.TabIndex = 8;
            this.label_Name.Text = "Name";
            // 
            // TextBox_Description
            // 
            this.TextBox_Description.BorderRadius = 17;
            this.TextBox_Description.BorderThickness = 2;
            this.TextBox_Description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Description.DefaultText = "";
            this.TextBox_Description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_Description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_Description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Description.DisabledState.Parent = this.TextBox_Description;
            this.TextBox_Description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Description.FocusedState.Parent = this.TextBox_Description;
            this.TextBox_Description.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_Description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Description.HoverState.Parent = this.TextBox_Description;
            this.TextBox_Description.Location = new System.Drawing.Point(132, 198);
            this.TextBox_Description.Name = "TextBox_Description";
            this.TextBox_Description.PasswordChar = '\0';
            this.TextBox_Description.PlaceholderText = "";
            this.TextBox_Description.SelectedText = "";
            this.TextBox_Description.ShadowDecoration.Parent = this.TextBox_Description;
            this.TextBox_Description.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Description.TabIndex = 7;
            this.TextBox_Description.TextChanged += new System.EventHandler(this.TextBox_Description_TextChanged);
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
            this.label_ID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(18, 113);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(31, 24);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label_Name_Error);
            this.panel1.Controls.Add(this.label_Desc_Error);
            this.panel1.Controls.Add(this.label_ID_Error);
            this.panel1.Controls.Add(this.dataGridView_Category);
            this.panel1.Controls.Add(this.label_ManageCategory);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.TextBox_Name);
            this.panel1.Controls.Add(this.label_Name);
            this.panel1.Controls.Add(this.TextBox_Description);
            this.panel1.Controls.Add(this.label_Price);
            this.panel1.Controls.Add(this.TextBox_ID);
            this.panel1.Controls.Add(this.label_ID);
            this.panel1.Location = new System.Drawing.Point(159, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 561);
            this.panel1.TabIndex = 24;
            // 
            // label_Name_Error
            // 
            this.label_Name_Error.AutoSize = true;
            this.label_Name_Error.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name_Error.ForeColor = System.Drawing.Color.Lime;
            this.label_Name_Error.Location = new System.Drawing.Point(100, 299);
            this.label_Name_Error.Name = "label_Name_Error";
            this.label_Name_Error.Size = new System.Drawing.Size(0, 24);
            this.label_Name_Error.TabIndex = 22;
            // 
            // label_Desc_Error
            // 
            this.label_Desc_Error.AutoSize = true;
            this.label_Desc_Error.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Desc_Error.ForeColor = System.Drawing.Color.Lime;
            this.label_Desc_Error.Location = new System.Drawing.Point(100, 337);
            this.label_Desc_Error.Name = "label_Desc_Error";
            this.label_Desc_Error.Size = new System.Drawing.Size(0, 24);
            this.label_Desc_Error.TabIndex = 21;
            // 
            // label_ID_Error
            // 
            this.label_ID_Error.AutoSize = true;
            this.label_ID_Error.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID_Error.ForeColor = System.Drawing.Color.Lime;
            this.label_ID_Error.Location = new System.Drawing.Point(100, 260);
            this.label_ID_Error.Name = "label_ID_Error";
            this.label_ID_Error.Size = new System.Drawing.Size(0, 24);
            this.label_ID_Error.TabIndex = 20;
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Price.Location = new System.Drawing.Point(18, 204);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(110, 24);
            this.label_Price.TabIndex = 6;
            this.label_Price.Text = "Description";
            // 
            // label_Exit_ProductForm
            // 
            this.label_Exit_ProductForm.AutoSize = true;
            this.label_Exit_ProductForm.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exit_ProductForm.ForeColor = System.Drawing.Color.Teal;
            this.label_Exit_ProductForm.Location = new System.Drawing.Point(1053, 0);
            this.label_Exit_ProductForm.Name = "label_Exit_ProductForm";
            this.label_Exit_ProductForm.Size = new System.Drawing.Size(28, 28);
            this.label_Exit_ProductForm.TabIndex = 23;
            this.label_Exit_ProductForm.Text = "X";
            this.label_Exit_ProductForm.Click += new System.EventHandler(this.label_Exit_ProductForm_Click);
            this.label_Exit_ProductForm.MouseEnter += new System.EventHandler(this.label_Exit_ProductForm_MouseEnter);
            this.label_Exit_ProductForm.MouseLeave += new System.EventHandler(this.label_Exit_ProductForm_MouseLeave);
            this.label_Exit_ProductForm.MouseHover += new System.EventHandler(this.label_Exit_ProductForm_MouseHover);
            // 
            // label_Logout
            // 
            this.label_Logout.AutoSize = true;
            this.label_Logout.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Logout.ForeColor = System.Drawing.Color.Teal;
            this.label_Logout.Location = new System.Drawing.Point(19, 550);
            this.label_Logout.Name = "label_Logout";
            this.label_Logout.Size = new System.Drawing.Size(92, 28);
            this.label_Logout.TabIndex = 28;
            this.label_Logout.Text = "Logout";
            this.label_Logout.Click += new System.EventHandler(this.label_Logout_Click);
            this.label_Logout.MouseEnter += new System.EventHandler(this.label_Logout_MouseEnter);
            this.label_Logout.MouseLeave += new System.EventHandler(this.label_Logout_MouseLeave);
            this.label_Logout.MouseHover += new System.EventHandler(this.label_Logout_MouseEnter);
            // 
            // dataGridView_Category
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_Category.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Category.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Category.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Category.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Category.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Category.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Category.EnableHeadersVisualStyles = false;
            this.dataGridView_Category.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Category.Location = new System.Drawing.Point(349, 83);
            this.dataGridView_Category.Name = "dataGridView_Category";
            this.dataGridView_Category.RowHeadersVisible = false;
            this.dataGridView_Category.RowHeadersWidth = 51;
            this.dataGridView_Category.RowTemplate.Height = 26;
            this.dataGridView_Category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Category.Size = new System.Drawing.Size(551, 466);
            this.dataGridView_Category.TabIndex = 19;
            this.dataGridView_Category.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Category.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_Category.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Category.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_Category.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Category.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Category.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Category.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_Category.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Category.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_Category.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_Category.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_Category.ThemeStyle.HeaderStyle.Height = 24;
            this.dataGridView_Category.ThemeStyle.ReadOnly = false;
            this.dataGridView_Category.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Category.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Category.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_Category.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_Category.ThemeStyle.RowsStyle.Height = 26;
            this.dataGridView_Category.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Category.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_Category.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Category_CellContentClick);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.label_Logout);
            this.Controls.Add(this.button_Selling);
            this.Controls.Add(this.button_Product);
            this.Controls.Add(this.button_Seller);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Exit_ProductForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Selling;
        private System.Windows.Forms.Label label_ManageCategory;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_add;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Name;
        private System.Windows.Forms.Button button_Product;
        private System.Windows.Forms.Button button_Seller;
        private System.Windows.Forms.Label label_Name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Description;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_ID;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_Exit_ProductForm;
        private System.Windows.Forms.Label label_Name_Error;
        private System.Windows.Forms.Label label_Desc_Error;
        private System.Windows.Forms.Label label_ID_Error;
        private System.Windows.Forms.Label label_Logout;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_Category;
    }
}