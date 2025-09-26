namespace Library
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnViewBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblTotal = new Label();
            btnViewBooks = new Button();
            btnAddBook = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(296, 48);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Library Manager";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(380, 28);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(123, 25);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total books: 0";
            lblTotal.Click += lblTotal_Click;
            // 
            // btnViewBooks
            // 
            btnViewBooks.Location = new Point(200, 320);
            btnViewBooks.Name = "btnViewBooks";
            btnViewBooks.Size = new Size(160, 36);
            btnViewBooks.TabIndex = 1;
            btnViewBooks.Text = "View / Search";
            btnViewBooks.UseVisualStyleBackColor = true;
            btnViewBooks.Click += btnViewBooks_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(30, 320);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(120, 36);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(380, 320);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 36);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(520, 380);
            Controls.Add(btnExit);
            Controls.Add(btnViewBooks);
            Controls.Add(btnAddBook);
            Controls.Add(lblTotal);
            Controls.Add(lblTitle);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
