using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace BriteSparxCafeSystem
{
    public partial class sendCode : Form
    {
        string randomCode;
        public static string to;
        public sendCode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(99999)).ToString();
            MailMessage message = new MailMessage();

            to = (textBox1.Text).ToString();
            from = "mwelasejae@gmail.com";
            pass = "removed for security";
            messageBody = "your reset code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password reset code";


            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 465;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code sent successfully.");
            }
            catch (SmtpException smtpEx)
            {
                if (smtpEx.InnerException is System.Security.Authentication.AuthenticationException authEx)
                {
                    MessageBox.Show($"SSL/TLS Handshake Error: {authEx.Message}", "Error");
                }
                else
                {
                    MessageBox.Show($"SMTP Error: {smtpEx.Message}", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error");
            }
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            if(randomCode == (textBox2.Text).ToString())
            {
                to = textBox1.Text;
                resetPassword rp = new resetPassword();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Code");
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm loginf = new LoginForm();
            this.Hide();
            loginf.Show();
            
        }
    }
}
