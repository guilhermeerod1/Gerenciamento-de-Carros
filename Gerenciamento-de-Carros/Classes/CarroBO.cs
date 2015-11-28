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

        public string InserirCarro(Carro c)
        {
            CarroDAO carroDAO = new CarroDAO();
            string mensagem = "Inserção efetuada com sucesso! Quantidade de registros alterados: ";

            try
            {
                carroDAO.AbrirConexao();

                mensagem += carroDAO.Inserir(c);

            }
            catch (Exception ex)
            {
                mensagem = "Erro relacionado ao método Inserir(). " + ex.Message;
            }
            finally
            {
                carroDAO.FecharConexao();
            }

            return mensagem;
        }

        public List<Carro> RetornarCarros()
        {
            CarroDAO carroDao = new CarroDAO();

            List<Carro> carros = new List<Carro>();

            try
            {
                carroDao.AbrirConexao();

                carros = carroDao.Retornar();
            }
            catch (Exception ex)
            {
                string mensagem = "Erro relacionado ao método RetornarCarro(). " + ex.Message;
                return null;
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

                c = carroDAO.Retornar(idCarro);

            }
            catch (Exception ex)
            {

                string mensagem = "Erro relacionado método RetornarCarro(). " + ex.Message;
                return null;

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
            string mensagem = "Remoção efetuada com sucesso! Quantidade de registros alterados: ";

            try
            {
                carroDAO.AbrirConexao();

                mensagem += carroDAO.Deletar(idCarro);
            }
            catch (Exception ex)
            {
                mensagem = "Erro relacionado ao método DeletarCarro()." + ex.Message;
            }
            finally
            {
                carroDAO.FecharConexao();
            }

            return mensagem;
        }

        public string AtualizarCarro(Carro c)
        {
            CarroDAO carroDao = new CarroDAO();
            string mensagem = "Atualização efetuada com sucesso! Quantidade de registros alterados: ";

            try
            {
                carroDao.AbrirConexao();

                mensagem += carroDao.Atualizar(c);

            }

            catch (Exception ex)
            {
                mensagem = "Erro relacionado ao método AtualizarCarro(). " + ex.Message;
            }
            finally
            {
                carroDao.FecharConexao();
            }

            return mensagem;
        }

    }
}