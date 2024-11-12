using aula29._10.bd_;

namespace aula29._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db_conf opconn = new db_conf();
            opconn.DAO();
            string nome = txtbnome.Text;
            string endereco = txtendereco2.Text;
            if (nome == "" || endereco == "")
            {
                MessageBox.Show( 'Nenhum campo pode ficar vazio');
                return;
            }
            string INSERT = "INSERT INTO cliente( nome, endereco) VALUES('"+nome+"','"+endereco+"')";
            opconn.INSEREGENERIC(INSERT);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtendereco2_TextChanged(object sender, EventArgs e)
        {
            string nome = txtbnome.Text;
        }

        private void lbl1nm_Click(object sender, EventArgs e)
        {

        }

        private void lbl2end_Click(object sender, EventArgs e)
        {

        }
    }
}
