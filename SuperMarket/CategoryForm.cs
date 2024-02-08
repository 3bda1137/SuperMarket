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
    public partial class CategoryForm : Form
    {
        DBConnect DBCon = new DBConnect();
        SqlCommand command = new SqlCommand();
        public CategoryForm()
        {
            InitializeComponent();
        }
        private void GetTable()
        {
            string selectQuery = "select * from Category";
            command.CommandText = selectQuery;
            command.Connection = DBCon.GetConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            dataGridView_Category.DataSource = dt;
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_Name.Text == "" || TextBox_ID.Text == "" || TextBox_Description.Text == "")
                {
                    // MessageBox.Show("Missing Information", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (TextBox_Name.Text == "")
                    {
                        label_Name_Error.Text = "Enter The Name";
                    }
                    if (TextBox_Description.Text == "")
                    {
                        label_Desc_Error.Text = "Enter The Description";
                    }
                    if (TextBox_ID.Text == "")
                    {
                        label_ID_Error.Text = "Enter The ID";
                    }
                }
                else
                {
                    string insertQuery;//= "insert into Category(category_ID,category_Name,category_Description) values( " + TextBox_ID.Text + " , "+ TextBox_Name.Text + " , "+ TextBox_Description.Text + ")";
                    insertQuery = $"INSERT INTO Category VALUES(" + TextBox_ID.Text + ",'" + TextBox_Name.Text + "' , '" + TextBox_Description.Text + "' )";

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
        private void Clear()
        {
            TextBox_ID.Clear();
            TextBox_Name.Clear();
            TextBox_Description.Clear();
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            GetTable();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_Name.Text == "" || TextBox_ID.Text == "" || TextBox_Description.Text == "")
                {
                    // MessageBox.Show("Missing Information", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (TextBox_Name.Text == "")
                    {
                        label_Name_Error.Text = "Enter The Name";
                    }
                    if (TextBox_Description.Text == "")
                    {
                        label_Desc_Error.Text = "Enter The Description";
                    }
                    if (TextBox_ID.Text == "")
                    {
                        label_ID_Error.Text = "Enter The ID";
                    }
                }
                else
                {
                    string updateQuery;
                    updateQuery = "UPDATE Category  set category_Name='" + TextBox_Name.Text + "',category_Description='" + TextBox_Description.Text + "' where category_ID='" + TextBox_ID.Text + "'";
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
        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want delete this record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string deleteQuery;
                    deleteQuery = "delete from Category where category_ID='" + TextBox_ID.Text + "'";
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

        private void dataGridView_Category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox_ID.Text = dataGridView_Category.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_Name.Text = dataGridView_Category.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_Description.Text = dataGridView_Category.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void label_Exit_ProductForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox_ID_TextChanged(object sender, EventArgs e)
        {
            label_ID_Error.Text = "";
        }

        private void TextBox_Name_TextChanged(object sender, EventArgs e)
        {
            label_Name_Error.Text = "";

        }

        private void TextBox_Description_TextChanged(object sender, EventArgs e)
        {
            label_Desc_Error.Text = "";

        }

        private void label_Exit_ProductForm_MouseHover(object sender, EventArgs e)
        {
            label_Exit_ProductForm.ForeColor= Color.Red;
        }

        private void label_Exit_ProductForm_MouseEnter(object sender, EventArgs e)
        {
            label_Exit_ProductForm.ForeColor = Color.Red;

        }

        private void label_Exit_ProductForm_MouseLeave(object sender, EventArgs e)
        {
            label_Exit_ProductForm.ForeColor = Color.Teal;

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

        private void button_Product_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            this.Hide();
            productForm.Show();
        }

        private void button_Selling_Click(object sender, EventArgs e)
        {
            SellingForm sellerForm = new SellingForm();
            sellerForm.Show();
            this.Hide();
        }

        private void button_Seller_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            sellerForm.Show();
            this.Hide();
        }
    }
}
