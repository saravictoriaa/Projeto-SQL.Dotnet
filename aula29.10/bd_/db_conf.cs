using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace aula29._10.bd_
{
    public class db_conf
    {
        public static string conf = "server=localhost;userid=root;password=;database=msqdotnet;";

        private MySqlConnection conexao = new MySqlConnection(conf);

        ~db_conf()
        {
        }
        public string connf()
        {
            return conf;
        }
        public void DAO()
        {
            try
            {
                conexao.Open();
            }
            catch
            {
                MessageBox.Show("Erro o conectar com banco de dados", "ERRO");
            }
        }
        public void INSEREGENERIC(string query)
        {
            MySqlCommand INSERE = new MySqlCommand(query, conexao);
            INSERE.ExecuteNonQuery();
            try
            {
                MessageBox.Show("Registro inserido com sucesso!", "Sucesso");
            }
            catch
            {
                MessageBox.Show("Algo não correu como o esperado durante a conexão com o banco.", "OPSS");
            }
        }

        public MySqlDataAdapter SELECTGENERIC(string query)
        {
            MySqlCommand mySqlCommand = new MySqlCommand(query, conexao);
            mySqlCommand.ExecuteNonQuery();
            MySqlDataAdapter result = new MySqlDataAdapter(mySqlCommand);


            try
            {
                conexao.Close();

            }
            catch
            {
                MessageBox.Show("Erro ao buscar os dados no banco !\nSe essa maquina contem o servidor de dados tente reiniciar ela caso o contrario reinicei o servidor Se o erro persistir entre em contato com o desenvolvedor", "Erro");
                conexao.Close();
            }
            return result;
        }

    }
}
