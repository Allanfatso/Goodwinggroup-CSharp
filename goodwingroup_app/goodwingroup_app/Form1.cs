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
            pictureBox1.Load("C:\\Users\\racon\\Downloads\\images\\sopranos.jpg");

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

            String image = dataGrid.Rows[rowClicked].Cells[3].Value.ToString();
            pictureBox1.Load(image);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            SeriesClass serie = new SeriesClass
            {
                /*
                 *  ID = reader.GetInt32(0),
                        series_title = reader.GetString(1),
                        series_genre = reader.GetString(2),
                        year = reader.GetInt32(3),
                        image_name = reader.GetString(4),
                        description = reader.GetString(5),
                 * 
                 */
                series_title = txt_s_name.Text,
                series_genre = text_genre.Text,
                year = Int32.Parse(text_year.Text),
                image_name = text_image.Text,
                description = text_descr.Text,
                
            };

            SeriesDaOClass seriesdao = new SeriesDaOClass();
            int result = seriesdao.addSeries(serie);
            MessageBox.Show(result + " record added");
        }
    }
}
