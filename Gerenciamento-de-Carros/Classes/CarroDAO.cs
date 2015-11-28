using Gerenciamento_de_Carros.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace Gerenciamento_de_Carros.Classes
{
    public class CarroDAO
    {

        private SqlConnection conexao;

        public CarroDAO()
        {
            conexao = new SqlConnection();
        }

        public void AbrirConexao()
        {
            conexao.ConnectionString = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            conexao.Open();
        }

        public void FecharConexao()
        {
            conexao.Close();
        }

        public Carro Retornar(int id)
        {
            Carro c = null;

            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT Id, Modelo, Preco, AnoModelo, Km, Cor, Combustivel");
            sql.Append(" FROM Carro");
            sql.Append(" WHERE Id = @Id");

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = sql.ToString();

            SqlParameter param1 = new SqlParameter("@Id", id);

            comando.Parameters.Add(param1);

            SqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                c = new Carro();
                c.Id = Convert.ToInt32(reader["Id"]);
                c.Modelo = reader["Modelo"].ToString();
                c.Preco = Convert.ToDecimal(reader["Preco"]);
                c.AnoModelo = Convert.ToInt32(reader["AnoModelo"]);
                c.Km = Convert.ToInt32(reader["Km"]);
                c.Cor = reader["Cor"].ToString();
                c.Combustivel = reader["Combustivel"].ToString();
            }
            
            return c;
        }

        public int Inserir(Carro carro)
        {
            int qtdRegistrosAfetados = 0;

            string modelo = carro.Modelo;
            decimal preco = Convert.ToDecimal(carro.Preco);
            int anomodelo = Convert.ToInt32(carro.AnoModelo);
            int km = Convert.ToInt32(carro.Km);
            string cor = carro.Cor;
            string combustivel = carro.Combustivel;

            StringBuilder sb = new StringBuilder();

            sb.Append(" INSERT INTO Carro");
            sb.Append(" (Modelo, Preco, AnoModelo, Km, Cor, Combustivel)");
            sb.Append(" VALUES");
            sb.Append(" (@0, @1, @2, @3, @4, @5)");

            SqlParameter paramModelo = new SqlParameter("@0", modelo);
            SqlParameter paramPreco = new SqlParameter("@1", preco);
            SqlParameter paramAnoModelo = new SqlParameter("@2", anomodelo);
            SqlParameter paramKm = new SqlParameter("@3", km);
            SqlParameter paramCor = new SqlParameter("@4", cor);
            SqlParameter paramCombustivel = new SqlParameter("@5", combustivel);

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = sb.ToString();
            comando.CommandType = System.Data.CommandType.Text;

            comando.Parameters.Add(paramModelo);
            comando.Parameters.Add(paramPreco);
            comando.Parameters.Add(paramAnoModelo);
            comando.Parameters.Add(paramKm);
            comando.Parameters.Add(paramCor);
            comando.Parameters.Add(paramCombustivel);
            
            qtdRegistrosAfetados = comando.ExecuteNonQuery();

            return qtdRegistrosAfetados;

        }

        public int Atualizar(Carro carro)
        {
            int qtdRegistrosAfetados = 0;

            int id = carro.Id;
            string modelo = carro.Modelo;
            decimal preco = Convert.ToDecimal(carro.Preco);
            int anoModelo = Convert.ToInt32(carro.AnoModelo);
            int km = Convert.ToInt32(carro.Km);
            string cor = carro.Cor;
            string combustivel = carro.Combustivel;
                        
            StringBuilder sb = new StringBuilder();
            sb.Append(" UPDATE Carro SET");
            sb.Append(" Modelo = @Modelo, Preco = @Preco, AnoModelo = @AnoModelo, Km = @Km, Cor = @Cor, Combustivel = @Combustivel");
            sb.Append(" WHERE Id = @Id");

            SqlParameter paramModelo = new SqlParameter("@Modelo", modelo);
            SqlParameter paramPreco = new SqlParameter("@Preco", preco);
            SqlParameter paramAnoModelo = new SqlParameter("@AnoModelo", anoModelo);
            SqlParameter paramKm = new SqlParameter("@Km", km);
            SqlParameter paramCor = new SqlParameter("@Cor", cor);
            SqlParameter paramCombustivel = new SqlParameter("@Combustivel", combustivel);
            SqlParameter paramId = new SqlParameter("@Id", id);

            SqlCommand comando = new SqlCommand();

            comando.Connection = conexao;
            comando.CommandText = sb.ToString();
            comando.CommandType = System.Data.CommandType.Text;

            comando.Parameters.Add(paramModelo);
            comando.Parameters.Add(paramPreco);
            comando.Parameters.Add(paramAnoModelo);
            comando.Parameters.Add(paramKm);
            comando.Parameters.Add(paramCor);
            comando.Parameters.Add(paramCombustivel);
            comando.Parameters.Add(paramId);
            
            qtdRegistrosAfetados = comando.ExecuteNonQuery();
            
            return qtdRegistrosAfetados;

        }

        public List<Carro> Retornar()
        {
            List<Carro> carros = null;

            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT Id, Modelo, Preco, AnoModelo, Km, Cor, Combustivel");
            sql.Append(" FROM Carro");

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = sql.ToString();

            SqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                carros = new List<Carro>();
                
                while (reader.Read())
                {
                    Carro c = new Carro();

                    c.Id = Convert.ToInt32(reader["Id"]);
                    c.Modelo = reader["Modelo"].ToString();
                    c.Preco = Convert.ToInt32(reader["Preco"]);
                    c.AnoModelo = Convert.ToInt32(reader["AnoModelo"]);
                    c.Km = Convert.ToInt32(reader["Km"]);
                    c.Cor = reader["Cor"].ToString();
                    c.Combustivel = reader["Combustivel"].ToString();

                    carros.Add(c);
                }
            }

            return carros;
        }

        public int Deletar(int idCarro)
        {
            int qtdRegistrosAfetados = 0;

            StringBuilder sb = new StringBuilder();
            sb.Append("DELETE FROM Carro WHERE Id = @Id");

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = sb.ToString();

            SqlParameter param1 = new SqlParameter("@Id", idCarro);

            comando.Parameters.Add(param1);

            qtdRegistrosAfetados = comando.ExecuteNonQuery();

            return qtdRegistrosAfetados;
        }

    }

}