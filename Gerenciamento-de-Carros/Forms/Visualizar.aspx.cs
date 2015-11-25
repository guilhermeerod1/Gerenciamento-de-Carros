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
            List<Carro> c = BuascarCarros();
            Repeater1.DataSource = 1;
            Repeater1.DataBind();
        }
    }
}