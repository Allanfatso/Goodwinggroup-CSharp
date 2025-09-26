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
    public partial class ViewBooksForm : Form
    {
        public ViewBooksForm()
        {
            InitializeComponent();
            this.Load += ViewBooksForm_Load;

            btnSearch.Click += btnSearch_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            dgvBooks.DoubleClick += dgvBooks_DoubleClick;
        }

        private void ViewBooksForm_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData(string search = "")
        {
            try
            {
                DataTable dt = string.IsNullOrEmpty(search) ? DBHelper.GetAllBooks() : DBHelper.SearchBooks(search);
                dgvBooks.DataSource = dt;
                if (dgvBooks.Columns["ID"] != null) dgvBooks.Columns["ID"].Width = 60;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) => LoadData(txtSearch.Text.Trim());

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var f = new AddBookForm();
            if (f.ShowDialog() == DialogResult.OK) LoadData();
        }

        private int? GetSelectedId()
        {
            if (dgvBooks.CurrentRow == null) return null;
            if (dgvBooks.CurrentRow.Cells["ID"].Value == null) return null;
            return Convert.ToInt32(dgvBooks.CurrentRow.Cells["ID"].Value);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId();
            if (id == null) { MessageBox.Show("Select a book to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            using var f = new AddBookForm(id.Value);
            if (f.ShowDialog() == DialogResult.OK) LoadData();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var id = GetSelectedId();
            if (id == null) { MessageBox.Show("Select a book to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (MessageBox.Show("Are you sure you want to delete the selected book?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    DBHelper.DeleteBook(id.Value);
                    MessageBox.Show("Deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvBooks_DoubleClick(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e);
        }

    }
}
