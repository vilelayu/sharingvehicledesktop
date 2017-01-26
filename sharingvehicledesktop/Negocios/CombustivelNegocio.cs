using System;
using System.Data;
using sharingvehicledesktop.DTO;
using sharingvehicledesktop.BancoDados;

namespace sharingvehicledesktop.Negocios
{
    class CombustivelNegocio
    {
        AcessoBancoDeDados acessoDadosSqlServer = new AcessoBancoDeDados();
        
        /// <summary>
        /// permite cadastra abastecimento efetuado
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>

        public string InserirCombustivel(CombustivelDTO dto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("Carro_ID", dto.idCar);
                acessoDadosSqlServer.AdicionarParametros("combustivel", dto.combustivel);
                acessoDadosSqlServer.AdicionarParametros("Data", dto.dia);
                acessoDadosSqlServer.AdicionarParametros("Litros", dto.litro);
                acessoDadosSqlServer.AdicionarParametros("Valor", dto.valor);
              
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spInsereAbastecimento").ToString();
                return retorno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
            finally
            {
                acessoDadosSqlServer = null;
            }

        }
        
        /// <summary>
        /// permite apagar informaçao do abastecimento
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>

        public string DeletarCombustivel(CombustivelDTO dto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("_Carro_ID", dto.idCar);
                acessoDadosSqlServer.AdicionarParametros("_id", dto.id);
           

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spDeletaAbastecimento").ToString();
                return retorno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
            finally
            {
                acessoDadosSqlServer = null;
            }

        }
        
        /// <summary>
        /// permite alterar os dados cadastrado do abastecimento
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>

        public string AlterarCombustivel(CombustivelDTO dto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("_combustivel", dto.combustivel);
                acessoDadosSqlServer.AdicionarParametros("_Data", dto.dia);
                acessoDadosSqlServer.AdicionarParametros("_Litros", dto.litro);
                acessoDadosSqlServer.AdicionarParametros("_Valor", dto.valor);
                acessoDadosSqlServer.AdicionarParametros("_Carro_ID", dto.idCar);
                acessoDadosSqlServer.AdicionarParametros("_id", dto.id);


                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spAlterarAbastecimento").ToString();
                return retorno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
            finally
            {
                acessoDadosSqlServer = null;
            }

        }

        /// <summary>
        /// pesquisa todos os abastecimento efetuado
        /// </summary>
        /// <returns></returns>

        public string PesquisaCombustivel()
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
               
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisarAbastecimento").ToString();
                return retorno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
            finally
            {
                acessoDadosSqlServer = null;
            }

        }

        /// <summary>
        /// pesquisa os abastecimento efetuado em determinado veiculo
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>

        public string PesquisarIdCombustivel(CombustivelDTO dto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("_Carro_ID", dto.idCar);
             
                
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spDeletaAbastecimento").ToString();
                return retorno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
            finally
            {
                acessoDadosSqlServer = null;
            }

        }
    }
}
