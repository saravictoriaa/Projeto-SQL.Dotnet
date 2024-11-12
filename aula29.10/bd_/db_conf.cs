using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace aula29._10.bd_
{
    public class db_conf
    {
        public static string conf = "server=localhost;userid=root;password=;database=mysqldotnet;";

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
     

    }
}
