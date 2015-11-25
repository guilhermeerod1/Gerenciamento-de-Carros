using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gerenciamento_de_Carros.Forms
{
    public partial class Carro : System.Web.UI.Page
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
                    Carro c = pesquisarCarro(Convert.ToInt32(id));
                    txtModelo.Text = c.Nome;
                    txtPreco.Text = c.Preco.ToString();
                    txtAnoModelo = c.AnoModelo.ToString();
                    txtKm.Text = c.Km.ToString();
                    txtCor.Text = c.Cor;
                    txtCombustivel = c.Combustivel;
                }

            }
        }


        private void LimparCampos()
        {
            txtModelo.Text = "";
            txtPreco.Text = "";
            txtAnoModelo = "";
            txtKm.Text = "";
            txtCor.Text = "";
            txtCombustivel = "";
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
                cadastrar();
            }
            else
            {
                editar(Convert.ToInt32(id));
            }
        }
    }
}