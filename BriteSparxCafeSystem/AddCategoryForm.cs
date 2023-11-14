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
using System.Text.RegularExpressions;

namespace BriteSparxCafeSystem
{
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void AddCategoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupWst17DataSet.Category' table. You can move, or remove it, as needed.
            this.taCategory1.Fill(this.ds1.Category);
        }

        private void searchCategoryTextbox_TextChanged(object sender, EventArgs e)
        {
            taCategory2.FillByName(ds1.Category, searchCategoryTextbox.Text);
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(CategoryNametextBox.Text))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to add this category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection("removed for security"))
                        {
                            SqlCommand command = new SqlCommand("INSERT INTO Category (name) VALUES (@name)", con);
                            con.Open();
                            command.Parameters.AddWithValue("@name", CategoryNametextBox.Text);
                            command.ExecuteNonQuery();
                            MessageBox.Show(CategoryNametextBox.Text + " added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        CategoryNametextBox.Text = "";
                    }

                    categoryIDtextBox.Text = "";
                    CategoryNametextBox.Text = "";
                    ds1.Category.Rows.Clear();
                    this.taCategory1.Fill(this.ds1.Category);
                }
                else
                {
                    MessageBox.Show("Please enter a category name.", "Incomplete Information");
                }
            }
            catch
            {
                MessageBox.Show("Please enter digits on Category ID", "Invalid Input");
            }

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(categoryIDtextBox.Text) && !string.IsNullOrEmpty(CategoryNametextBox.Text))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to update this category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection("removed for security"))
                        {
                            SqlCommand command = new SqlCommand("UPDATE Category SET name = @name WHERE category_ID = @category_ID", con);
                            command.Parameters.AddWithValue("@category_ID", categoryIDtextBox.Text);
                            command.Parameters.AddWithValue("@name", CategoryNametextBox.Text);
                            con.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show(CategoryNametextBox.Text + " details updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        categoryIDtextBox.Text = "";
                        CategoryNametextBox.Text = "";
                    }

                    categoryIDtextBox.Text = "";
                    CategoryNametextBox.Text = "";
                    this.taCategory1.Fill(this.ds1.Category);
                }
                else
                {
                    MessageBox.Show("Please enter both Category ID and Category Name.", "Incomplete Information");
                }
            }
            catch
            {
                MessageBox.Show("Please enter digits on Category ID", "Invalid Input");
            }


        }


        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(categoryIDtextBox.Text))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to archive this category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection("removed for security"))
                        {
                            con.Open();
                            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Category WHERE category_ID=@category_ID", con);
                            selectCommand.Parameters.AddWithValue("@category_ID", int.Parse(categoryIDtextBox.Text));
                            SqlDataReader reader = selectCommand.ExecuteReader();

                            if (reader.Read())
                            {
                                int categoryID = reader.GetInt32(reader.GetOrdinal("category_ID"));
                                string categoryName = reader.GetString(reader.GetOrdinal("name"));
                                reader.Close();

                                SqlCommand archiveCommand = new SqlCommand("INSERT INTO ArchivedCategory (category_ID, category_name, archived_date) VALUES (@category_ID, @category_name, GETDATE())", con);
                                archiveCommand.Parameters.AddWithValue("@category_ID", categoryID);
                                archiveCommand.Parameters.AddWithValue("@category_name", categoryName);
                                archiveCommand.ExecuteNonQuery();

                                SqlCommand deleteCommand = new SqlCommand("DELETE FROM Category WHERE category_ID=@category_ID", con);
                                deleteCommand.Parameters.AddWithValue("@category_ID", categoryID);
                                deleteCommand.ExecuteNonQuery();
                                MessageBox.Show(categoryName + " archived successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                reader.Close();
                                MessageBox.Show("Category not found", "Error");
                            }

                            categoryIDtextBox.Text = "";
                            this.taCategory1.Fill(this.ds1.Category);
                        }
                    }
                    else
                    {
                        categoryIDtextBox.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the Category ID", "Incomplete Information");
                }
            }
            catch
            {
                MessageBox.Show("Cannot archive this category as it is already associated some menus", "Error");
            }

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("removed for security");
                con.Open();
                SqlCommand command = new SqlCommand("Select * from Category where category_ID=@category_ID", con);
                command.Parameters.AddWithValue("@category_ID", int.Parse(categoryIDtextBox.Text));
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvCategory.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Please enter digits on Category ID");
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            categoryIDtextBox.Text = "";
            CategoryNametextBox.Text = "";
            taCategory2.FillByName(ds1.Category, searchCategoryTextbox.Text);
            this.taCategory1.Fill(this.ds1.Category);
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void categoryIDtextBox_TextChanged(object sender, EventArgs e)
        {
            string iD = categoryIDtextBox.Text.Trim();
            categoryIDtextBox.ReadOnly = true;

            // Define a regular expression pattern for a phone number containing only digits (numbers)
            string pattern = "^[0-9]+$";

            if (!Regex.IsMatch(iD, pattern) && categoryIDtextBox.Text != "")
            {
                // The input does not match the desired format (contains letters or other characters), display an error message
                MessageBox.Show("Enter only digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Set the focus back to the PhoneNumbermaskedTextBox
                categoryIDtextBox.Focus();
                categoryIDtextBox.Text = "";
                // Cancel the event to prevent moving to the next control
                //e.Cancel = true;
            }
        }

        private void CategoryNametextBox_TextChanged(object sender, EventArgs e)
        {
            string firstName = CategoryNametextBox.Text.Trim();
           

            // Define a regular expression pattern for a name starting with a capital letter and followed by letters only
            string pattern = "^[A-Z][a-zA-Z]*$";

            if (!Regex.IsMatch(firstName, pattern) && CategoryNametextBox.Text != "")
            {
                // The input does not match the desired format, display an error message
                MessageBox.Show("Menu Name should start with a capital letter and contain letters only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Set the focus back to the FirstNameTextBox
                CategoryNametextBox.Focus();
                CategoryNametextBox.Text = "";
                // Cancel the event to prevent moving to the next control
                //e.Cancel = true;
            }
        }

        private void gvCategory_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            categoryIDtextBox.Text = gvCategory.CurrentRow.Cells[0].Value.ToString();
            CategoryNametextBox.Text = gvCategory.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
