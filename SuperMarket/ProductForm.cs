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
namespace SuperMarket
{
    public partial class ProductForm : Form
    {
        DBConnect DBCon = new DBConnect();
        SqlCommand command = new SqlCommand();
        public ProductForm()
        {
            InitializeComponent();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            GetCategory();
            GetTable();
            GetCategorySearsh();
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
        private void GetCategorySearsh()
        {
            string selectQuery = "select * from Category";
            command.CommandText = selectQuery;
            command.Connection = DBCon.GetConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            ComboBox_Searsh.DataSource = dt;
            ComboBox_Searsh.ValueMember = "category_Name";
            //ComboBox_Searsh.ValueMember = "category_ID";
        }
        private void button_Category_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            this.Hide();
            categoryForm.Show();
        }

        private void label_Exit_ProductForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_Exit_ProductForm_MouseHover(object sender, EventArgs e)
        {
            label_Exit_ProductForm.ForeColor = Color.Red;
        }

        private void label_Logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            this.Hide();
            loginForm.Show();
        }

        private void label_Logout_MouseEnter(object sender, EventArgs e)
        {
            label_Logout.ForeColor = Color.Red;
        }

        private void label_Logout_MouseLeave(object sender, EventArgs e)
        {
            label_Logout.ForeColor = Color.Teal;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_ID.Text == "" || TextBox_Name.Text == "" || TextBox_Price.Text == "" || TextBox_Quantity.Text == "" || ComboBox_Category.SelectedIndex < 0)
                {
                    if (TextBox_ID.Text == "")
                        label_ID_Error.Text = "Enter The ID ";
                    if (TextBox_Name.Text == "")
                        label_Name_Erorr.Text = "Enter The Name ";
                    if (TextBox_Price.Text == "")
                        label_Price_Erorr.Text = "Enter The Price ";
                    if (TextBox_Quantity.Text == "")
                        label_Quantity_Erorr.Text = "Enter The Quantity ";
                }
                else
                {
                    string insertQuery;//= "insert into Category(category_ID,category_Name,category_Description) values( " + TextBox_ID.Text + " , "+ TextBox_Name.Text + " , "+ TextBox_Description.Text + ")";
                    insertQuery = $"INSERT INTO Product VALUES(" + TextBox_ID.Text + ",'" + TextBox_Name.Text + "' , '" + TextBox_Price.Text + "','" + TextBox_Quantity.Text + "', '" + ComboBox_Category.Text + "' )";
                    command.Connection = DBCon.GetConnection();
                    command.CommandText = insertQuery;
                    DBCon.OpenConection();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DBCon.CloseConection();
                    GetTable();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_ID.Text == "" || TextBox_Name.Text == "" || TextBox_Price.Text == "" || TextBox_Quantity.Text == "" || ComboBox_Category.SelectedIndex < 0)
                {
                    if (TextBox_ID.Text == "")
                        label_ID_Error.Text = "Enter The ID ";
                    if (TextBox_Name.Text == "")
                        label_Name_Erorr.Text = "Enter The Name ";
                    if (TextBox_Price.Text == "")
                        label_Price_Erorr.Text = "Enter The Price ";
                    if (TextBox_Quantity.Text == "")
                        label_Quantity_Erorr.Text = "Enter The Quantity ";
                }
                else
                {
                    string updateQuery;
                    updateQuery = $"UPDATE Product  Set product_Name='" + TextBox_Name.Text + "' ,product_Price='"+ TextBox_Price.Text+"',product_Quantity='"+TextBox_Quantity.Text+"',product_ategory='"+ComboBox_Category.Text+ "' where  product_ID=" + TextBox_ID.Text +"";
                    command.Connection = DBCon.GetConnection();
                    command.CommandText = updateQuery;
                    DBCon.OpenConection();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DBCon.CloseConection();
                    GetTable();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Clear()
        {
            TextBox_ID.Clear();
            TextBox_Name.Clear();
            TextBox_Price.Clear();
            TextBox_Quantity.Clear();
            ComboBox_Category.SelectedIndex = -1;


        }
        private void GetTable()
        {
            string selectQuery = "select * from Product";
            command.CommandText = selectQuery;
            command.Connection = DBCon.GetConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dataGridView_Prodoct.DataSource = dt;
        }

        private void TextBox_ID_TextChanged(object sender, EventArgs e)
        {
            label_ID_Error.Text = "";
        }

        private void TextBox_Name_TextChanged(object sender, EventArgs e)
        {
            label_Name_Erorr.Text = "";
        }

        private void TextBox_Price_TextChanged(object sender, EventArgs e)
        {
            label_Price_Erorr.Text = "";
        }

        private void TextBox_Quantity_TextChanged(object sender, EventArgs e)
        {
            label_Quantity_Erorr.Text = "";
        }

        //private void dataGridView_Prodoct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    TextBox_ID.Text=dataGridView_Prodoct.SelectedRows[0].Cells[0].Value.ToString();
        //    TextBox_Name.Text = dataGridView_Prodoct.SelectedRows[0].Cells[1].Value.ToString();
        //    TextBox_Price.Text = dataGridView_Prodoct.SelectedRows[0].Cells[2].Value.ToString();
        //    TextBox_Quantity.Text = dataGridView_Prodoct.SelectedRows[0].Cells[3].Value.ToString();
        //    ComboBox_Category.Text = dataGridView_Prodoct.SelectedRows[0].Cells[4].Value.ToString();

        //}

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want delete this record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string deleteQuery;
                    deleteQuery = "delete from Product where product_ID='" + TextBox_ID.Text + "'";
                    command.Connection = DBCon.GetConnection();
                    command.CommandText = deleteQuery;
                    DBCon.OpenConection();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DBCon.CloseConection();
                    GetTable();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_Prodoct_Click(object sender, EventArgs e)
        {
            TextBox_ID.Text = dataGridView_Prodoct.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_Name.Text = dataGridView_Prodoct.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_Price.Text = dataGridView_Prodoct.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_Quantity.Text = dataGridView_Prodoct.SelectedRows[0].Cells[3].Value.ToString();
            ComboBox_Category.Text = dataGridView_Prodoct.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            GetTable();
        }

        private void ComboBox_Searsh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuery = "select * from Product where product_ategory='"+ComboBox_Searsh.Text+"'";
            command.CommandText = selectQuery;
            command.Connection = DBCon.GetConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dataGridView_Prodoct.DataSource = dt;
        }

        private void button_Seller_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            sellerForm.Show();
            this.Hide();
        }

        private void button_Selling_Click(object sender, EventArgs e)
        {
            SellingForm sellerForm = new SellingForm();
            sellerForm.Show();
            this.Hide();
        }

        private void dataGridView_Prodoct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComboBox_Searsh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_Exit_ProductForm_MouseLeave(object sender, EventArgs e)
        {
            label_Exit_ProductForm.ForeColor = Color.Teal;
        }
    }
}
