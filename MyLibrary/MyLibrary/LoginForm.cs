using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace MyLibrary
{
    public partial class LoginForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyLibraryDB"].ConnectionString;
        private bool isDarkMode = true;

        public LoginForm()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Please enter both username and password";
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(1) FROM Users WHERE Username=@username AND Password=@password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    conn.Open();
                    bool isValid = (int)cmd.ExecuteScalar() > 0;

                    if (isValid)
                    {
                        lblError.Text = "";
                        this.Hide();
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                    }
                    else
                    {
                        lblError.Text = "Invalid username or password";
                    }
                }
            }
            catch (SqlException ex)
            {
                lblError.Text = "Database error: " + ex.Message;
            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
            }
        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }
        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact the system administrator to reset your password.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnToggleTheme_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            Color bgColor = isDarkMode ? Color.FromArgb(30, 30, 30) : SystemColors.Control;
            Color fgColor = isDarkMode ? Color.WhiteSmoke : Color.Black;
            Color textBoxBg = isDarkMode ? Color.FromArgb(45, 45, 48) : Color.White;
            Color buttonBg = isDarkMode ? Color.FromArgb(70, 70, 70) : SystemColors.Control;

            this.BackColor = bgColor;

            foreach (Control ctrl in this.Controls)
            {
                switch (ctrl)
                {
                    case LinkLabel link:
                        link.LinkColor = isDarkMode ? Color.DeepSkyBlue : Color.Blue;
                        link.ActiveLinkColor = isDarkMode ? Color.LightSkyBlue : Color.Blue;
                        link.VisitedLinkColor = link.LinkColor;
                        link.BackColor = bgColor;
                        link.ForeColor = link.LinkColor;
                        break;

                    case Label label:
                        label.BackColor = bgColor;
                        label.ForeColor = fgColor;
                        break;

                    case TextBox txt:
                        txt.BackColor = textBoxBg;
                        txt.ForeColor = fgColor;
                        break;

                    case Button btn:
                        btn.BackColor = buttonBg;
                        btn.ForeColor = fgColor;
                        break;
                }
            }

            btnToggleTheme.Text = isDarkMode ? "Light Mode" : "Dark Mode";
        }
    }
}
