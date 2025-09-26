using System;
using System.Windows.Forms;

namespace Library
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            try
            {
                var dt = DBHelper.GetAllBooks();
                lblTotal.Text = $"Total books: {dt.Rows.Count}";
            }
            catch (Exception ex)
            {
               
                lblTotal.Text = $"Total books: (error)";
                MessageBox.Show($"Failed to load total books:\n{ex.Message}", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            using var f = new AddBookForm();
            if (f.ShowDialog() == DialogResult.OK) UpdateTotal();
        }

        private void btnViewBooks_Click(object sender, EventArgs e)
        {
            using var f = new ViewBooksForm();
            f.ShowDialog();
            UpdateTotal();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
