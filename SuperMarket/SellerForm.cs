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

    public partial class SellerForm : Form
    {
        DBConnect DBCon = new DBConnect();
        SqlCommand command = new SqlCommand();
        public SellerForm()
        {
            InitializeComponent();
        }
        private void SellerForm_Load(object sender, EventArgs e)
        {
            GetTable();
        }
        private void label_Exit_Seller_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_Exit_Seller_MouseEnter(object sender, EventArgs e)
        {
            label_Exit_Seller.ForeColor = Color.Red;
        }

        private void label_Exit_Seller_MouseLeave(object sender, EventArgs e)
        {
            label_Exit_Seller.ForeColor = Color.Teal;
        }

        private void label_Logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            this.Hide();
            loginForm.Show();
        }

        private void button_Selling_Click(object sender, EventArgs e)
        {
            SellingForm sellerForm = new SellingForm();
            sellerForm.Show();
            this.Hide();
        }

        private void button_Product_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Hide();
        }

        private void button_Category_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Hide();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_ID.Text == "" || TextBox_Name.Text == "" || TextBox_Age.Text == "" || TextBox_Phone.Text == "" || TextBox_Password.Text == "")
                {
                    if (TextBox_ID.Text == "")
                        label_ID_Error.Text = "Enter The ID ";
                    if (TextBox_Name.Text == "")
                        label_Name_Erorr.Text = "Enter The Name ";
                    if (TextBox_Age.Text == "")
                        label_Age_Erorr.Text = "Enter The Age ";
                    if (TextBox_Phone.Text == "")
                        label_Phone_Erorr.Text = "Enter The Phone";
                    if (TextBox_Password.Text == "")
                        label_Password_Erorr.Text = "Enter The Password";
                }
                else
                {
                    string insertQuery;//= "insert into Category(category_ID,category_Name,category_Description) values( " + TextBox_ID.Text + " , "+ TextBox_Name.Text + " , "+ TextBox_Description.Text + ")";
                    insertQuery = $"INSERT INTO Seller VALUES(" + TextBox_ID.Text + ",'" + TextBox_Name.Text + "' , '" + TextBox_Age.Text + "','" + TextBox_Phone.Text + "', '" + TextBox_Password.Text + "' )";
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
        private void GetTable()
        {
            string selectQuery = "select * from Seller";
            command.CommandText = selectQuery;
            command.Connection = DBCon.GetConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dataGridView_Seller.DataSource = dt;
        }
        private void Clear()
        {
            TextBox_ID.Clear();
            TextBox_Name.Clear();
            TextBox_Password.Clear();
            TextBox_Phone.Clear();
            TextBox_Age.Clear();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_ID.Text == "" || TextBox_Name.Text == "" || TextBox_Age.Text == "" || TextBox_Phone.Text == "" || TextBox_Password.Text == "")
                {
                    if (TextBox_ID.Text == "")
                        label_ID_Error.Text = "Enter The ID ";
                    if (TextBox_Name.Text == "")
                        label_Name_Erorr.Text = "Enter The Name ";
                    if (TextBox_Age.Text == "")
                        label_Age_Erorr.Text = "Enter The Age ";
                    if (TextBox_Phone.Text == "")
                        label_Phone_Erorr.Text = "Enter The Phone";
                    if (TextBox_Password.Text == "")
                        label_Password_Erorr.Text = "Enter The Password";
                }
                else
                {
                    string updateQuery;
                    updateQuery = "UPDATE Seller  set seller_Name='" + TextBox_Name.Text + "',seller_Age='" + TextBox_Age.Text + "',seller_Phone='" + TextBox_Phone.Text + "',seller_Pass='" + TextBox_Password.Text + "' where seller_Id='" + TextBox_ID.Text + "'";
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

        private void dataGridView_Seller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox_ID.Text = dataGridView_Seller.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_Name.Text = dataGridView_Seller.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_Age.Text = dataGridView_Seller.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_Phone.Text = dataGridView_Seller.SelectedRows[0].Cells[3].Value.ToString();
            TextBox_Password.Text = dataGridView_Seller.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want delete this record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question )== DialogResult.Yes)
                {
                    string deleteQuery;
                    deleteQuery = "delete from Seller where seller_Id='" + TextBox_ID.Text + "'";
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
    }
}
