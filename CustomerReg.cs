using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Project
{
    public partial class CustomerReg : Form
    {
        string connectionString;

        public CustomerReg()
        {
            connectionString = "Data Source=TUF-A17\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;Encrypt=False";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve input values
            string firstName = FNameTxt.Text.Trim();
            string lastName = LNameTxt.Text.Trim();
            string email = MailTxt.Text.Trim();
            string password = PassTxt.Text.Trim();
            string address = AddrTxt.Text.Trim();
            string paymentPreference = PpTxt.Text.Trim();
            string state = StTxt.Text.Trim();
            DateTime dob = DOBTimePicker.Value;  // Date of Birth from the DateTimePicker
            string gender = GenderComboBox.SelectedItem?.ToString();  // Gender from the ComboBox

            // Perform validation checks
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("First Name is required.");
                return;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Last Name is required.");
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email is required.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password is required.");
                return;
            }

            if (!IsStrongPassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters long, include an uppercase letter, a lowercase letter, a number, and a special character.");
                return;
            }

            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address is required.");
                return;
            }

            if (string.IsNullOrEmpty(paymentPreference))
            {
                MessageBox.Show("Payment Preference is required.");
                return;
            }

            if (string.IsNullOrEmpty(state))
            {
                MessageBox.Show("State is required.");
                return;
            }

            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Gender is required.");
                return;
            }

            // Save data to database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Customer (FirstName, LastName, Email, Password, Address, PaymentPreference, State, DateOfBirth, Gender) " +
                                   "VALUES (@FirstName, @LastName, @Email, @Password, @Address, @PaymentPreference, @State, @DateOfBirth, @Gender)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@PaymentPreference", paymentPreference);
                        cmd.Parameters.AddWithValue("@State", state);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dob);
                        cmd.Parameters.AddWithValue("@Gender", gender);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Registration successful!");
                            Login logIn = new Login();
                            logIn.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, pattern))
                return false;
            return true;
        }

        // Password strength validation method
        private bool IsStrongPassword(string password)
        {
            if (password.Length >= 8)
            {
                if (Regex.IsMatch(password, @"[A-Z]") && Regex.IsMatch(password, @"[a-z]") && Regex.IsMatch(password, @"\d") && Regex.IsMatch(password, @"[!@#$%^&*(),.?""{}|<>]"))
                    return true;
                return false;
            }
            return false;
        }

        // Event handlers for text changes (optional, add real-time validation feedback if needed)
        private void FNameTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void LNameTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void MailTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void PassTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddrTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void PpTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void StTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void CustomerLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login logIn = new Login();
            logIn.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void CustomerReg_Load(object sender, EventArgs e)
        {
        }
    }
}
