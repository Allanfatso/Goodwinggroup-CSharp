namespace Library
{
    partial class AddBookForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelCategory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(20, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(33, 15);
            this.labelTitle.Text = "Title *";
            // txtTitle
            this.txtTitle.Location = new System.Drawing.Point(120, 18);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(260, 23);
            // labelAuthor
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(20, 62);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Text = "Author";
            // txtAuthor
            this.txtAuthor.Location = new System.Drawing.Point(120, 58);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(260, 23);
            // labelYear
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(20, 102);
            this.labelYear.Name = "labelYear";
            this.labelYear.Text = "Year";
            // txtYear
            this.txtYear.Location = new System.Drawing.Point(120, 98);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 23);
            // labelISBN
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(20, 142);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Text = "ISBN";
            // txtISBN
            this.txtISBN.Location = new System.Drawing.Point(120, 138);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(180, 23);
            // labelCategory
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(20, 182);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Text = "Category";
            // cmbCategory
            this.cmbCategory.Location = new System.Drawing.Point(120, 178);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 23);
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            // btnSave
            this.btnSave.Location = new System.Drawing.Point(120, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(240, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.ClientSize = new System.Drawing.Size(420, 340);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        }
    }
}
