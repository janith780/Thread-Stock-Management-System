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
    public partial class Home : Form
    {
        string userRole;
        public Home(string userRole)
        {
            InitializeComponent();
            this.userRole = userRole;
        }

        private void lbcolor_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }



        

        private void Home_Load(object sender, EventArgs e)
        {



            if (string.IsNullOrEmpty(userRole))
            {
                userRole = "user"; // default to user
            }

            if (userRole != "admin")
            {
                // Disable full access for non-admin users

                // Disable all tabs except allowed ones
                tabControl1.TabPages.Remove(entGRN);
                tabControl1.TabPages.Remove(returnthread);
                

                // Disable the "Issue" button
                btnissue.Enabled = false;
                btnwriteoff.Enabled = false;

                // (Optional) Disable other controls if needed
            }

            listView1.View = View.Details;
            listView1.Columns.Add("GRN Number", 100);
            listView1.Columns.Add("Article", 170);
            listView1.Columns.Add("Color", 170);
            listView1.Columns.Add("Qty", 70);
            listView1.Columns.Add("UOM", 70);
            listView1.Columns.Add("Location", 100);
            

            listView2.View = View.Details;
            listView2.Columns.Add("GRN Number", 100);
            listView2.Columns.Add("Article", 170);
            listView2.Columns.Add("Color", 170);
            listView2.Columns.Add("Qty", 70);
            listView2.Columns.Add("UOM", 70);
            listView2.Columns.Add("Location", 100);


    
        }

        private void entGRN_Click(object sender, EventArgs e)
        {

        }

        //grn enter button code
        private void btnenter_Click(object sender, EventArgs e)
        {
            
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\2nd sem all\Thread\Thread\Database2.mdf"";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                

                string query = "INSERT INTO GRN_Table (GRN_Number, GRN_Date, Merchant_Name, Article_Name, Supplier, Qty, UOM, Color, Location) " +
                               "VALUES (@GRN_Number, @GRN_Date, @Merchant_Name, @Article_Name, @Supplier, @Qty, @UOM, @Color, @Location)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@GRN_Number", txtgrnno.Text);
                cmd.Parameters.AddWithValue("@GRN_Date", grndatetime.Value);
                cmd.Parameters.AddWithValue("@Merchant_Name", txtmerchant.Text);
                cmd.Parameters.AddWithValue("@Article_Name", txtarticlenu.Text);
                cmd.Parameters.AddWithValue("@Supplier", txtsupplier.Text);
                cmd.Parameters.AddWithValue("@Qty", int.Parse(txtqty.Text));
                cmd.Parameters.AddWithValue("@UOM", txtuom.Text);
                cmd.Parameters.AddWithValue("@Color", txtcolor.Text);
                cmd.Parameters.AddWithValue("@Location", txtlocation.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("GRN Entered Successfully");
            }
        }

        //thread issue search button code
        private void searchforissue_Click(object sender, EventArgs e)
        {
            string color = txtcolorissu.Text.Trim();        
            string article = txtarticleiss.Text.Trim();    

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\2nd sem all\Thread\Thread\Database2.mdf"";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT GRN_Number, Article_Name, Color, Qty, UOM, Location FROM GRN_Table WHERE 1=1";

                if (!string.IsNullOrEmpty(color))
                    query += " AND Color LIKE @Color";

                if (!string.IsNullOrEmpty(article))
                    query += " AND Article_Name LIKE @Article";

                SqlCommand cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(color))
                    cmd.Parameters.AddWithValue("@Color", "%" + color + "%");

                if (!string.IsNullOrEmpty(article))
                    cmd.Parameters.AddWithValue("@Article", "%" + article + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["GRN_Number"].ToString());
                    item.SubItems.Add(reader["Article_Name"].ToString());
                    item.SubItems.Add(reader["Color"].ToString());
                    item.SubItems.Add(reader["Qty"].ToString());
                    item.SubItems.Add(reader["UOM"].ToString());
                    item.SubItems.Add(reader["Location"].ToString());
                    

                    listView1.Items.Add(item);
                }

                reader.Close();
            }
        }


        //thread issue select list code
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                txtSelectedGRN.Text = item.SubItems[0].Text; // GRN Number
                txtSelectedArticle.Text = item.SubItems[1].Text;
                txtSelectedColor.Text = item.SubItems[2].Text;
                txtAvailableQty.Text = item.SubItems[3].Text; // Existing Qty
            }
        }

        //thread issue button code

        private void btnissue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSelectedGRN.Text) ||
                    string.IsNullOrEmpty(txtissuqty.Text) ||
                    string.IsNullOrEmpty(styletx.Text))
            {
                MessageBox.Show("Please select an item, enter issue quantity, and style.");
                return;
            }

            if (!int.TryParse(txtissuqty.Text, out int issueQty))
            {
                MessageBox.Show("Invalid issue quantity.");
                return;
            }

            if (!int.TryParse(txtAvailableQty.Text, out int availableQty))
            {
                MessageBox.Show("Invalid available quantity.");
                return;
            }

            if (issueQty > availableQty)
            {
                MessageBox.Show("Issue quantity cannot be more than available quantity.");
                return;
            }

            int newQty = availableQty - issueQty;
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\2nd sem all\Thread\Thread\Database2.mdf"";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Update GRN_Table qty
                    string updateQuery = "UPDATE GRN_Table SET Qty = @NewQty WHERE GRN_Number = @GRN_Number AND Color = @Color";
                    using (SqlCommand cmd1 = new SqlCommand(updateQuery, conn, transaction))
                    {
                        cmd1.Parameters.AddWithValue("@NewQty", newQty);
                        cmd1.Parameters.AddWithValue("@GRN_Number", txtSelectedGRN.Text);
                        cmd1.Parameters.AddWithValue("@Color", txtSelectedColor.Text);
                        cmd1.ExecuteNonQuery();
                    }

                    // 2. Insert into ThreadIssue_Table
                    string insertQuery = @"INSERT INTO ThreadIssue_Table 
                (GRN_Number, Article, Color, Style, IssueQty, IssueDate) 
                VALUES (@GRN, @Article, @Color, @Style, @Qty, @Date)";
                    using (SqlCommand cmd2 = new SqlCommand(insertQuery, conn, transaction))
                    {
                        cmd2.Parameters.AddWithValue("@GRN", txtSelectedGRN.Text);
                        cmd2.Parameters.AddWithValue("@Article", txtSelectedArticle.Text);
                        cmd2.Parameters.AddWithValue("@Color", txtSelectedColor.Text);
                        cmd2.Parameters.AddWithValue("@Style", styletx.Text);
                        cmd2.Parameters.AddWithValue("@Qty", issueQty);
                        cmd2.Parameters.AddWithValue("@Date", DateTime.Now);
                        cmd2.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show("Thread issued and saved successfully!");

                    txtAvailableQty.Text = newQty.ToString();
                    txtissuqty.Clear();
                    styletx.Clear();
                    // Refresh ListView if needed
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtSelectedGRN_TextChanged(object sender, EventArgs e)
        {

        }

        //enter grn reset button code
        private void btnreset_Click(object sender, EventArgs e)
        {

            txtgrnno.Clear();
            grndatetime.Value = DateTime.Now; // reset to today's date
            txtsupplier.Clear();
            txtarticlenu.Clear();
            txtcolor.Clear();
            txtuom.Clear();
            txtlocation.Clear();
            txtmerchant.Clear();
            txtqty.Clear();

            txtgrnno.Focus(); // set focus to first field
        }

        //return tab search button
        private void refilsearch_Click(object sender, EventArgs e)
        {
            string color = refilcolor.Text.Trim();        // Replace with your actual TextBox name
            string article = refilarticle.Text.Trim();    // Replace with your actual TextBox name

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\2nd sem all\Thread\Thread\Database2.mdf"";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT GRN_Number, Article_Name, Color, Qty, UOM, Location FROM GRN_Table WHERE 1=1";

                if (!string.IsNullOrEmpty(color))
                    query += " AND Color LIKE @Color";

                if (!string.IsNullOrEmpty(article))
                    query += " AND Article_Name LIKE @Article";

                SqlCommand cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(color))
                    cmd.Parameters.AddWithValue("@Color", "%" + color + "%");

                if (!string.IsNullOrEmpty(article))
                    cmd.Parameters.AddWithValue("@Article", "%" + article + "%");

                SqlDataReader reader = cmd.ExecuteReader();

                listView2.Items.Clear();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["GRN_Number"].ToString());
                    item.SubItems.Add(reader["Article_Name"].ToString());
                    item.SubItems.Add(reader["Color"].ToString());
                    item.SubItems.Add(reader["Qty"].ToString());
                    item.SubItems.Add(reader["UOM"].ToString());
                    item.SubItems.Add(reader["Location"].ToString());

                    listView2.Items.Add(item);
                }

                reader.Close();
            }
        }

        //return tab list select code
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem item = listView2.SelectedItems[0];

                rtxtSelectedGRN.Text = item.SubItems[0].Text; // GRN Number
                rtxtSelectedArticle.Text = item.SubItems[1].Text;
                rtxtSelectedColor.Text = item.SubItems[2].Text;
                rtxtAvailableQty.Text = item.SubItems[3].Text; // Existing Qty
            }
        }

        //return tab add button code
        private void refilladd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtSelectedGRN.Text) || string.IsNullOrEmpty(refillqty.Text))
            {
                MessageBox.Show("Please select an item and enter issue quantity.");
                return;
            }

            if (!int.TryParse(refillqty.Text, out int rfillQty))
            {
                MessageBox.Show("Issue quantity must be a number.");
                return;
            }

            if (!int.TryParse(rtxtAvailableQty.Text, out int ravailableQty))
            {
                MessageBox.Show("Available quantity is not a valid number.");
                return;
            }

            


            int newQty = ravailableQty + rfillQty;

            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\2nd sem all\Thread\Thread\Database2.mdf"";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                 

                string query = "UPDATE GRN_Table SET Qty = @NewQty WHERE GRN_Number = @GRN_Number AND Color = @Color";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NewQty", newQty);
                    cmd.Parameters.AddWithValue("@GRN_Number", rtxtSelectedGRN.Text);
                    cmd.Parameters.AddWithValue("@Color", rtxtSelectedColor.Text);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Quantity updated successfully!");
                        rtxtAvailableQty.Text = newQty.ToString();
                        refillqty.Clear();
                        // You might also want to refresh the ListView
                    }
                    else
                    {
                        MessageBox.Show("No matching GRN found to update.");
                    }
                }
            }
        }

        //writeoff filter button code

        private void btnfilter_Click(object sender, EventArgs e)
        {
            LoadWriteoffList();
        }
        private void LoadWriteoffList()
        {
            listViewWriteoff.Items.Clear(); // clear old items first

            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\2nd sem all\Thread\Thread\Database2.mdf"";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT GRN_Number, Article_Name, Color, Qty, GRN_Date FROM GRN_Table WHERE GRN_Date <= @cutoffDate";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cutoffDate", DateTime.Now.AddMonths(-6)); // 6 months before today

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["GRN_Number"].ToString());
                        item.SubItems.Add(reader["Article_Name"].ToString());
                        item.SubItems.Add(reader["Color"].ToString());
                        item.SubItems.Add(reader["Qty"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(reader["GRN_Date"]).ToShortDateString());

                        listViewWriteoff.Items.Add(item);
                    }

                    reader.Close();
                }
            }
        }
        
        //writeoff btn
        private void btnwriteoff_Click(object sender, EventArgs e)
        {
            if (listViewWriteoff.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to write off.");
                return;
            }

            ListViewItem item = listViewWriteoff.SelectedItems[0];

            string grn = item.SubItems[0].Text;
            string article = item.SubItems[1].Text;
            string color = item.SubItems[2].Text;
            int qty = int.Parse(item.SubItems[3].Text);
            DateTime grnDate = DateTime.Parse(item.SubItems[4].Text);

            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\2nd sem all\Thread\Thread\Database2.mdf"";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // 1. Insert into Writeoff_Table
                string insertQuery = "INSERT INTO Writeoff_Table (GRN_Number, Article, Color, Qty, GRN_Date) VALUES (@GRN, @Article, @Color, @Qty, @GRNDate)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@GRN", grn);
                    insertCmd.Parameters.AddWithValue("@Article", article);
                    insertCmd.Parameters.AddWithValue("@Color", color);
                    insertCmd.Parameters.AddWithValue("@Qty", qty);
                    insertCmd.Parameters.AddWithValue("@GRNDate", grnDate);
                    insertCmd.ExecuteNonQuery();
                }

                // 2. Delete from GRN_Table
                string deleteQuery = @"DELETE FROM GRN_Table 
                       WHERE GRN_Number = @GRN 
                       AND Article_Name = @Article 
                       AND Color = @Color 
                       AND CAST(GRN_Date AS DATE) = @GRNDate";

                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                {
                    deleteCmd.Parameters.AddWithValue("@GRN", grn);
                    deleteCmd.Parameters.AddWithValue("@Article", article);
                    deleteCmd.Parameters.AddWithValue("@Color", color);
                    deleteCmd.Parameters.AddWithValue("@GRNDate", grnDate);

                    int rows = deleteCmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Item written off successfully.");
                        listViewWriteoff.Items.Remove(item); // remove from list
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the item.");
                    }
                }
            }
        }

        //logoutbtn
        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();                  // Hide the current registration form
            LoginForm loginForm = new LoginForm(); // Create an object of the login form
            loginForm.ShowDialog();
        }

        private void LoadLowStockItems()
        {
            listViewLowStock.Items.Clear();

            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\2nd sem all\Thread\Thread\Database2.mdf"";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT GRN_Number, Article_Name, Color, Merchant_Name, Qty FROM GRN_Table WHERE Qty < 5";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["GRN_Number"].ToString());
                        item.SubItems.Add(reader["Article_Name"].ToString());
                        item.SubItems.Add(reader["Color"].ToString());
                        item.SubItems.Add(reader["Qty"].ToString());
                        item.SubItems.Add(reader["Merchant_Name"].ToString());

                        listViewLowStock.Items.Add(item);
                    }
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == alert)
            {
                LoadLowStockItems();
            }
        }
    }
}

