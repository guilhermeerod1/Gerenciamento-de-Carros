using Gerenciamento_de_Carros.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Gerenciamento_de_Carros.Classes
{
    public class CarroBO
    {

        public string Inserir(Carro c)
        {
            CarroDAO carroDAO = new CarroDAO();
            string mensagem = "";

            try
            {
                carroDAO.AbrirConexao();

                carroDAO.Inserir(c);

            }
            catch (SqlException ex)
            {
                mensagem = "Erro de SQL." + ex.Message;
            }
            catch (ArgumentException ex)
            {
                mensagem = "Erro na connection string." + ex.Message;
            }
            catch (Exception ex)
            {
                mensagem = ex.Message;
            }
            finally
            {
                carroDAO.FecharConexao();
            }

            return mensagem;
        }

        public List<Carro> RetornarCarros()
        {

        }

        public Carro RetornarCarro(int idCarro)
        {

        }

        public string DeletarCarro(int idCarro)
        {

        }

        public string InserirCarro(Carro carro)
        {

        }

        public string AtualizarCarro(Carro c)
        {

        }

    }
}