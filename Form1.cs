using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace Thread
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbconfirm_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\2nd sem all\Thread\Thread\Database2.mdf"";Integrated Security=True";

            SqlConnection cn = new SqlConnection(connectionString);

                cn.Open();
        }

        private void btnloginform_Click(object sender, EventArgs e)
        {
            this.Hide();                  // Hide the current registration form
            LoginForm loginForm = new LoginForm(); // Create an object of the login form
            loginForm.ShowDialog();        // Show the login form
            
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            if (txtusername.Text != string.Empty &&
                txtemail.Text != string.Empty &&
                txtpassword.Text != string.Empty &&
                txtconfirmpassword.Text != string.Empty)
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\2nd sem all\Thread\Thread\Database2.mdf"";Integrated Security=True";
                    SqlConnection cn = new SqlConnection(connectionString);

                    try
                    {
                        cn.Open();

                        // Check if username exists
                        SqlCommand cmd = new SqlCommand("SELECT * FROM LoginTable2 WHERE username = @username", cn);
                        cmd.Parameters.AddWithValue("@username", txtusername.Text);

                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("Username already exists, please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dr.Close();
                            // Insert new user with email
                            cmd = new SqlCommand("INSERT INTO LoginTable2 (username, password, email) VALUES (@username, @password, @email)", cn);
                            cmd.Parameters.AddWithValue("@username", txtusername.Text);
                            cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                            cmd.Parameters.AddWithValue("@email", txtemail.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Your account is created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        cn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the same password in both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter values in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
                txtconfirmpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
                txtconfirmpassword.UseSystemPasswordChar = true;
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconfirmpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbuser_Click(object sender, EventArgs e)
        {

        }

        private void lbemail_Click(object sender, EventArgs e)
        {

        }
    }
}
