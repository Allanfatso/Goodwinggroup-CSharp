namespace goodwingroup_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            Add = new Button();
            text_descr = new TextBox();
            text_year = new TextBox();
            text_image = new TextBox();
            text_genre = new TextBox();
            txt_s_name = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1122, 12);
            button1.Name = "button1";
            button1.Size = new Size(218, 34);
            button1.TabIndex = 0;
            button1.Text = "Load Series";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(403, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(533, 225);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(796, 12);
            button2.Name = "button2";
            button2.Size = new Size(140, 31);
            button2.TabIndex = 2;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(403, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(354, 31);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1122, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Add);
            groupBox1.Controls.Add(text_descr);
            groupBox1.Controls.Add(text_year);
            groupBox1.Controls.Add(text_image);
            groupBox1.Controls.Add(text_genre);
            groupBox1.Controls.Add(txt_s_name);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 363);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Series";
            // 
            // Add
            // 
            Add.Location = new Point(74, 260);
            Add.Name = "Add";
            Add.Size = new Size(112, 34);
            Add.TabIndex = 15;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // text_descr
            // 
            text_descr.Location = new Point(126, 207);
            text_descr.Name = "text_descr";
            text_descr.Size = new Size(150, 31);
            text_descr.TabIndex = 14;
            // 
            // text_year
            // 
            text_year.Location = new Point(126, 170);
            text_year.Name = "text_year";
            text_year.Size = new Size(150, 31);
            text_year.TabIndex = 13;
            // 
            // text_image
            // 
            text_image.Location = new Point(126, 133);
            text_image.Name = "text_image";
            text_image.Size = new Size(150, 31);
            text_image.TabIndex = 12;
            // 
            // text_genre
            // 
            text_genre.Location = new Point(126, 96);
            text_genre.Name = "text_genre";
            text_genre.Size = new Size(150, 31);
            text_genre.TabIndex = 11;
            // 
            // txt_s_name
            // 
            txt_s_name.Location = new Point(126, 59);
            txt_s_name.Name = "txt_s_name";
            txt_s_name.Size = new Size(150, 31);
            txt_s_name.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 210);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 6;
            label5.Text = "Description";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 173);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 9;
            label4.Text = "year";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 139);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 7;
            label2.Text = "image";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-4, 62);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 8;
            label3.Text = "series name";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-4, 102);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 6;
            label1.Text = "series genre";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 450);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox text_descr;
        private TextBox text_year;
        private TextBox text_image;
        private TextBox text_genre;
        private TextBox txt_s_name;
        private Button Add;
    }
}
