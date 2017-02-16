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

        //DataSet é utilizado para retornar um volume grande de registros utilizado principalmente para o componente datagridview
        public DataSet RetornaDataSet(string strQuery)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                //abre a conexção com o banco de dados
                conn = AbreBanco();
                //cria objeto em comando
                SqlCommand cmdComando = new SqlCommand();
                //passa os valores da querry SQL, tipo de comando, conexão e executa o comando
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = conn;
                //declara um dataadapter
                SqlDataAdapter daAdaptador = new SqlDataAdapter();
                //declara um datacenter
                DataSet dsdataset = new DataSet();
                //passa o comando a ser executado pelo dataadapter
                daAdaptador.SelectCommand = cmdComando;
                //o dataAdapter faz a conexão com o banco de dados, carrega o dataset e fecha a conexão
                daAdaptador.Fill(dsdataset);
                //retorna o dataset carregado
                return dsdataset;
                //tratamento de Exeções
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                //em caso de erro ou não, o finally é executado para fechar a conexão com o banco de dados
                FechaBanco(conn);
            }
        }
    }
}
