using System;
using System.Data;
using MySql.Data.MySqlClient;
using sharingvehicledesktop.Properties;


namespace sharingvehicledesktop.BancoDados
{
    class AcessoBancoDeDados
    {
        //Cria a conexão
        private MySqlConnection CriarConexao()
        {
            return new MySqlConnection(Settings.Default.conexaoP);
        }

        //Parâmetros que vão para o banco
        //Coleção de Parametros
        private MySqlParameterCollection sqlParameterCollection = new MySqlCommand().Parameters;


        public void LimparParametros()
        {
            //Limpar para usar
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new MySqlParameter(nomeParametro, valorParametro));
        }

        //Persistência - inserir, Alterar, Excluir
        public object ExecutarManipulacao(CommandType commandType, string nomeStoredProcedureOuSQL)
        {
            //Tipo de Comando Procedure ou SQL (Enum, lista que não muda)
            try
            {
                //Cria conexao
                MySqlConnection sqlConnection = CriarConexao();
                sqlConnection.Open();

                //Criar comando
                MySqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuSQL;

                sqlCommand.CommandTimeout = 300;

                //Adicionar os parametros no comando
                foreach (MySqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new MySqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Executar o comando
                return sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        //Consultar registros do banco de dados
        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedureOuSQL)
        {
            //Tipo de Comando Procedure ou SQL (Enum, lista que não muda)
            try
            {
                //Cria conexao
                MySqlConnection sqlConnection = CriarConexao();
                sqlConnection.Open();

                //Criar comando
                MySqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuSQL;

                sqlCommand.CommandTimeout = 300;

                //Adicionar os parametros no comando
                foreach (MySqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new MySqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Criar um adaptador, adaptar o banco a aplicação
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);

                //DataTable - Tabela de Dados vazia onde vou colocar os dados que vem do banco
                DataTable dataTable = new DataTable();

                //mandar o comando ir até o banco buscar os dados e o adaptador preenche o datatable
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
