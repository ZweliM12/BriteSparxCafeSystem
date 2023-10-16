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
    public partial class AddMenuForm : Form
    {
        public AddMenuForm()
        {
            InitializeComponent();
        }

        private void AddMenuForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds1.Sales_Menu' table. You can move, or remove it, as needed.
            this.sales_MenuTableAdapter.Fill(this.ds1.Sales_Menu);
            // TODO: This line of code loads data into the 'ds1.MenuUpdated' table. You can move, or remove it, as needed.
            this.menuUpdatedTableAdapter.Fill(this.ds1.MenuUpdated);
            // TODO: This line of code loads data into the 'ds1.OrderItem' table. You can move, or remove it, as needed.
            this.taOrderItem.Fill(this.ds1.OrderItem);

        }

        private void searchMenuTextbox_TextChanged(object sender, EventArgs e)
        {
            menuUpdatedTableAdapter.FillByName(ds1.MenuUpdated, searchMenuTextbox.Text);
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            int categoryID;
            try
            {
                if (!string.IsNullOrEmpty(categorycomboBox.Text) && !string.IsNullOrEmpty(MenuNametextBox.Text) && !string.IsNullOrEmpty(MenuDescripTextbox.Text) && !string.IsNullOrEmpty(MenuPricetextBox.Text) && !string.IsNullOrEmpty(QOHtextBox.Text))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to add this menu?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupWst17;User ID=GroupWst17;Password=w31v7"))
                        {
                            SqlCommand command = new SqlCommand("INSERT INTO Menu (category_ID, name, description, price, quantity_on_hand) VALUES (@category_ID, @name, @description, @price, @quantity_on_hand)", con);
                            con.Open();

                            switch (categorycomboBox.SelectedItem)
                            {
                                case "MEALS":
                                    categoryID = 200;
                                    command.Parameters.AddWithValue("@category_ID", categoryID);
                                    command.Parameters.AddWithValue("@name", MenuNametextBox.Text);
                                    command.Parameters.AddWithValue("@description", MenuDescripTextbox.Text);
                                    command.Parameters.AddWithValue("@price", MenuPricetextBox.Text);
                                    command.Parameters.AddWithValue("@quantity_on_hand", QOHtextBox.Text);

                                    command.ExecuteNonQuery();
                                    MessageBox.Show(MenuNametextBox.Text + " with the price of R" + MenuPricetextBox.Text + " added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                case "DRINKS":
                                    categoryID = 201;
                                    command.Parameters.AddWithValue("@category_ID", categoryID);
                                    command.Parameters.AddWithValue("@name", MenuNametextBox.Text);
                                    command.Parameters.AddWithValue("@description", MenuDescripTextbox.Text);
                                    command.Parameters.AddWithValue("@price", MenuPricetextBox.Text);
                                    command.Parameters.AddWithValue("@quantity_on_hand", QOHtextBox.Text);

                                    command.ExecuteNonQuery();
                                    MessageBox.Show(MenuNametextBox.Text + " with the price of " + MenuPricetextBox.Text + " added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    break;
                                case "SPECIALTIES":
                                    categoryID = 202;
                                    command.Parameters.AddWithValue("@category_ID", categoryID);
                                    command.Parameters.AddWithValue("@name", MenuNametextBox.Text);
                                    command.Parameters.AddWithValue("@description", MenuDescripTextbox.Text);
                                    command.Parameters.AddWithValue("@price", MenuPricetextBox.Text);
                                    command.Parameters.AddWithValue("@quantity_on_hand", QOHtextBox.Text);

                                    command.ExecuteNonQuery();
                                    MessageBox.Show(MenuNametextBox.Text + " with the price of " + MenuPricetextBox.Text + " added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    break;
                                case "SANDWICHES":
                                    categoryID = 203;
                                    command.Parameters.AddWithValue("@category_ID", categoryID);
                                    command.Parameters.AddWithValue("@name", MenuNametextBox.Text);
                                    command.Parameters.AddWithValue("@description", MenuDescripTextbox.Text);
                                    command.Parameters.AddWithValue("@price", MenuPricetextBox.Text);
                                    command.Parameters.AddWithValue("@quantity_on_hand", QOHtextBox.Text);

                                    command.ExecuteNonQuery();
                                    MessageBox.Show(MenuNametextBox.Text + " with the price of " + MenuPricetextBox.Text + " added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    break;
                                case "DESSERTS":
                                    categoryID = 205;
                                    command.Parameters.AddWithValue("@category_ID", categoryID);
                                    command.Parameters.AddWithValue("@name", MenuNametextBox.Text);
                                    command.Parameters.AddWithValue("@description", MenuDescripTextbox.Text);
                                    command.Parameters.AddWithValue("@price", MenuPricetextBox.Text);
                                    command.Parameters.AddWithValue("@quantity_on_hand", QOHtextBox.Text);

                                    command.ExecuteNonQuery();
                                    MessageBox.Show(MenuNametextBox.Text + " with the price of " + MenuPricetextBox.Text + " added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    break;
                                case "SNACKS":
                                    categoryID = 208;
                                    command.Parameters.AddWithValue("@category_ID", categoryID);
                                    command.Parameters.AddWithValue("@name", MenuNametextBox.Text);
                                    command.Parameters.AddWithValue("@description", MenuDescripTextbox.Text);
                                    command.Parameters.AddWithValue("@price", MenuPricetextBox.Text);
                                    command.Parameters.AddWithValue("@quantity_on_hand", QOHtextBox.Text);

                                    command.ExecuteNonQuery();
                                    MessageBox.Show(MenuNametextBox.Text + " with the price of R" + MenuPricetextBox.Text + " added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    break;
                            }

                        }
                    }
                    else
                    {
                        categorycomboBox.Text = "";
                        MenuNametextBox.Text = "";
                        MenuDescripTextbox.Text = "";
                        MenuPricetextBox.Text = "";
                        QOHtextBox.Text = "";
                    }
                    menuIDtextBox.Text = "";
                    categorycomboBox.Text = "";
                    MenuNametextBox.Text = "";
                    MenuDescripTextbox.Text = "";
                    MenuPricetextBox.Text = "";
                    QOHtextBox.Text = "";
                    this.taMenu1.Fill(this.ds1.Menu);
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields.", "Incomplete Information");
                }
            }
            catch
            {
                MessageBox.Show("Please enter digits for category ID, QOH and double for price", "Invalid Input");
            }

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                    DialogResult result = MessageBox.Show("Are you sure you want to update this menu?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupWst17;User ID=GroupWst17;Password=w31v7"))
                        {
                            con.Open();

                            string updateQuery = "UPDATE Menu SET ";
                            List<string> updateFields = new List<string>();

                            if (!string.IsNullOrEmpty(MenuNametextBox.Text))
                            {
                                updateFields.Add("name = @name");
                            }

                        if (!string.IsNullOrEmpty(MenuDescripTextbox.Text))
                        {
                            updateFields.Add("description = @description");
                        }

                            if (!string.IsNullOrEmpty(MenuPricetextBox.Text))
                            {
                                updateFields.Add("price = @price");
                            }

                            if (!string.IsNullOrEmpty(QOHtextBox.Text))
                            {
                                updateFields.Add("quantity_on_hand = @quantity_on_hand");
                            }

                            if (updateFields.Count > 0)
                            {
                                updateQuery += string.Join(", ", updateFields);
                                updateQuery += " WHERE menu_ID = @menu_ID";

                                SqlCommand command = new SqlCommand(updateQuery, con);
                                command.Parameters.Add("@menu_ID", SqlDbType.Int).Value = int.Parse(menuIDtextBox.Text);

                                if (!string.IsNullOrEmpty(MenuNametextBox.Text))
                                {
                                    command.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = MenuNametextBox.Text;
                                }

                            if (!string.IsNullOrEmpty(MenuNametextBox.Text))
                            {
                                command.Parameters.Add("@description", SqlDbType.VarChar, 100).Value = MenuDescripTextbox.Text;
                            }

                            if (!string.IsNullOrEmpty(MenuPricetextBox.Text))
                                {
                                    command.Parameters.Add("@price", SqlDbType.Float).Value = double.Parse(MenuPricetextBox.Text);
                                }

                                if (!string.IsNullOrEmpty(QOHtextBox.Text))
                                {
                                    command.Parameters.Add("@quantity_on_hand", SqlDbType.Int).Value = int.Parse(QOHtextBox.Text);
                                }

                                command.ExecuteNonQuery();
                                MessageBox.Show("Menu updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No changes were made. Please fill in at least one field to update.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        menuIDtextBox.Text = "";
                        categorycomboBox.Text = "";
                        MenuNametextBox.Text = "";
                    MenuDescripTextbox.Text = "";
                    MenuPricetextBox.Text = "";
                        QOHtextBox.Text = "";
                    }
                this.menuUpdatedTableAdapter.Fill(this.ds1.MenuUpdated);
                gvMenuUpdated.Refresh();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid digits for Price, and QOH.", "Invalid Input");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(menuIDtextBox.Text))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to archive this menu?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=146.230.177.46;Initial Catalog=GroupWst17;User ID=GroupWst17;Password=w31v7"))
                        {
                            con.Open();
                            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Menu WHERE menu_ID=@menu_ID", con);
                            selectCommand.Parameters.AddWithValue("@menu_ID", int.Parse(menuIDtextBox.Text));
                            SqlDataReader reader = selectCommand.ExecuteReader();

                            if (reader.Read())
                            {
                                int menuID = reader.GetInt32(reader.GetOrdinal("menu_ID"));
                                string menuName = reader.GetString(reader.GetOrdinal("name"));
                                reader.Close();

                                SqlCommand archiveCommand = new SqlCommand("INSERT INTO ArchivedMenu (menu_ID, menu_name, archived_date) VALUES (@menu_ID, @menu_name, GETDATE())", con);
                                archiveCommand.Parameters.AddWithValue("@menu_ID", menuID);
                                archiveCommand.Parameters.AddWithValue("@menu_name", menuName);
                                archiveCommand.ExecuteNonQuery();

                                SqlCommand deleteCommand = new SqlCommand("DELETE FROM Menu WHERE menu_ID=@menu_ID", con);
                                deleteCommand.Parameters.AddWithValue("@menu_ID", menuID);
                                deleteCommand.ExecuteNonQuery();
                                MessageBox.Show(menuName + " archived successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                reader.Close();
                                MessageBox.Show("Menu item not found", "Error");
                            }
                        }
                    }
                    else
                    {
                        menuIDtextBox.Text = "";
                    }
                    menuIDtextBox.Text = "";
                    this.taMenu1.Fill(this.ds1.Menu);
                }
                else
                {
                    MessageBox.Show("Please enter a valid menu ID", "Invalid Input");
                }
            }
            catch
            {
                MessageBox.Show("Cannot archive this menu it is associated with order items", "Error");
            }

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming ds1 is your DataSet object.
                GroupWst17DataSet.MenuUpdatedDataTable menuUpdatedTable = this.ds1.MenuUpdated;

                // Use a DataView to filter rows based on the MenuName column.
                DataView dv = new DataView(menuUpdatedTable);

                // Apply the filter based on the text entered in MenuNametextBox.
                if (!string.IsNullOrEmpty(MenuNametextBox.Text))
                {
                    dv.RowFilter = "MenuName LIKE '%" + MenuNametextBox.Text + "%'";
                }
                else if (!string.IsNullOrEmpty(categorycomboBox.Text))
                {
                    dv.RowFilter = "CategoryName LIKE '%" + categorycomboBox.Text + "%'";
                }
                else
                {
                    // Clear the filter if the TextBox is empty.
                    dv.RowFilter = string.Empty;
                }

                // Bind the filtered DataView to your DataGridView.
                gvMenuUpdated.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching: " + ex.Message);
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            GroupWst17DataSet.MenuUpdatedDataTable menuUpdatedTable = this.ds1.MenuUpdated;
            DataView dv = new DataView(menuUpdatedTable);

            menuIDtextBox.Text = "";
            categorycomboBox.Text = "";
            MenuNametextBox.Text = "";
            MenuDescripTextbox.Text = "";
            MenuPricetextBox.Text = "";
            QOHtextBox.Text = "";

            if (string.IsNullOrEmpty(MenuNametextBox.Text))
            {
                dv.RowFilter = string.Empty;
            }

            //ds1.Menu.Rows.Clear();
            taMenu2.FillByName(ds1.Menu, searchMenuTextbox.Text);
            this.taOrderItem.Fill(this.ds1.OrderItem);
            this.sales_MenuTableAdapter.Fill(this.ds1.Sales_Menu);
            this.menuUpdatedTableAdapter.Fill(this.ds1.MenuUpdated);
        }

        private void updateQOHbutton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update quantity?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int v1 = int.Parse(updateQOHtextBox.Text);
                    int v2 = int.Parse(gvMenuUpdated.CurrentRow.Cells[5].Value.ToString());
                    int v3 = v1 + v2;

                    if (v3 >= 0)
                    {
                        menuUpdatedTableAdapter.UpdateQOH(int.Parse(updateQOHtextBox.Text), int.Parse(gvMenuUpdated.CurrentRow.Cells[0].Value.ToString())).ToString();
                        menuUpdatedTableAdapter.FillByName(ds1.MenuUpdated, gvMenuUpdated.CurrentRow.Cells[0].ToString());
                        this.menuUpdatedTableAdapter.Fill(this.ds1.MenuUpdated);
                    }
                    else
                    {
                        MessageBox.Show("QOH cannot be less than zero");
                    }
                }
                else
                {
                    updateQOHtextBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuNametextBox_TextChanged(object sender, EventArgs e)
        {
            string MenuName = MenuNametextBox.Text.Trim();

            // Define a regular expression pattern for a name starting with a capital letter and followed by letters only
            string pattern = @"^[A-Z][a-zA-Z\s]*$";

            if (!Regex.IsMatch(MenuName, pattern) && MenuNametextBox.Text != "")
            {
                // The input does not match the desired format, display an error message
                MessageBox.Show("Menu Name should start with a capital letter and contain letters only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Set the focus back to the FirstNameTextBox
                MenuNametextBox.Focus();
                MenuNametextBox.Text = "";
                // Cancel the event to prevent moving to the next control
                //e.Cancel = true;
            }
        }

        private void MenuPricetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuIDtextBox_TextChanged(object sender, EventArgs e)
        {
            string iD = menuIDtextBox.Text.Trim();
            menuIDtextBox.ReadOnly = true;

            // Define a regular expression pattern for a phone number containing only digits (numbers)
            string pattern = "^[0-9]+$";

            if (!Regex.IsMatch(iD, pattern) && menuIDtextBox.Text != "")
            {
                // The input does not match the desired format (contains letters or other characters), display an error message
                MessageBox.Show("Enter only digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Set the focus back to the PhoneNumbermaskedTextBox
                menuIDtextBox.Focus();
                menuIDtextBox.Text = "";
                // Cancel the event to prevent moving to the next control
                //e.Cancel = true;
            }
        }

        private void gvMenuUpdated_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            menuIDtextBox.Text = gvMenuUpdated.CurrentRow.Cells[0].Value.ToString();
            categorycomboBox.Text = gvMenuUpdated.CurrentRow.Cells[1].Value.ToString();
            MenuNametextBox.Text = gvMenuUpdated.CurrentRow.Cells[2].Value.ToString();
            MenuDescripTextbox.Text = gvMenuUpdated.CurrentRow.Cells[3].Value.ToString();
            MenuPricetextBox.Text = gvMenuUpdated.CurrentRow.Cells[4].Value.ToString();
            QOHtextBox.Text = gvMenuUpdated.CurrentRow.Cells[5].Value.ToString();  
        }

        private void gvMenuUpdated_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int menuID = 0;
                menuID = (int)gvMenuUpdated.CurrentRow.Cells[0].Value;
                sales_MenuTableAdapter.FillByMenuID(ds1.Sales_Menu, menuID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
