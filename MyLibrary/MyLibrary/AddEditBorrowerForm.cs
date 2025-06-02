using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyLibrary
{
    public partial class AddEditBorrowerForm : Form
    {
        public string BorrowerName { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }

        // Constructor for adding a new borrower
        public AddEditBorrowerForm()
        {
            InitializeComponent();
            this.Text = "Add New Borrower";
        }

        // Constructor for editing an existing borrower
        public AddEditBorrowerForm(int borrowerID, string name, string email, string phone)
        {
            InitializeComponent();
            this.Text = "Edit Borrower";

            // Set the form fields with existing values
            txtName.Text = name;
            txtEmail.Text = email;
            txtPhone.Text = phone;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the borrower's name", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            // Email validation (optional field but must be valid if provided)
            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // Set the public properties with form values
            BorrowerName = txtName.Text.Trim();
            Email = txtEmail.Text.Trim();
            Phone = txtPhone.Text.Trim();

            // Close the form with OK result
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                // Simple regex for basic email validation
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        // Public method to clear the form (optional)
        public void ClearForm()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
        }
    }
}