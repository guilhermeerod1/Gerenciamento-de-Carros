using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gerenciamento_de_Carros.Models
{
    public class Carro
    {

        public int Id { get; set; }
        public string Modelo { get; set; }
        public decimal Preco { get; set; }
        public int AnoModelo { get; set; }
        public int Km { get; set; }
        public string Cor { get; set; }
        public string Combustivel { get; set; }

    }
}