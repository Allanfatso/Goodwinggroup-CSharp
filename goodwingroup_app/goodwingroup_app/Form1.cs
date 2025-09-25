namespace goodwingroup_app
{
    public partial class Form1 : Form
    {
        BindingSource seriesbindingsource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        /*
         *  public int ID { get; set; }
        public String series_title { get; set; }

        public int YEAR { get; set; }

        public String image { get; set; }

        public String description { get; set; }

        public String genre { get; set }
         * 
         * 
         */
        private void button1_Click_1(object sender, EventArgs e)
        {
            SeriesDaOClass seriesdao = new SeriesDaOClass();
            // connect to mysql database and return all series



            seriesbindingsource.DataSource = seriesdao.GetallSeries();

            dataGridView1.DataSource = seriesbindingsource;
            pictureBox1.Load("https://m.media-amazon.com/images/M/MV5BMjRmMTNiMTQtMDg1ZS00MGM1LWE1MGUtYjEzMGFjNWUzOWRkXkEyXkFqcGc@.jpg");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeriesDaOClass seriesdao = new SeriesDaOClass();
            // connect to mysql database and return all series



            seriesbindingsource.DataSource = seriesdao.searchTitles
                (textBox1.Text);

            dataGridView1.DataSource = seriesbindingsource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;

            int rowClicked = dataGrid.CurrentRow.Index;

            String imageUrl = dataGrid.Rows[rowClicked].Cells[3].Value.ToString();
            pictureBox1.Load(imageUrl);
            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
        }
    }
}
