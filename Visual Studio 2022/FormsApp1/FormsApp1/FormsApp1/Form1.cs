namespace FormsApp1
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           ORCAMENTO NOVO = new ORCAMENTO();
           NOVO.ShowDialog();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
       
        }

        private void button5_Click(object sender, EventArgs e)
        {
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLIENTE CLI = new CLIENTE();
            CLI.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
          servico adc = new servico();
            adc.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
      
        }

        private void button7_Click(object sender, EventArgs e)
        {
            consultar_or�amento orc = new consultar_or�amento();
            orc.ShowDialog();   
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}