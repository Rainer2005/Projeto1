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
            ORÇAMENTO_SIMPLES SIMPLES = new ORÇAMENTO_SIMPLES();
            SIMPLES.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AGENDAR AGN = new AGENDAR();
            AGN.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLIENTE CLI = new CLIENTE();
            CLI.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FRM_SERVICO MTR = new FRM_SERVICO();
            MTR.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CONSULTAR_AGENDA AGENDA = new CONSULTAR_AGENDA();
            AGENDA.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            consultar_orçamento orc = new consultar_orçamento();
            orc.ShowDialog();   
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}