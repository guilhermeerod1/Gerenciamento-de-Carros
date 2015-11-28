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
    public partial class Visualizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarroBO carroBO = new CarroBO();
                List<Carro> listaDeCarros = carroBO.RetornarCarro();
            }


            if (listaDeCarros != null)
            {
                Repeater1.DataSource = listaDeCarros;
                Repeater1.DataBind();
            }
            else
            {
                lblMensagem.Text = "Nenhum Registro";
            }
        }

        protected void Repeater1_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == System.Web.UI.WebControls.ListItemType.Item || e.Item.ItemType == System.Web.UI.WebControls.ListItemType.AlternatingItem)
            {
                Carro carro = (Carro)e.Item.DataItem;

                Label lblId = (Label)e.Item.FindControl("lblId");
                Label lblModelo = (Label)e.Item.FindControl("lblModelo");
                Label lblPreco = (Label)e.Item.FindControl("lblPreco");
                Label lblAnoModelo = (Label)e.Item.FindControl("lblAnoModelo");
                Label lblKm = (Label)e.Item.FindControl("lblDataKm");
                Label lblCor = (Label)e.Item.FindControl("lblDataCor");
                Label lblCombustivel = (Label)e.Item.FindControl("lblCombustivel");

                HyperLink lnkEditar = (HyperLink)e.Item.FindControl("lnkEditar");
                HyperLink lnkExcluir = (HyperLink)e.Item.FindControl("lnkExcluir");

                lnkEditar.NavigateUrl = "~/Carros.aspx?ID=" + carro.Id;
                lnkExcluir.NavigateUrl = "~/Carros.aspx?remover=" + carro.Id;

                lblId.Text = carro.Id.ToString();
                lblModelo.Text = carro.Modelo.ToString();
                lblPreco.Text = carro.Preco.ToString();
                lblAnoModelo.Text = carro.AnoModelo.ToString();
                lblKm.Text = carro.Km.ToString();
                lblCor.Text = carro.Cor.ToString();
                lblCombustivel.Text = carro.Combustivel.ToString();

            }
        }
    }
}