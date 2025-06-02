Name kalkidan ambaw        ID:1501289
MYLIBRARY - LIBRARY MANAGEMENT SYSTEM

DESCRIPTION:
A complete Windows desktop application for managing library operations including book inventory, member management, and loan tracking. Built with C# WinForms and SQL Server.

CORE FEATURES:
1. User Management:
   - Role-based access (Admin/)
   - Secure password authentication

2. Book Management:
   - Add/edit/delete book records
   - Track ISBN, title, author, year, genre
   - Manage inventory (total/available copies)
   - Advanced search and filtering

3. Member System:
   - Register new members
   - Manage contact information
   - View borrowing history
   - Track overdue items

4. Loan System:
   - Check books in/out
   - Automatic due date calculation
   - Overdue notifications

5. Reporting:
   - Current loans report

INSTALLATION GUIDE:

PREREQUISITES:
- Windows 10/11 (64-bit)
- .NET Framework 4.7.2+
- SQL Server Express LocalDB
- Visual Studio 2019+ (for development)

SETUP STEPS:
1. Database Setup:
   - Install SQL Server Express LocalDB
   - Execute library-individual.sql script
   - Verify tables: Books, Users, Borrowers, IssuedBooks

2. Application Setup:
   - Clone/download source code
   - Open MyLibrary.sln in Visual Studio
   - Build solution (Ctrl+Shift+B)
   - Run application (F5)

DEFAULT CREDENTIALS:
Administrator:
Username: kalkidan
Password: kalkidan123

Librarian:
Username: admin
Password: admin123

CONFIGURATION OPTIONS:

1. Database Connection:
Edit App.config:
<connectionStrings>
  <add name="MyLibraryDB"
   connectionString="Data Source=(LocalDB)\MSSQLLocalDB;
   AttachDbFilename=|DataDirectory|\MyLibrary.mdf;
   Integrated Security=True"
   providerName="System.Data.SqlClient"/>
</connectionStrings>

2. Application Settings:
- Change maximum loan period (days)
- Set overdue fine rate
- Configure default admin credentials

TROUBLESHOOTING COMMON ISSUES:

1. Database Connection Errors:
- Verify LocalDB installation
- Check SQL Server service is running
- Confirm database file exists in bin\Debug

2. Login Problems:
Reset password directly in database:
UPDATE Users SET Password = 'newpass' WHERE Username = 'admin'

3. Application Crashes:
- Clean and rebuild solution
- Check error logs in \logs directory
- Verify .NET Framework version

DEPENDENCIES:
- System.Data.SqlClient
- System.Configuration

BUILD INSTRUCTIONS:
1. Open solution in Visual Studio
2. Restore NuGet packages
3. Set MyLibrary as startup project
4. Build and run

CONTACT DETAILS:
For support and inquiries:
Email: your.promiseambaw23@gmail.com
