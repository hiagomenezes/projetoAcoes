using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projetoacao.Models
{
    public class Acoes
    {
        public int Id { get; set; }
        public string NomeFaculdade { get; set; }
        public string QuantCartao { get; set; }
        public string QuantFunc { get; set; }
        public string LocalFaculdade { get; set; }
        public string InicioAcao { get; set; }
        public string TerminoAcao { get; set; }
    }
}