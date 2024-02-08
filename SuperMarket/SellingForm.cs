using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace SuperMarket
{
    public partial class SellingForm : Form
    {
        DBConnect DBCon = new DBConnect();
        SqlCommand command = new SqlCommand();

        DGVPrinter printer = new DGVPrinter();
        public SellingForm()
        {
            InitializeComponent();
        }
        private void GetCategory()
        {
            string selectQuery = "select * from Category";
            command.CommandText = selectQuery;
            command.Connection = DBCon.GetConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            ComboBox_Category.DataSource = dt;
            ComboBox_Category.ValueMember = "category_Name";
            //ComboBox_Category.ValueMember = "category_ID";

        }
        private void GetTable()
        {
            string selectQuery = "select product_Name,product_Price from Product";
            command.CommandText = selectQuery;
            command.Connection = DBCon.GetConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            DataGridView_Product.DataSource = dt;
        }

        private void GetsellTable()
        {
            string selectQuery = "select * from Bill";
            command.CommandText = selectQuery;
            command.Connection = DBCon.GetConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            DataGridView_SellList.DataSource = dt;
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            label_Date.Text=DateTime.Today.ToShortDateString();
            GetTable();
            GetCategory();
            GetsellTable();
            label_SellerName.Text = LoginForm.sellername;

        }

        private void DataGridView_Product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox_Name.Text = DataGridView_Product.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_Price.Text = DataGridView_Product.SelectedRows[0].Cells[1].Value.ToString();
        }
        int n = 0, grandTotal = 0;

        private void button_addOrder_Click(object sender, EventArgs e)
        {
            if (TextBox_Quantity.Text == "" || TextBox_Name.Text == "")
            {

                if (TextBox_Quantity.Text == "")
                    TextBox_Quantity.BackColor = Color.Red;
                if (TextBox_Name.Text == "")
                    TextBox_Name.BackColor = Color.Red;
            }
            else
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr.CreateCells(dataGridView_Order);
                int totalPrice = Convert.ToInt32(TextBox_Price.Text) * Convert.ToInt32(TextBox_Quantity.Text);
                dr.Cells[0].Value = ++n;
                dr.Cells[1].Value = TextBox_Name.Text;
                dr.Cells[2].Value = TextBox_Price.Text;
                dr.Cells[3].Value = TextBox_Quantity.Text;
                dr.Cells[4].Value = totalPrice;
                dataGridView_Order.Rows.Add(dr);
                grandTotal += totalPrice;
                label_Ks.Text = grandTotal + " Ks";
                Clear();
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery;
                insertQuery = $"INSERT INTO Bill VALUES(" + TextBox_ID.Text + ",'" + label_SellerName.Text + "','" + label_Date.Text + "'," + grandTotal.ToString() + ")";
                command.Connection = DBCon.GetConnection();
                command.CommandText = insertQuery;
                DBCon.OpenConection();
                command.ExecuteNonQuery();
                MessageBox.Show("Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBCon.CloseConection();
                GetsellTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label_Exit_Seller_MouseEnter(object sender, EventArgs e)
        {
            label_Exit_Seller.ForeColor = Color.Red;
        }

        private void label_Exit_Seller_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_Exit_Seller_MouseLeave(object sender, EventArgs e)
        {
            label_Exit_Seller.ForeColor = Color.Teal;
        }

        private void TextBox_Name_TextChanged(object sender, EventArgs e)
        {
            TextBox_Name.ForeColor = Color.Teal;
        }

        private void TextBox_Price_TextChanged(object sender, EventArgs e)
        {
            TextBox_Price.BackColor = Color.Teal;
        }

        private void TextBox_Quantity_TextChanged(object sender, EventArgs e)
        {
            TextBox_Quantity.BackColor = Color.Teal;
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            printer.Title = "SuperMarket AM Sell List";
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_SellList);
        }

        private void label_Logout_MouseHover(object sender, EventArgs e)
        {
            label_Logout.ForeColor = Color.Red;
        }

        private void label_Logout_MouseLeave(object sender, EventArgs e)
        {
            label_Logout.ForeColor = Color.Teal;
        }

        private void label_Logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            GetTable();
        }

        private void ComboBox_Category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuery = "select product_Name,product_Price from Product where product_ategory='" + ComboBox_Category.Text + "'";
            command.CommandText = selectQuery;
            command.Connection = DBCon.GetConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            DataGridView_Product .DataSource = dt;
        }

        private void Clear()
        {
            TextBox_ID.Clear();
            TextBox_Quantity.Clear();
            TextBox_Price.Clear();
            TextBox_Name.Clear();
        }
    }
}
