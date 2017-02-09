using System.Data.SqlClient;
using System.Data;

namespace Negocio
{
    public class clAcessoDB
    {
        //variável para receber a string de conexão
        public string vConexao = "";

        //método responsável por abrir a conexão com o banco
        //de dados
        public SqlConnection AbreBanco()
        {
            //Abre a Conexão com a Base de Dados
            SqlConnection conn = new SqlConnection(vConexao);
            conn.Open();
            return conn;
        }

        //método responsável por fechar a conexão com o banco
        //de dados
        public void FechaBanco(SqlConnection conn)
        {
            //Fecha a Conexão com a Base de Dados
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public void ExecutaComando(string strQuery)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = AbreBanco();
                SqlCommand cmdComando = new SqlCommand();
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = conn;

                //passa os valores da quer SQL, tipo do comando
                //conexao e executa o comando
                cmdComando.ExecuteNonQuery();
            }
            //tratamento de excessoes
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                //em caso de erro ou não, finaliza
                FechaBanco(conn);
            }
        }
    }
}
