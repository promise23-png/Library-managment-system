using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class IssuedBooksForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyLibraryDB"].ConnectionString;
        public int SelectedIssueID { get; private set; }

        public IssuedBooksForm()
        {
            InitializeComponent();
            SelectedIssueID = -1;
        }

        private void IssuedBooksForm_Load(object sender, EventArgs e)
        {
            LoadIssuedBooks();
        }

        private void LoadIssuedBooks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT i.IssueID, b.Title, br.Name AS Borrower, 
                                   i.IssueDate, i.DueDate, 
                                   DATEDIFF(day, GETDATE(), i.DueDate) AS DaysRemaining
                                   FROM IssuedBooks i
                                   JOIN Books b ON i.BookID = b.BookID
                                   JOIN Borrowers br ON i.BorrowerID = br.BorrowerID
                                   WHERE i.Returned = 0
                                   ORDER BY i.DueDate ASC";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Add status column
                    dt.Columns.Add("Status", typeof(string));
                    foreach (DataRow row in dt.Rows)
                    {
                        int daysRemaining = Convert.ToInt32(row["DaysRemaining"]);
                        row["Status"] = daysRemaining < 0 ? "OVERDUE" : "On Time";
                    }

                    dgvIssuedBooks.DataSource = dt;
                    ConfigureGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading issued books: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGrid()
        {
            dgvIssuedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIssuedBooks.Columns["IssueID"].Visible = false;
            dgvIssuedBooks.Columns["DaysRemaining"].Visible = false;

            // Format date columns
            dgvIssuedBooks.Columns["IssueDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            dgvIssuedBooks.Columns["DueDate"].DefaultCellStyle.Format = "yyyy-MM-dd";

            // Color coding for overdue books
            dgvIssuedBooks.RowsDefaultCellStyle.BackColor = Color.White;
            foreach (DataGridViewRow row in dgvIssuedBooks.Rows)
            {
                if (row.Cells["Status"].Value.ToString() == "OVERDUE")
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                    row.DefaultCellStyle.Font = new Font(dgvIssuedBooks.Font, FontStyle.Bold);
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvIssuedBooks.SelectedRows.Count > 0)
            {
                SelectedIssueID = Convert.ToInt32(dgvIssuedBooks.SelectedRows[0].Cells["IssueID"].Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a book to return", "Selection Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadIssuedBooks();
        }
    }
}