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
    public partial class LoginForm : Form
    {
        DBConnect DBCon = new DBConnect();
        SqlCommand command = new SqlCommand();
        public static string sellername;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label_Exit_MouseHover(object sender, EventArgs e)
        {
            label_Exit.ForeColor = Color.Red;

        }

        private void label_Exit_MouseLeave(object sender, EventArgs e)
        {
            label_Exit.ForeColor = Color.Teal;
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void label_Clear_MouseEnter(object sender, EventArgs e)
        {
            label_Clear.ForeColor = Color.Red;
        }

        private void label_Clear_MouseLeave(object sender, EventArgs e)
        {
            label_Clear.ForeColor = Color.Teal;
        }

        private void label_Clear_Click(object sender, EventArgs e)
        {
            TextBox_Password.Clear();
            TextBox_User_Name.Clear();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            if (comboBox_SelectRole.SelectedIndex > -1)
            {
                if (comboBox_SelectRole.SelectedItem.ToString() == "Admin")
                {
                    if (TextBox_User_Name.Text == "Abdallah" && TextBox_Password.Text == "40506827")
                    {
                        ProductForm productForm = new ProductForm();
                        productForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        label_wrong.Text = "If you Admin please enter ";
                        label_wong2.ForeColor = Color.Red;

                        label_wrong.ForeColor = Color.Red;
                        label_wong2.Text = "correct Username and Password";

                    }
                }
                if(TextBox_User_Name.Text==""&& TextBox_Password.Text != "")
                {
                    label_wrong.Text = "Please enter username";
                    label_wrong.ForeColor = Color.Red;
                    label_wong2.Text = "";
                }
                else if(TextBox_Password.Text==""&& TextBox_User_Name.Text != "")
                {
                    label_wrong.Text = "Please enter password";
                    label_wrong.ForeColor = Color.Red;
                    label_wong2.Text = "";
                }
                else if (TextBox_Password.Text == ""&& TextBox_User_Name.Text == "")
                {
                    label_wrong.Text = "Please enter username and password";
                    label_wrong.ForeColor = Color.Red;
                    label_wong2.Text = "";
                }
                else
                {
                    string selectQuery;
                    selectQuery = "SELECT * FROM Seller WHERE seller_Name='" + TextBox_User_Name.Text + "' AND seller_Pass='" + TextBox_Password.Text + "'";
                    DataTable dt = new DataTable();
                    command.CommandText = selectQuery;
                    command.Connection = DBCon.GetConnection();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        sellername = TextBox_User_Name.Text;
                        SellingForm sellingForm = new SellingForm();
                        sellingForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        label_wrong.Text = "Username or Password is incorrect";
                        label_wrong.ForeColor = Color.Red;
                        label_wong2.Text = "";
                    }
                }
            }
            else
            {
                label_wrong.Text = "Please select Role";
                label_wrong.ForeColor = Color.Red;
            }
        }

        private void TextBox_User_Name_TextChanged(object sender, EventArgs e)
        {
            label_wong2.Text = "";
            label_wrong.Text = "";
        }

        private void TextBox_Password_TextChanged(object sender, EventArgs e)
        {
            label_wong2.Text = "";
            label_wrong.Text = "";
        }

        private void comboBox_SelectRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_wong2.Text = "";
            label_wrong.Text = "";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
