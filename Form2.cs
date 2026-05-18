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

namespace Thread
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lgtxtusername_Click(object sender, EventArgs e)
        {

        }

        private void btnregisterform_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm Register_FormForm = new RegisterForm();
            Register_FormForm.ShowDialog();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\2nd sem all\Thread\Thread\Database2.mdf"";Integrated Security=True";

            SqlConnection cn = new SqlConnection(connectionString);

            cn.Open();
        }

        private void btnloginhome_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != string.Empty && txtenterpw.Text != string.Empty)
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\2nd sem all\Thread\Thread\Database2.mdf"";Integrated Security=True";
                SqlConnection cn = new SqlConnection(connectionString);

                try
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LoginTable2 WHERE username = @username AND password = @password", cn);
                    cmd.Parameters.AddWithValue("@username", txtuser.Text);
                    cmd.Parameters.AddWithValue("@password", txtenterpw.Text);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        string role = dr["role"].ToString();
                        dr.Close();
                        cn.Close();

                        this.Hide();
                        Home home = new Home(role);
                        home.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please enter username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtenterpw.UseSystemPasswordChar = false;
            }
            else
            {
                txtenterpw.UseSystemPasswordChar= true;
            }
        }
    }
}
