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
                
            }

            CarroBO carroBO = new CarroBO();
            List<Carro> listaDeCarros = carroBO.RetornarCarros();

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
    }
}