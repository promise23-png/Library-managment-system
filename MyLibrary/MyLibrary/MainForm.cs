using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class MainForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyLibraryDB"].ConnectionString;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadBorrowers();
        }

        private void LoadBooks(string authorFilter = "", int? yearFrom = null, int? yearTo = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT BookID, Title, Author, Year, AvailableCopies FROM Books WHERE 1=1";

                    if (!string.IsNullOrEmpty(authorFilter))
                    {
                        query += " AND Author LIKE @authorFilter";
                    }
                    if (yearFrom.HasValue)
                    {
                        query += " AND Year >= @yearFrom";
                    }
                    if (yearTo.HasValue)
                    {
                        query += " AND Year <= @yearTo";
                    }

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    if (!string.IsNullOrEmpty(authorFilter))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@authorFilter", "%" + authorFilter + "%");
                    }
                    if (yearFrom.HasValue)
                    {
                        da.SelectCommand.Parameters.AddWithValue("@yearFrom", yearFrom.Value);
                    }
                    if (yearTo.HasValue)
                    {
                        da.SelectCommand.Parameters.AddWithValue("@yearTo", yearTo.Value);
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvBooks.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBorrowers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT BorrowerID, Name, Email, Phone FROM Borrowers";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvBorrowers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading borrowers: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            using (AddEditBookForm form = new AddEditBookForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            string query = @"INSERT INTO Books (Title, Author, Year, AvailableCopies) 
                                         VALUES (@title, @author, @year, @copies)";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@title", form.BookTitle);
                            cmd.Parameters.AddWithValue("@author", form.BookAuthor);
                            cmd.Parameters.AddWithValue("@year", form.BookYear);
                            cmd.Parameters.AddWithValue("@copies", form.AvailableCopies);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            LoadBooks();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding book: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to edit", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = dgvBooks.SelectedRows[0];
            int bookID = Convert.ToInt32(row.Cells["BookID"].Value);

            using (AddEditBookForm form = new AddEditBookForm(
                bookID,
                row.Cells["Title"].Value.ToString(),
                row.Cells["Author"].Value.ToString(),
                Convert.ToInt32(row.Cells["Year"].Value),
                Convert.ToInt32(row.Cells["AvailableCopies"].Value)))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            string query = @"UPDATE Books SET 
                                           Title = @title, 
                                           Author = @author, 
                                           Year = @year, 
                                           AvailableCopies = @copies
                                           WHERE BookID = @bookID";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@title", form.BookTitle);
                            cmd.Parameters.AddWithValue("@author", form.BookAuthor);
                            cmd.Parameters.AddWithValue("@year", form.BookYear);
                            cmd.Parameters.AddWithValue("@copies", form.AvailableCopies);
                            cmd.Parameters.AddWithValue("@bookID", bookID);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            LoadBooks();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating book: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to delete", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this book?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int bookID = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookID"].Value);

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        // First check if book is issued
                        string checkQuery = "SELECT COUNT(*) FROM IssuedBooks WHERE BookID = @bookID AND Returned = 0";
                        SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                        checkCmd.Parameters.AddWithValue("@bookID", bookID);

                        conn.Open();
                        int issuedCount = (int)checkCmd.ExecuteScalar();

                        if (issuedCount > 0)
                        {
                            MessageBox.Show("Cannot delete book that is currently issued", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string deleteQuery = "DELETE FROM Books WHERE BookID = @bookID";
                        SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                        deleteCmd.Parameters.AddWithValue("@bookID", bookID);

                        deleteCmd.ExecuteNonQuery();
                        LoadBooks();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting book: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddBorrower_Click(object sender, EventArgs e)
        {
            using (AddEditBorrowerForm form = new AddEditBorrowerForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            string query = @"INSERT INTO Borrowers (Name, Email, Phone) 
                                         VALUES (@name, @email, @phone)";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@name", form.BorrowerName);
                            cmd.Parameters.AddWithValue("@email", form.Email);
                            cmd.Parameters.AddWithValue("@phone", form.Phone);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            LoadBorrowers();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding borrower: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEditBorrower_Click(object sender, EventArgs e)
        {
            if (dgvBorrowers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a borrower to edit", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = dgvBorrowers.SelectedRows[0];
            int borrowerID = Convert.ToInt32(row.Cells["BorrowerID"].Value);

            using (AddEditBorrowerForm form = new AddEditBorrowerForm(
                borrowerID,
                row.Cells["Name"].Value.ToString(),
                row.Cells["Email"].Value?.ToString(),
                row.Cells["Phone"].Value?.ToString()))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            string query = @"UPDATE Borrowers SET 
                                           Name = @name, 
                                           Email = @email, 
                                           Phone = @phone
                                           WHERE BorrowerID = @borrowerID";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@name", form.BorrowerName);
                            cmd.Parameters.AddWithValue("@email", form.Email);
                            cmd.Parameters.AddWithValue("@phone", form.Phone);
                            cmd.Parameters.AddWithValue("@borrowerID", borrowerID);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            LoadBorrowers();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating borrower: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDeleteBorrower_Click(object sender, EventArgs e)
        {
            if (dgvBorrowers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a borrower to delete", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this borrower?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int borrowerID = Convert.ToInt32(dgvBorrowers.SelectedRows[0].Cells["BorrowerID"].Value);

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        // First check if borrower has issued books
                        string checkQuery = "SELECT COUNT(*) FROM IssuedBooks WHERE BorrowerID = @borrowerID AND Returned = 0";
                        SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                        checkCmd.Parameters.AddWithValue("@borrowerID", borrowerID);

                        conn.Open();
                        int issuedCount = (int)checkCmd.ExecuteScalar();

                        if (issuedCount > 0)
                        {
                            MessageBox.Show("Cannot delete borrower with currently issued books", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string deleteQuery = "DELETE FROM Borrowers WHERE BorrowerID = @borrowerID";
                        SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                        deleteCmd.Parameters.AddWithValue("@borrowerID", borrowerID);

                        deleteCmd.ExecuteNonQuery();
                        LoadBorrowers();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting borrower: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (dgvBorrowers.SelectedRows.Count == 0 || dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select both a borrower and a book", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookID = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookID"].Value);
            int borrowerID = Convert.ToInt32(dgvBorrowers.SelectedRows[0].Cells["BorrowerID"].Value);

            // Check available copies
            int availableCopies = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["AvailableCopies"].Value);
            if (availableCopies <= 0)
            {
                MessageBox.Show("No available copies of this book", "Not Available",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Create issued book record
                    string query = @"INSERT INTO IssuedBooks (BookID, BorrowerID, DueDate)
                                    VALUES (@bookID, @borrowerID, DATEADD(day, 14, GETDATE()));
                                    
                                    UPDATE Books SET AvailableCopies = AvailableCopies - 1 
                                    WHERE BookID = @bookID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@bookID", bookID);
                    cmd.Parameters.AddWithValue("@borrowerID", borrowerID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Book issued successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the books list
                    LoadBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error issuing book: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            using (IssuedBooksForm form = new IssuedBooksForm())
            {
                if (form.ShowDialog() == DialogResult.OK && form.SelectedIssueID > 0)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();

                            // Get book ID before returning
                            string getQuery = "SELECT BookID FROM IssuedBooks WHERE IssueID = @issueID";
                            SqlCommand getCmd = new SqlCommand(getQuery, conn);
                            getCmd.Parameters.AddWithValue("@issueID", form.SelectedIssueID);
                            int bookID = (int)getCmd.ExecuteScalar();

                            // Return the book
                            string updateQuery = @"UPDATE IssuedBooks SET Returned = 1 
                                                WHERE IssueID = @issueID;
                                                
                                                UPDATE Books SET AvailableCopies = AvailableCopies + 1 
                                                WHERE BookID = @bookID";

                            SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                            updateCmd.Parameters.AddWithValue("@issueID", form.SelectedIssueID);
                            updateCmd.Parameters.AddWithValue("@bookID", bookID);

                            updateCmd.ExecuteNonQuery();

                            MessageBox.Show("Book returned successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the books list
                            LoadBooks();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error returning book: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnFilterBooks_Click(object sender, EventArgs e)
        {
            string authorFilter = txtAuthorFilter.Text.Trim();
            int? yearFrom = null;
            int? yearTo = null;

            if (!string.IsNullOrEmpty(txtYearFrom.Text) && int.TryParse(txtYearFrom.Text, out int yearFromValue))
            {
                yearFrom = yearFromValue;
            }

            if (!string.IsNullOrEmpty(txtYearTo.Text) && int.TryParse(txtYearTo.Text, out int yearToValue))
            {
                yearTo = yearToValue;
            }

            LoadBooks(authorFilter, yearFrom, yearTo);
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtAuthorFilter.Clear();
            txtYearFrom.Clear();
            txtYearTo.Clear();
            LoadBooks();
        }

        private void btnOverdueBooks_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT b.Title, br.Name, i.IssueDate, i.DueDate, 
                                    DATEDIFF(day, i.DueDate, GETDATE()) AS DaysOverdue
                                    FROM IssuedBooks i
                                    JOIN Books b ON i.BookID = b.BookID
                                    JOIN Borrowers br ON i.BorrowerID = br.BorrowerID
                                    WHERE i.Returned = 0 AND i.DueDate < GETDATE()";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        using (ReportViewerForm form = new ReportViewerForm("Overdue Books", dt))
                        {
                            form.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No overdue books found", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MyLibrary Application\nVersion 1.0\n© 2025", "About",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}