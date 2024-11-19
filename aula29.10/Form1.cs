using System.Data;
using System.Security.Cryptography.X509Certificates;
using aula29._10.bd_;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace aula29._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Plista();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db_conf opconn = new db_conf();
            opconn.DAO();
            string nome = txtbnome.Text;
            string endereco = txtendereco2.Text;
            if (nome == "" || endereco == "")
            {
                MessageBox.Show("Nenhum campo pode ficar vazio");
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

        public void Plista()
        {
            db_conf conect_querygeneric = new db_conf();
            conect_querygeneric.DAO();
            string query = "SELECT id_cliente as 'Codigo', nome as 'Nome', endereco as 'Endereço' FROM cliente WHERE 1";
            try
            {
                DataTable dataTable = new DataTable();
                conect_querygeneric.SELECTGENERIC(query).Fill(dataTable);
                dgNomes.DataSource = dataTable;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Erro ao carregar os dados da tabela usuario", "ERRO");
            }
            
           
        }
    }
}
