using System;
using System.Data;
using sharingvehicledesktop.BancoDados;
using sharingvehicledesktop.DTO;


namespace sharingvehicledesktop.Negocios
{
    class CarroNegocio
    {
        AcessoBancoDeDados acessoDadosSqlServer = new AcessoBancoDeDados();
       
        /// <summary>
        /// permite inserir os dados do veiculo
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        
        public string InserirVeiculo(CarroDTO car)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("Combustivel", car.combustivel);
                acessoDadosSqlServer.AdicionarParametros("Cor", car.cor);
                acessoDadosSqlServer.AdicionarParametros("Marca", car.marca);
                acessoDadosSqlServer.AdicionarParametros("Modelo", car.modelo);
                acessoDadosSqlServer.AdicionarParametros("Placa", car.placa);
                acessoDadosSqlServer.AdicionarParametros("Quilometragem", car.quilometragem);
                acessoDadosSqlServer.AdicionarParametros("Renavan", car.Renavam);
                

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spInsereCarro").ToString();
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
        /// permite apagar informações do veiculo selecionado
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>

        public string DeletaVeiculo(CarroDTO car)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("_ID ", car.id);
               

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spDeletaCarro").ToString();
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
        /// permite alterar informações do veiculo
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>

        public string AtualizarVeiculo(CarroDTO car)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("_ID ", car.id);
                acessoDadosSqlServer.AdicionarParametros("_Combustivel", car.combustivel);
                acessoDadosSqlServer.AdicionarParametros("_Cor", car.cor);
                acessoDadosSqlServer.AdicionarParametros("_Marca", car.marca);
                acessoDadosSqlServer.AdicionarParametros("_Modelo", car.modelo);
                acessoDadosSqlServer.AdicionarParametros("_Placa", car.placa);
                acessoDadosSqlServer.AdicionarParametros("_Quilometragem", car.quilometragem);
                acessoDadosSqlServer.AdicionarParametros("_Renavan", car.Renavam);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spAlterarCarro").ToString();
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
        /// permite visualizar todos os veiculos cadastrados
        /// </summary>
        /// <returns></returns>

        public string PesquisaVeiculo()
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();



                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisarCarro").ToString();
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
        /// busca o veiculo referente o codigo selecionado
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        
        public string PesquisaidVeiculo(CarroDTO car)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("_ID", car.id);
                
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisarIdCarro").ToString();
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
       public string PesquisaRenavamVeiculo(CarroDTO car)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("_Renavam", car.Renavam);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisarRenavanCarro").ToString();
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
        public string PesquisaPlacaVeiculo(CarroDTO car)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("_Placa", car.Renavam);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "spPesquisarPlacaCarro").ToString();
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
