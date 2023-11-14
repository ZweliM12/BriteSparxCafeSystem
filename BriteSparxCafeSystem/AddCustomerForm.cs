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
using System.Globalization;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace BriteSparxCafeSystem
{

    public partial class AddCustomerForm : Form
    {
        private ErrorProvider errorProvider;
        public static string to;
        public AddCustomerForm()
        {
            InitializeComponent();
            InitializeErrorProvider();
        }

        private void AddNewCustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds1.MenuUpdated' table. You can move, or remove it, as needed.
            this.menuUpdatedTableAdapter.Fill(this.ds1.MenuUpdated);
            // TODO: This line of code loads data into the 'ds1.MenuTotalUpdated' table. You can move, or remove it, as needed.
            this.menuTotalUpdatedTableAdapter.Fill(this.ds1.MenuTotalUpdated);
            // TODO: This line of code loads data into the 'ds1.OrderDetailsUpdated' table. You can move, or remove it, as needed.
            this.orderDetailsUpdatedTableAdapter.Fill(this.ds1.OrderDetailsUpdated);
            // TODO: This line of code loads data into the 'ds1.OrderTableUpdated' table. You can move, or remove it, as needed.
            this.orderTableUpdatedTableAdapter.Fill(this.ds1.OrderTableUpdated);
            // TODO: This line of code loads data into the 'ds1.MenuTotal' table. You can move, or remove it, as needed.
            this.menuTotalTableAdapter.Fill(this.ds1.MenuTotal);
            // TODO: This line of code loads data into the 'ds1.Menu' table. You can move, or remove it, as needed.
            this.taMenu1.Fill(this.ds1.Menu);
            // TODO: This line of code loads data into the 'groupWst17DataSet.OrderTable' table. You can move, or remove it, as needed.
            this.taOrder1.Fill(this.ds1.OrderTable);
            // TODO: This line of code loads data into the 'groupWst17DataSet.Customer' table. You can move, or remove it, as needed.
            this.taCustomer1.Fill(this.ds1.Customer);
            // TODO: This line of code loads data into the 'groupWst17DataSet.Customer' table. You can move, or remove it, as needed.
            this.taOrderItem1.Fill(this.ds1.OrderItem);

        }
        private void AddToOrderbutton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal orderTotal = 0;
                DataRow dr;
                dr = ds1.MenuTotal.NewRow();
                for (int i = 0; i < gvMenu.Rows.Count; i++)
                {
                    if (gvMenu.Rows[i].Cells[6].Value != null)
                    {
                        dr[0] = gvMenu.Rows[i].Cells[0].Value;
                        dr[1] = gvMenu.Rows[i].Cells[1].Value;
                        dr[2] = gvMenu.Rows[i].Cells[2].Value;
                        dr[3] = gvMenu.Rows[i].Cells[4].Value;
                        dr[4] = gvMenu.Rows[i].Cells[6].Value;
                    }

                }

                int rowIndex = gvMenu.CurrentRow.Index;
                int qohColumnIndex = 5;
                int quantitySoldColumnIndex = 6;

                int qoh = int.Parse(gvMenu.Rows[rowIndex].Cells[qohColumnIndex].Value.ToString());
                int quantitySold = int.Parse(gvMenu.Rows[rowIndex].Cells[quantitySoldColumnIndex].Value.ToString());

                int updatedQOH = qoh - quantitySold;

                if (updatedQOH < 0)
                {
                    MessageBox.Show("Cannot add this item. Insufficient quantity in stock.");
                    return; // Stop further execution
                }

                gvMenu.Rows[rowIndex].Cells[qohColumnIndex].Value = updatedQOH;

                ds1.MenuTotal.Rows.Add(dr);

                for (int i = 0; i < ds1.MenuTotal.Rows.Count; i++)
                {
                    if (ds1.MenuTotal.Rows.Count > 0)
                    {
                        orderTotal += decimal.Parse(ds1.MenuTotal.Rows[i][3].ToString()) * int.Parse(ds1.MenuTotal.Rows[i][4].ToString());
                    }
                }

                gvMenu.Refresh();
                orderTotaltextBox.Text = orderTotal.ToString("c");
                finalizeOrderbutton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            taCustomer2.FillBySurname(ds1.Customer, searchCustTextbox.Text);
        }


        private void InitializeErrorProvider()
        {
            errorProvider = new ErrorProvider();
            //errorProvider.Icon = Properties.Resources.error_icon;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            // Clear any previous error messages
            errorProvider.Clear();

            if (AllFieldsValid())
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("removed for security"))
                    {
                        using (SqlCommand command = new SqlCommand("INSERT INTO Customer (fname, lname, phone_number, email, category, username, password, address, imageUrl, postCode, createdDate) VALUES (@fname, @lname, @phone_number, @email, @category, @username, @password, @address, @imageUrl, @postCode, @createdDate)", con))
                        {
                            con.Open();
                            command.Parameters.AddWithValue("@fname", firstNametextBox.Text);
                            command.Parameters.AddWithValue("@lname", LastNametextBox.Text);
                            command.Parameters.AddWithValue("@phone_number", PhoneNumbermaskedTextBox.Text);
                            command.Parameters.AddWithValue("@email", EmailtextBox.Text);
                            command.Parameters.AddWithValue("@category", categoryComboBox.Text);
                            
                            // Generate random username and password
                            string username = GenerateRandomUsername();
                            string password = GenerateRandomPassword();
                            // Send username and password to the provided email
                           SendCredentialsToEmail(username, password, EmailtextBox.Text);
                            // Add username and password to the database
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password);
                            command.Parameters.AddWithValue("@address", null);
                            command.Parameters.AddWithValue("@imageUrl", null);
                            command.Parameters.AddWithValue("@postCode", null);
                            command.Parameters.AddWithValue("@createdDate", DateTime.Now);

                            command.ExecuteNonQuery();
                            MessageBox.Show(firstNametextBox.Text + " " + LastNametextBox.Text + " added successfully", "New Customer");
                        }
                    }

                    // Clear textboxes after successful insertion
                    ClearTextBoxes();
                    this.taCustomer1.Fill(this.ds1.Customer);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding the customer: " + ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.", "Incomplete Information");
            }

        }

        private bool AllFieldsValid()
        {
            bool isValid = true;

            // Validate first name
            if (string.IsNullOrWhiteSpace(firstNametextBox.Text))
            {
                errorProvider.SetError(firstNametextBox, "Please enter a valid first name.");
                isValid = false;
            }

            // Validate last name
            if (string.IsNullOrWhiteSpace(LastNametextBox.Text))
            {
                errorProvider.SetError(LastNametextBox, "Please enter a valid last name.");
                isValid = false;
            }

            // Validate phone number
            string phoneNumber = PhoneNumbermaskedTextBox.Text;
            if (string.IsNullOrWhiteSpace(phoneNumber) || !phoneNumber.StartsWith("0"))
            {
                errorProvider.SetError(PhoneNumbermaskedTextBox, "Please enter a valid phone number starting with zero.");
                isValid = false;
            }

            // Validate email
            string email = EmailtextBox.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
            {
                errorProvider.SetError(EmailtextBox, "Please enter a valid email address.");
                isValid = false;
            }

            // Validate category
            if (string.IsNullOrWhiteSpace(categoryComboBox.Text))
            {
                errorProvider.SetError(categoryComboBox, "Please select a category.");
                isValid = false;
            }

            return isValid;
        }

        private bool IsValidEmail(string email)
        {
            // Check if the email ends with "@gmail.com" or "@ukzn.ac.za"
            return email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase) ||
                   email.EndsWith("@ukzn.ac.za", StringComparison.OrdinalIgnoreCase);
        }


        private void ClearTextBoxes()
        {
            firstNametextBox.Text = "";
            LastNametextBox.Text = "";
            PhoneNumbermaskedTextBox.Text = "";
            EmailtextBox.Text = "";
            categoryComboBox.Text = "";
        }
        
        private string GenerateRandomUsername()
        {

            return $"{firstNametextBox.Text.ToLower()}{LastNametextBox.Text.ToLower()}{new Random().Next(1000, 9999)}";
        }

        private string GenerateRandomPassword()
        { 
            return $"{firstNametextBox.Text.ToLower().Substring(0,3)}{LastNametextBox.Text.ToLower().Substring(0, 3)}{new Random().Next(1000, 9999)}";
        }


        private void SendCredentialsToEmail(string username, string password, string email)
        {
            string from = "mwelasejae@gmail.com";
            string pass = "removed for security";

            MailMessage message = new MailMessage
            {
                To = { email },
                From = new MailAddress(from),
                Subject = "Welcome to Brite Sparx Cafe - Your Account Credentials",
                Body = GenerateEmailBody(username, password),
                IsBodyHtml = true
            };

            // Set up the SMTP client
            SmtpClient smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 25,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(from, pass)
            };

            try
            {
                // Send the email
                smtp.Send(message);
                MessageBox.Show("Credentials sent successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while sending credentials: " + ex.ToString(), "Error");
            }
        }

        private string GenerateEmailBody(string username, string password)
        {
            string emailBody = @"
        <html>
        <head>
            <!-- Add the styles here -->
        </head>
        <body>
            <div class='container'>
                <div class='header'>
                    <h2>Welcome to Brite Sparx Cafe!</h2>
                </div>
                <div class='content'>
                    <p>Dear [Customer Name],</p>
                    <p>Thank you for choosing Brite Sparx Cafe. We've created an account for you, and here are your login credentials:</p>
                    <p><strong>Username:</strong> " + username + @"</p>
                    <p><strong>Password:</strong> " + password + @"</p>
                    <p>You can use these credentials to log in to our website and place orders online. If you have any questions or need assistance, feel free to contact our support team.</p>
                    <p>Best regards,<br>Brite Sparx Cafe Team</p>
                    <p><a href='[YourWebsiteLink]' class='button'>Visit Our Website</a></p>
                </div>
            </div>
        </body>
        </html>";

            // Replace placeholders with actual values
            emailBody = emailBody.Replace("[Customer Name]", firstNametextBox.Text + LastNametextBox.Text); // Replace with actual customer name
            emailBody = emailBody.Replace("[YourWebsiteLink]", "https://www.yourwebsite.com"); // Replace with your actual website link

            return emailBody;
        }



        private void Updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection("removed for security"))
                    {
                        con.Open();

                        // Fetch the existing data for the customer from the database
                        SqlCommand fetchCommand = new SqlCommand("SELECT * FROM Customer WHERE cust_ID = @cust_ID", con);
                        fetchCommand.Parameters.AddWithValue("@cust_ID", int.Parse(custIdtextBox.Text));
                        SqlDataReader reader = fetchCommand.ExecuteReader();

                        // Check if there's a record for the given customer ID
                        if (reader.Read())
                        {
                            // Get the existing values from the dataset
                            string existingFirstName = reader["fname"].ToString();
                            string existingLastName = reader["lname"].ToString();
                            string existingPhoneNumber = reader["phone_number"].ToString();
                            string existingEmail = reader["email"].ToString();
                            string existingCategory = reader["category"].ToString();

                            reader.Close();

                            // Start building the update command
                            SqlCommand command = new SqlCommand("UPDATE Customer SET", con);
                            List<string> updatedAttributes = new List<string>();

                            if (!string.IsNullOrEmpty(firstNametextBox.Text))
                            {
                                command.CommandText += " fname = @fname,";
                                command.Parameters.AddWithValue("@fname", firstNametextBox.Text);
                                updatedAttributes.Add("First Name");
                            }
                            else
                            {
                                // If the first name is not provided, use the existing value
                                command.CommandText += " fname = @fname,";
                                command.Parameters.AddWithValue("@fname", existingFirstName);
                            }

                            if (!string.IsNullOrEmpty(LastNametextBox.Text))
                            {
                                command.CommandText += " lname = @lname,";
                                command.Parameters.AddWithValue("@lname", LastNametextBox.Text);
                                updatedAttributes.Add("Last Name");
                            }
                            else
                            {
                                // If the first name is not provided, use the existing value
                                command.CommandText += " lname = @lname,";
                                command.Parameters.AddWithValue("@lname", existingLastName);
                            }

                            if (!string.IsNullOrEmpty(PhoneNumbermaskedTextBox.Text) && PhoneNumbermaskedTextBox.Text.StartsWith("0"))
                            {
                                command.CommandText += " phone_number = @phone_number,";
                                //command.Parameters.AddWithValue("@phone_number", phoneNumbertextBox.Text);
                                command.Parameters.AddWithValue("@phone_number", PhoneNumbermaskedTextBox.Text);
                                updatedAttributes.Add("Phone Number");
                            }
                            else
                            {
                                // If the first name is not provided, use the existing value
                                command.CommandText += " phone_number = @phone_number,";
                                command.Parameters.AddWithValue("@phone_number", existingPhoneNumber);
                            }

                            if (!string.IsNullOrEmpty(EmailtextBox.Text))
                            {

                                command.CommandText += " email = @email,";

                                string email = EmailtextBox.Text.Trim().ToLower(); // Convert the input to lowercase

                                // Check if the email contains spaces or has uppercase letters
                                if (email.Contains(" ") || email != EmailtextBox.Text)
                                {
                                    // Invalid email format (spaces or uppercase letters), display an error message
                                    MessageBox.Show("Invalid email format. Please enter a valid email address in lowercase without spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    // Set the focus back to the EmailtextBox
                                    EmailtextBox.Focus();

                                    // Optionally, you can clear the incorrect input from the textbox
                                    EmailtextBox.Text = "";

                                    // Optionally, you can cancel the validation event to prevent moving to the next control
                                    //e.Cancel = true;
                                }
                                else if (email.EndsWith("@gmail.com") || email.EndsWith("@ukzn.ac.za"))
                                {
                                    // Valid email format
                                    // Perform any additional processing or store the email address
                                    command.Parameters.AddWithValue("@email", EmailtextBox.Text);
                                }
                                else
                                {
                                    // Invalid email domain, display an error message
                                    MessageBox.Show("Unsupported domain. Please enter an email address ending with either @gmail.com or @ukzn.ac.za.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    // Set the focus back to the EmailtextBox
                                    EmailtextBox.Focus();

                                    // Optionally, you can clear the incorrect input from the textbox
                                    EmailtextBox.Text = "";

                                    // Optionally, you can cancel the validation event to prevent moving to the next control
                                    //e.Cancel = true;
                                }

                                updatedAttributes.Add("Email ");
                            }
                            else
                            {
                                // If the first name is not provided, use the existing value
                                command.CommandText += " email = @email,";
                                command.Parameters.AddWithValue("@email", existingEmail);
                            }
                            if (!string.IsNullOrEmpty(categoryComboBox.Text))
                            {
                                command.CommandText += " category = @category,";
                                command.Parameters.AddWithValue("@category", categoryComboBox.Text);
                                updatedAttributes.Add("Category ");
                            }
                            else
                            {
                                // If the first name is not provided, use the existing value
                                command.CommandText += " category = @category,";
                                command.Parameters.AddWithValue("@category", existingCategory);
                            }


                            // Similar checks for other attributes...

                            // Remove the trailing comma from the command text
                            if (command.CommandText.EndsWith(","))
                                command.CommandText = command.CommandText.Remove(command.CommandText.Length - 1);

                            command.CommandText += " WHERE cust_ID = @cust_ID";
                            command.Parameters.AddWithValue("@cust_ID", int.Parse(custIdtextBox.Text));

                            command.ExecuteNonQuery();

                            MessageBox.Show(string.Join(", ", updatedAttributes) + " updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            reader.Close();
                            MessageBox.Show("Customer ID not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    // If the user cancels, do nothing
                }

                // Clearing the fields and refreshing the data can be done outside the condition
                custIdtextBox.Text = "";
                firstNametextBox.Text = "";
                LastNametextBox.Text = "";
                PhoneNumbermaskedTextBox.Text = "";
                EmailtextBox.Text = "";
                categoryComboBox.Text = "";

                ds1.Customer.Rows.Clear();
                ds1.OrderTable.Rows.Clear();
                this.taCustomer1.Fill(this.ds1.Customer);
                this.taOrder1.Fill(this.ds1.OrderTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(custIdtextBox.Text))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to archive this Customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection con = new SqlConnection("removed for security"))
                        {
                            con.Open();
                            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Customer WHERE cust_ID = @cust_ID", con);
                            selectCommand.Parameters.AddWithValue("@cust_ID", int.Parse(custIdtextBox.Text));
                            SqlDataReader reader = selectCommand.ExecuteReader();

                            if (reader.Read())
                            {
                                int custID = reader.GetInt32(reader.GetOrdinal("cust_ID"));
                                string custName = reader.GetString(reader.GetOrdinal("fname"));

                                reader.Close();

                                SqlCommand archiveCommand = new SqlCommand("INSERT INTO ArchivedCustomer (cust_ID, cust_name, archived_date) VALUES (@cust_ID, @cust_name, GETDATE())", con);
                                archiveCommand.Parameters.AddWithValue("@cust_ID", custID);
                                archiveCommand.Parameters.AddWithValue("@cust_name", custName);
                                archiveCommand.ExecuteNonQuery();

                                SqlCommand deleteCommand = new SqlCommand("DELETE FROM Customer WHERE cust_ID = @cust_ID", con);
                                deleteCommand.Parameters.AddWithValue("@cust_ID", custID);
                                deleteCommand.ExecuteNonQuery();

                                MessageBox.Show("Customer ID: " + custID + " archived successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                reader.Close();
                                MessageBox.Show("Customer not found", "Error");
                            }
                        }
                    }

                    custIdtextBox.Text = "";
                    this.taCustomer1.Fill(this.ds1.Customer);
                }
                else
                {
                    MessageBox.Show("Please enter a valid Customer ID", "Invalid Input");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while archiving the customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("removed for security");
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE fname LIKE @fname OR lname LIKE @lname", con);

                if (!string.IsNullOrEmpty(firstNametextBox.Text))
                {
                    command.Parameters.AddWithValue("@fname", "%" + firstNametextBox.Text + "%");
                }
                else
                {
                    command.Parameters.AddWithValue("@fname", DBNull.Value);
                }
                // Check if the last name textbox has text, and set parameter accordingly
                if (!string.IsNullOrEmpty(LastNametextBox.Text))
                {
                    command.Parameters.AddWithValue("@lname", "%" + LastNametextBox.Text + "%");
                }
                else
                {
                    command.Parameters.AddWithValue("@lname", DBNull.Value);
                }

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvCustomer.DataSource = dt;
                

                this.taCustomer1.Fill(this.ds1.Customer);
                this.taOrder1.Fill(this.ds1.OrderTable);
            }
            catch
            {
                MessageBox.Show("An error occurred while searching.");
            }
        }

        private void searchCustTextbox_TextChanged(object sender, EventArgs e)
        {
            taCustomer2.FillBySurname(ds1.Customer, searchCustTextbox.Text);
        }

        private void gvCustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int custID = 0;
                custID = (int)gvCustomer.CurrentRow.Cells[0].Value;
                orderTableUpdatedTableAdapter.FillByCustID(ds1.OrderTableUpdated, custID);

                label13.Text = DateTime.Now.ToString();
                label15.Text = custID.ToString();
                custNamelabel.Text = gvCustomer.CurrentRow.Cells[1].Value.ToString() + " " + gvCustomer.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void searchMenuTextbox_TextChanged(object sender, EventArgs e)
        {
            taMenu1.FillByName(ds1.Menu, searchMenuTextbox.Text);
        }

  
        private void Clearbutton_Click(object sender, EventArgs e)
        {
            // Reset the textboxes and combo box
            custIdtextBox.Text = "";
            firstNametextBox.Text = "";
            LastNametextBox.Text = "";
            PhoneNumbermaskedTextBox.Text = "";
            EmailtextBox.Text = "";
            categoryComboBox.Text = "";
            searchCustTextbox.Text = "";

            // Refill the data
            this.taCustomer1.Fill(this.ds1.Customer);
            this.orderTableUpdatedTableAdapter.Fill(this.ds1.OrderTableUpdated);
            gvCustomer.Refresh();
        }


        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void finalizeOrderbutton_Click(object sender, EventArgs e)
        {
            int deliveryPoint;
            try
            {
                DialogResult dialogResult = MessageBox.Show("Confirm Order to " + custNamelabel.Text + " for an amount of " + orderTotaltextBox.Text, "Order Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (DeliveryComboBox.Text == "QUAD")
                    {
                        string uniqueID = Guid.NewGuid().ToString();
                        deliveryPoint = 1;
                        staffTableAdapter1.FillByUser(ds2.Staff, LoginForm.username, LoginForm.password);
                        taOrder1.InsertOrder(int.Parse(label15.Text), int.Parse(ds2.Staff.Rows[0][0].ToString()), deliveryPoint, decimal.Parse(orderTotaltextBox.Text, System.Globalization.NumberStyles.Currency), "Pending", DateTime.Now, uniqueID);
                        this.taOrder1.Fill(this.ds1.OrderTable);
                        for (int i = 0; i < gvMenu.Rows.Count; i++)
                        {
                            if (gvMenu.Rows[i].Cells[6].Value != null)
                            {
                                int orderId = int.Parse(ds1.OrderTable.Rows[ds1.OrderTable.Rows.Count - 1][0].ToString());
                                int menuID = int.Parse(gvMenu.Rows[i].Cells[0].Value.ToString());
                                decimal menuprice = decimal.Parse(gvMenu.Rows[i].Cells[4].Value.ToString());
                                int Qty = int.Parse(gvMenu.Rows[i].Cells[6].Value.ToString());
                                taOrderItem1.InsertOrderItem(menuID, orderId, menuprice, Qty);
                            }
                        }
                    }
                    else if (DeliveryComboBox.Text == "L BLOCK")
                    {
                        string uniqueID = Guid.NewGuid().ToString();
                        deliveryPoint = 2;
                        staffTableAdapter1.FillByUser(ds2.Staff, LoginForm.username, LoginForm.password);
                        taOrder1.InsertOrder(int.Parse(label15.Text), int.Parse(ds2.Staff.Rows[0][0].ToString()), deliveryPoint, decimal.Parse(orderTotaltextBox.Text, System.Globalization.NumberStyles.Currency), "Pending", DateTime.Now, uniqueID);
                        this.taOrder1.Fill(this.ds1.OrderTable);
                        for (int i = 0; i < gvMenu.Rows.Count; i++)
                        {
                            if (gvMenu.Rows[i].Cells[6].Value != null)
                            {
                                int orderId = int.Parse(ds1.OrderTable.Rows[ds1.OrderTable.Rows.Count - 1][0].ToString());
                                int menuID = int.Parse(gvMenu.Rows[i].Cells[0].Value.ToString());
                                decimal menuprice = decimal.Parse(gvMenu.Rows[i].Cells[4].Value.ToString());
                                int Qty = int.Parse(gvMenu.Rows[i].Cells[6].Value.ToString());
                                taOrderItem1.InsertOrderItem(menuID, orderId, menuprice, Qty);
                            }
                        }
                    }

                    else if (DeliveryComboBox.Text == "G BLOCK (bus stop)")
                    {
                        string uniqueID = Guid.NewGuid().ToString();
                        deliveryPoint = 3;
                        staffTableAdapter1.FillByUser(ds2.Staff, LoginForm.username, LoginForm.password);
                        taOrder1.InsertOrder(int.Parse(label15.Text), int.Parse(ds2.Staff.Rows[0][0].ToString()), deliveryPoint, decimal.Parse(orderTotaltextBox.Text, System.Globalization.NumberStyles.Currency), "Pending", DateTime.Now, uniqueID);
                        this.taOrder1.Fill(this.ds1.OrderTable);
                        for (int i = 0; i < gvMenu.Rows.Count; i++)
                        {
                            if (gvMenu.Rows[i].Cells[6].Value != null)
                            {
                                int orderId = int.Parse(ds1.OrderTable.Rows[ds1.OrderTable.Rows.Count - 1][0].ToString());
                                int menuID = int.Parse(gvMenu.Rows[i].Cells[0].Value.ToString());
                                decimal menuprice = decimal.Parse(gvMenu.Rows[i].Cells[4].Value.ToString());
                                int Qty = int.Parse(gvMenu.Rows[i].Cells[6].Value.ToString());
                                taOrderItem1.InsertOrderItem(menuID, orderId, menuprice, Qty);
                            }
                        }
                    }

                    else if (DeliveryComboBox.Text == "SPORT CENTRE")
                    {
                        string uniqueID = Guid.NewGuid().ToString();
                        deliveryPoint = 4;
                        staffTableAdapter1.FillByUser(ds2.Staff, LoginForm.username, LoginForm.password);
                        taOrder1.InsertOrder(int.Parse(label15.Text), int.Parse(ds2.Staff.Rows[0][0].ToString()), deliveryPoint, decimal.Parse(orderTotaltextBox.Text, System.Globalization.NumberStyles.Currency), "Pending", DateTime.Now, uniqueID);
                        this.taOrder1.Fill(this.ds1.OrderTable);
                        for (int i = 0; i < gvMenu.Rows.Count; i++)
                        {
                            if (gvMenu.Rows[i].Cells[6].Value != null)
                            {
                                int orderId = int.Parse(ds1.OrderTable.Rows[ds1.OrderTable.Rows.Count - 1][0].ToString());
                                int menuID = int.Parse(gvMenu.Rows[i].Cells[0].Value.ToString());
                                decimal menuprice = decimal.Parse(gvMenu.Rows[i].Cells[4].Value.ToString());
                                int Qty = int.Parse(gvMenu.Rows[i].Cells[6].Value.ToString());
                                taOrderItem1.InsertOrderItem(menuID, orderId, menuprice, Qty);
                            }
                        }
                    }



                    else if (DeliveryComboBox.Text == "FOREST HILL RESIDENCE")
                    {
                        string uniqueID = Guid.NewGuid().ToString();
                        deliveryPoint = 5;
                        staffTableAdapter1.FillByUser(ds2.Staff, LoginForm.username, LoginForm.password);
                        taOrder1.InsertOrder(int.Parse(label15.Text), int.Parse(ds2.Staff.Rows[0][0].ToString()), deliveryPoint, decimal.Parse(orderTotaltextBox.Text, System.Globalization.NumberStyles.Currency), "Pending", DateTime.Now, uniqueID);
                        this.taOrder1.Fill(this.ds1.OrderTable);
                        for (int i = 0; i < gvMenu.Rows.Count; i++)
                        {
                            if (gvMenu.Rows[i].Cells[6].Value != null)
                            {
                                int orderId = int.Parse(ds1.OrderTable.Rows[ds1.OrderTable.Rows.Count - 1][0].ToString());
                                int menuID = int.Parse(gvMenu.Rows[i].Cells[0].Value.ToString());
                                decimal menuprice = decimal.Parse(gvMenu.Rows[i].Cells[4].Value.ToString());
                                int Qty = int.Parse(gvMenu.Rows[i].Cells[6].Value.ToString());
                                taOrderItem1.InsertOrderItem(menuID, orderId, menuprice, Qty);
                            }
                        }
                    }

                    else if (DeliveryComboBox.Text == "d(CHURCH)")
                    {
                        string uniqueID = Guid.NewGuid().ToString();
                        deliveryPoint = 6;
                        staffTableAdapter1.FillByUser(ds2.Staff, LoginForm.username, LoginForm.password);
                        taOrder1.InsertOrder(int.Parse(label15.Text), int.Parse(ds2.Staff.Rows[0][0].ToString()), deliveryPoint, decimal.Parse(orderTotaltextBox.Text, System.Globalization.NumberStyles.Currency), "Pending", DateTime.Now, uniqueID);
                        for (int i = 0; i < gvMenu.Rows.Count; i++)
                        {
                            if (gvMenu.Rows[i].Cells[6].Value != null)
                            {
                                int orderId = int.Parse(ds1.OrderTable.Rows[ds1.OrderTable.Rows.Count - 1][0].ToString());
                                int menuID = int.Parse(gvMenu.Rows[i].Cells[0].Value.ToString());
                                decimal menuprice = decimal.Parse(gvMenu.Rows[i].Cells[4].Value.ToString());
                                int Qty = int.Parse(gvMenu.Rows[i].Cells[6].Value.ToString());
                                taOrderItem1.InsertOrderItem(menuID, orderId, menuprice, Qty);
                            }
                        }
                    }


                    else if (DeliveryComboBox.Text == "O BLOCK")
                    {
                        string uniqueID = Guid.NewGuid().ToString();
                        deliveryPoint = 7;
                        staffTableAdapter1.FillByUser(ds2.Staff, LoginForm.username, LoginForm.password);
                        taOrder1.InsertOrder(int.Parse(label15.Text), int.Parse(ds2.Staff.Rows[0][0].ToString()), deliveryPoint, decimal.Parse(orderTotaltextBox.Text, System.Globalization.NumberStyles.Currency), "Pending", DateTime.Now, uniqueID);
                        for (int i = 0; i < gvMenu.Rows.Count; i++)
                        {
                            if (gvMenu.Rows[i].Cells[6].Value != null)
                            {
                                int orderId = int.Parse(ds1.OrderTable.Rows[ds1.OrderTable.Rows.Count - 1][0].ToString());
                                int menuID = int.Parse(gvMenu.Rows[i].Cells[0].Value.ToString());
                                decimal menuprice = decimal.Parse(gvMenu.Rows[i].Cells[4].Value.ToString());
                                int Qty = int.Parse(gvMenu.Rows[i].Cells[6].Value.ToString());
                                taOrderItem1.InsertOrderItem(menuID, orderId, menuprice, Qty);
                            }
                        }
                    }
                    else
                    {
                        string uniqueID = Guid.NewGuid().ToString();
                        staffTableAdapter1.FillByUser(ds2.Staff, LoginForm.username, LoginForm.password);
                        taOrder1.InsertOrder(int.Parse(label15.Text), int.Parse(ds2.Staff.Rows[0][0].ToString()), null, decimal.Parse(orderTotaltextBox.Text, System.Globalization.NumberStyles.Currency), "Pending", DateTime.Now, uniqueID);
                        this.taOrder1.Fill(this.ds1.OrderTable);
                        for (int i = 0; i < gvMenu.Rows.Count; i++)
                        {
                            if (gvMenu.Rows[i].Cells[6].Value != null)
                            {
                                int orderId = int.Parse(ds1.OrderTable.Rows[ds1.OrderTable.Rows.Count - 1][0].ToString());
                                int menuID = int.Parse(gvMenu.Rows[i].Cells[0].Value.ToString());
                                decimal menuprice = decimal.Parse(gvMenu.Rows[i].Cells[4].Value.ToString());
                                int Qty = int.Parse(gvMenu.Rows[i].Cells[6].Value.ToString());
                                taOrderItem1.InsertOrderItem(menuID, orderId, menuprice, Qty);
                            }
                        }
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    ds1.Menu.Rows.Clear();
                    orderTotaltextBox.Text = "";
                }
                MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int rowIndex = gvMenu.CurrentRow.Index;
                int qohColumnIndex = 5;
                int qoh = int.Parse(gvMenu.Rows[rowIndex].Cells[qohColumnIndex].Value.ToString());
                string connectionString = "removed for security";
                string updateQuery = "UPDATE Menu SET quantity_on_hand = @quantity_on_hand WHERE menu_ID = @menu_ID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@quantity_on_hand", qoh);
                        command.Parameters.AddWithValue("@menu_ID", int.Parse(gvMenu.CurrentRow.Cells[0].Value.ToString()));
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                this.taMenu1.Fill(this.ds1.Menu);
                this.menuTotalTableAdapter.Fill(this.ds1.MenuTotal);
                DeliveryComboBox.Text = "";
                PaymentMethodcomboBox.Text = "";
                orderTotaltextBox.Text = "";
                searchMenuTextbox.Text = "";
                finalizeOrderbutton.Enabled = false;
                DeliverycheckBox.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (DeliverycheckBox.Checked)
            {
                // Set the culture to South Africa (English)
                CultureInfo cultureSA = new CultureInfo("en-ZA");

                decimal value1;

                // Parse the value from textBox1 with the appropriate culture
                if (decimal.TryParse(orderTotaltextBox.Text, NumberStyles.Currency, cultureSA, out value1))
                {
                    // Declare and assign the value for Value 2 (e.g., from a declared variable)
                    decimal value2Declared = 10.00M; // Replace with the actual value you have in the variable

                    // Perform addition
                    decimal result = value1 + value2Declared;

                    // Display the result in textBox1 with the appropriate culture formatting
                    orderTotaltextBox.Text = result.ToString("c", cultureSA);
                    DeliveryFeeNotif.Visible = true;
                    DeliveryComboBox.Visible = true;
                    PaymentgroupBox.Visible = true;
                }
            }

            else
            {
                // Set the culture to South Africa (English)
                CultureInfo cultureSA = new CultureInfo("en-ZA");

                decimal value1;

                // Parse the value from textBox1 with the appropriate culture
                if (decimal.TryParse(orderTotaltextBox.Text, NumberStyles.Currency, cultureSA, out value1))
                {
                    // Declare and assign the value for Value 2 (e.g., from a declared variable)
                    decimal value2Declared = 10.00M; // Replace with the actual value you have in the variable

                    // Perform addition
                    decimal result = value1 - value2Declared;

                    // Display the result in textBox1 with the appropriate culture formatting
                    orderTotaltextBox.Text = result.ToString("c", cultureSA);
                    DeliveryFeeNotif.Visible = false;
                    DeliveryComboBox.Visible = false;
                    PaymentgroupBox.Visible = false;
                }
            }
        }


        private void cbutton_Click(object sender, EventArgs e)
        {
            this.taMenu1.Fill(this.ds1.Menu);
            this.menuTotalTableAdapter.Fill(this.ds1.MenuTotal); ;
            DeliveryComboBox.Text = "";
            PaymentMethodcomboBox.Text = "";
            orderTotaltextBox.Text = "";
            searchMenuTextbox.Text = "";
            finalizeOrderbutton.Enabled = false;
            DeliverycheckBox.Checked = false;
        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
            try
            {
                int deletedRowIndex = gvMenuTotal.CurrentRow.Index;
                int menuID = int.Parse(gvMenuTotal.Rows[deletedRowIndex].Cells[0].Value.ToString());

                ds1.MenuTotal.Rows[deletedRowIndex].Delete();

                for (int i = 0; i < gvMenu.Rows.Count; i++)
                {
                    int currentMenuID = int.Parse(gvMenu.Rows[i].Cells[0].Value.ToString());
                    if (currentMenuID == menuID)
                    {
                        int qoh = int.Parse(gvMenu.Rows[i].Cells[4].Value.ToString());
                        int quantitySold = int.Parse(gvMenu.Rows[i].Cells[5].Value.ToString());
                        int updatedQOH = qoh + quantitySold;
                        gvMenu.Rows[i].Cells[4].Value = updatedQOH;
                        break;
                    }
                }

                decimal orderTotal = 0;
                if (ds1.MenuTotal.Rows.Count > 0)
                {
                    for (int i = 0; i < ds1.MenuTotal.Rows.Count; i++)
                    {
                        orderTotal += decimal.Parse(ds1.MenuTotal.Rows[i][3].ToString()) * int.Parse(ds1.MenuTotal.Rows[i][4].ToString());
                    }
                }

                orderTotaltextBox.Text = orderTotal.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void firstNametextBox_TextChanged(object sender, EventArgs e)
        {
            string firstName = firstNametextBox.Text.Trim();

            // Define a regular expression pattern for a name starting with a capital letter and followed by letters only
            string pattern = "^[A-Z][a-zA-Z]*$";

            if (!Regex.IsMatch(firstName, pattern) && firstNametextBox.Text != "")
            {
                // The input does not match the desired format, display an error message
                MessageBox.Show("First name should start with a capital letter and contain letters only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Set the focus back to the FirstNameTextBox
                firstNametextBox.Focus();
                firstNametextBox.Text = "";
                // Cancel the event to prevent moving to the next control
                //e.Cancel = true;
            }
        }

        private void LastNametextBox_TextChanged(object sender, EventArgs e)
        {
            string lastName = LastNametextBox.Text.Trim();

            // Define a regular expression pattern for a name starting with a capital letter and followed by letters only
            string pattern = "^[A-Z][a-zA-Z]*$";

            if (!Regex.IsMatch(lastName, pattern) && LastNametextBox.Text != "")
            {
                // The input does not match the desired format, display an error message
                MessageBox.Show("First name should start with a capital letter and contain letters only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Set the focus back to the FirstNameTextBox
                LastNametextBox.Focus();
                LastNametextBox.Text = "";
                // Cancel the event to prevent moving to the next control
                //e.Cancel = true;
            }
        }

        private void custIdtextBox_TextChanged(object sender, EventArgs e)
        {
            string iD = custIdtextBox.Text.Trim();
            custIdtextBox.ReadOnly = true;

            // Define a regular expression pattern for a phone number containing only digits (numbers)
            string pattern = "^[0-9]+$";

            if (!Regex.IsMatch(iD, pattern) && custIdtextBox.Text != "")
            {
                // The input does not match the desired format (contains letters or other characters), display an error message
                MessageBox.Show("Enter only digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Set the focus back to the PhoneNumbermaskedTextBox
                custIdtextBox.Focus();
                custIdtextBox.Text = "";
                // Cancel the event to prevent moving to the next control
                //e.Cancel = true;
            }
        }

        private void gvCustomer_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            custIdtextBox.Text = gvCustomer.CurrentRow.Cells[0].Value.ToString();
            firstNametextBox.Text = gvCustomer.CurrentRow.Cells[1].Value.ToString();
            LastNametextBox.Text = gvCustomer.CurrentRow.Cells[2].Value.ToString();
            PhoneNumbermaskedTextBox.Text = gvCustomer.CurrentRow.Cells[3].Value.ToString();
            EmailtextBox.Text = gvCustomer.CurrentRow.Cells[4].Value.ToString();
            categoryComboBox.Text = gvCustomer.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
