using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class ReportViewerForm : Form
    {
        private DataTable reportData;
        private string reportTitle;

        public ReportViewerForm(string title, DataTable data)
        {
            InitializeComponent();
            reportTitle = title;
            reportData = data;
            lblReportTitle.Text = reportTitle;
            dgvReportData.DataSource = reportData;
            ConfigureGrid();
        }

        private void ConfigureGrid()
        {
            dgvReportData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportData.RowHeadersVisible = false;
            dgvReportData.AllowUserToAddRows = false;
            dgvReportData.AllowUserToDeleteRows = false;
            dgvReportData.ReadOnly = true;
            dgvReportData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportData.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Create fonts and brushes
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font contentFont = new Font("Arial", 10);
            Brush brush = Brushes.Black;

            // Print title
            float yPos = 50;
            e.Graphics.DrawString(reportTitle, titleFont, brush, 100, yPos);
            yPos += titleFont.GetHeight() + 20;

            // Print date
            string printDate = "Generated on: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            e.Graphics.DrawString(printDate, contentFont, brush, 100, yPos);
            yPos += contentFont.GetHeight() + 30;

            // Print column headers
            float xPos = 100;
            foreach (DataColumn column in reportData.Columns)
            {
                e.Graphics.DrawString(column.ColumnName, headerFont, brush, xPos, yPos);
                xPos += 150; // Fixed column width for printing
            }
            yPos += headerFont.GetHeight() + 5;

            // Print data rows
            foreach (DataRow row in reportData.Rows)
            {
                xPos = 100;
                foreach (object item in row.ItemArray)
                {
                    e.Graphics.DrawString(item.ToString(), contentFont, brush, xPos, yPos);
                    xPos += 150;
                }
                yPos += contentFont.GetHeight() + 5;

                // Check if we need another page
                if (yPos > e.MarginBounds.Height)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
            saveFileDialog.Title = "Export Report";
            saveFileDialog.FileName = reportTitle.Replace(" ", "_") + "_" + DateTime.Now.ToString("yyyyMMdd");

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder csvContent = new StringBuilder();

                    // Add headers
                    foreach (DataColumn column in reportData.Columns)
                    {
                        csvContent.Append(column.ColumnName + ",");
                    }
                    csvContent.AppendLine();

                    // Add data
                    foreach (DataRow row in reportData.Rows)
                    {
                        foreach (object item in row.ItemArray)
                        {
                            string value = item.ToString().Contains(",") ? $"\"{item}\"" : item.ToString();
                            csvContent.Append(value + ",");
                        }
                        csvContent.AppendLine();
                    }

                    File.WriteAllText(saveFileDialog.FileName, csvContent.ToString());
                    MessageBox.Show("Report exported successfully!", "Export Complete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting report: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}