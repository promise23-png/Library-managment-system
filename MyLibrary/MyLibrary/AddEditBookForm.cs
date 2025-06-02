using System;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class AddEditBookForm : Form
    {
        public string BookTitle { get; private set; }
        public string BookAuthor { get; private set; }
        public int BookYear { get; private set; }
        public int AvailableCopies { get; private set; }

        // Constructor for adding a new book
        public AddEditBookForm()
        {
            InitializeComponent();
            this.Text = "Add New Book";
        }

        // Constructor for editing an existing book
        public AddEditBookForm(int bookID, string title, string author, int year, int copies)
        {
            InitializeComponent();
            this.Text = "Edit Book";

            // Set the form fields with existing values
            txtTitle.Text = title;
            txtAuthor.Text = author;
            numYear.Value = year;
            numCopies.Value = copies;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a book title", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Please enter an author name", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAuthor.Focus();
                return;
            }

            // Set the public properties with form values
            BookTitle = txtTitle.Text.Trim();
            BookAuthor = txtAuthor.Text.Trim();
            BookYear = (int)numYear.Value;
            AvailableCopies = (int)numCopies.Value;

            // Close the form with OK result
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Public method to clear the form (optional)
        public void ClearForm()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            numYear.Value = DateTime.Now.Year;
            numCopies.Value = 1;
        }
    }
}