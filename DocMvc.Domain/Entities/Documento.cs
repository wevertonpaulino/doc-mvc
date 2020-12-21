using System;

namespace DocMvc.Domain.Entities
{
    public class Documento
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Revisao { get; set; }
        public DateTime DataPlanejada { get; set; }
        public decimal Valor { get; set; }
    }
}
