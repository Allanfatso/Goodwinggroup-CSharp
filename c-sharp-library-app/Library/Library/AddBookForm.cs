using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AddBookForm : Form
    {
        public int EditingId { get; private set; } = 0;
        public AddBookForm()
        {
            InitializeComponent();
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
            LoadCategories();
        }

        public AddBookForm(int id) : this()
        {
            EditingId = id;
            LoadBook(id);
        }

        private void LoadCategories()
        {
            if (cmbCategory.Items.Count == 0)
                cmbCategory.Items.AddRange(new string[] { "Fiction", "Non-Fiction", "Fantasy", "Science", "Biography", "Dystopia", "Other" });
        }

        private void LoadBook(int id)
        {
            var row = DBHelper.GetBookById(id);
            if (row == null) return;
            txtTitle.Text = row["Title"].ToString();
            txtAuthor.Text = row["Author"].ToString();
            txtYear.Text = row["Year"] == DBNull.Value ? "" : row["Year"].ToString();
            txtISBN.Text = row["ISBN"].ToString();
            cmbCategory.Text = row["Category"].ToString();
            btnSave.Text = "Update";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }

            int? year = null;
            if (!string.IsNullOrWhiteSpace(txtYear.Text))
            {
                if (int.TryParse(txtYear.Text.Trim(), out int y)) year = y;
                else
                {
                    MessageBox.Show("Year must be a number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtYear.Focus();
                    return;
                }
            }

            try
            {
                if (EditingId == 0)
                {
                    DBHelper.AddBook(txtTitle.Text.Trim(), txtAuthor.Text.Trim(), year, txtISBN.Text.Trim(), cmbCategory.Text.Trim());
                    MessageBox.Show("Book saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DBHelper.UpdateBook(EditingId, txtTitle.Text.Trim(), txtAuthor.Text.Trim(), year, txtISBN.Text.Trim(), cmbCategory.Text.Trim());
                    MessageBox.Show("Book updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
