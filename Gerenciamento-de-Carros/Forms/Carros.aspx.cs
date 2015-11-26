using Gerenciamento_de_Carros.Classes;
using Gerenciamento_de_Carros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gerenciamento_de_Carros.Forms
{
    public partial class Carros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string id = Request.QueryString["ID"];

                if (string.IsNullOrEmpty(id))
                {
                    btnCadastrar.Text = "Cadastrar";
                }
                else
                {
                    btnCadastrar.Text = "Editar";

                    CarroBO carroBO = new CarroBO();
                    Carro c = carroBO.RetornarCarro(Convert.ToInt32(id));

                    txtModelo.Text = c.Modelo.ToString();
                    txtPreco.Text = c.Preco.ToString();
                    txtAnoModelo.Text = c.AnoModelo.ToString();
                    txtKm.Text = c.Km.ToString();
                    txtCor.Text = c.Cor.ToString();
                    txtCombustivel.Text = c.Combustivel.ToString();
                }
            }
        }


        private void LimparCampos()
        {
            txtModelo.Text = "";
            txtPreco.Text = "";
            txtAnoModelo.Text = "";
            txtKm.Text = "";
            txtCor.Text = "";
            txtCombustivel.Text = "";
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"];

            if (string.IsNullOrEmpty(id))
            {
                CarroBO carroBO = new CarroBO();
                Carro carro = new Carro();

                carro.Modelo = txtModelo.Text;
                carro.Preco = Convert.ToDecimal(txtPreco.Text);
                carro.AnoModelo = Convert.ToInt32(txtAnoModelo.Text);
                carro.Km = Convert.ToInt32(txtKm.Text);
                carro.Cor = txtCor.Text;
                carro.Combustivel = txtCombustivel.Text;

                carroBO.InserirCarro(carro);
            }
            else
            {
                CarroBO carroBO = new CarroBO();
                Carro carro = new Carro();

                carro.Id = Convert.ToInt32(id);
                carro.Modelo = txtModelo.Text;
                carro.Preco = Convert.ToDecimal(txtPreco.Text);
                carro.AnoModelo = Convert.ToInt32(txtAnoModelo.Text);
                carro.Km = Convert.ToInt32(txtKm.Text);
                carro.Cor = txtCor.Text;
                carro.Combustivel = txtCombustivel.Text;

                carroBO.AtualizarCarro(carro);
            }
        }
    }
}