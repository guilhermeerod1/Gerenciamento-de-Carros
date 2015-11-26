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
        private string mensagem;

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
                mensagem = "Erro relacionado ao método Inserir()." + ex.Message;
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

        public List<Carro> RetornarCarro()
        {
            CarroDAO carroDao = new CarroDAO();

            List<Carro> carros = new List<Carro>();

            try
            {
                carroDao.AbrirConexao();

                carros = carroDao.RetornarCarros();
            }
            catch (SQLException ex)
            {
                mensagem = "Erro relacionado ao método RetornarCarro()." + ex.Message;
            }
            finally
            {
                carroDao.FecharConexao();
            }
    
            return carros;

        }

        public Carro RetornarCarro(int idCarro)
        {
            Carro c = null;

            CarroDAO carroDAO = new CarroDAO();

            try
            {
                carroDAO.AbrirConexao();

                c = carroDAO.retornarCarro(idCarro);

            }
            catch (SQLException ex)
            {

                mensagem = "Erro relacionado método RetornarCarro()." + ex.Message;

            }
            finally
            {
                carroDAO.FecharConexao();
            }

            return c;

        }

        public string DeletarCarro(int idCarro)
        {
            CarroDAO carroDAO = new CarroDAO();
            string mensagem = "";

            try
            {
                carroDAO.AbrirConexao();

                carroDAO.deletar(idCarro);
            }
            catch (SQLException ex)
            {
                mensagem = "Erro relacionado ao método DeletarCarro()." + ex.Message;
            }
            finally
            {
                carroDAO.FecharConexao();
            }

            return mensagem;
        }

        public string InserirCarro(Carro carro)
        {
            CarroDAO carroDao = new CarroDAO();

            try
            {
                carroDao.AbrirConexao();

                carroDao.Inserir(carro);
            }

            catch (SqlException ex)
            {
                mensagem = "Erro relacionado método InserirCarro()." + ex.Message;
            }
            finally
            {
                carroDao.FecharConexao();
            }

            return mensagem;
        }

        public string AtualizarCarro(Carro c)
        {
            CarroDAO carroDao = new CarroDAO();

            try
            {
                carroDao.FecharConexao();

                carroDao.atualizar(c);
            }

            catch (SqlException ex)
            {
                mensagem = "Erro relacionado método AtualizarCarro()." + ex.Message;
            }
            finally
            {
                carroDao.FecharConexao();
            }

            return mensagem;
        }

    }
}