using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DespesasReceitas
{
    class Receitas
    {
        public string Receita { get; set; }
        public double ValorReceita { get; set; }
        public DateTime DataReceita { get; set; }

        public Receitas(string receita, double valorReceita, DateTime dataReceita)
        {
            Receita = receita;
            ValorReceita = valorReceita;
            DataReceita = dataReceita;
        }
    }
}
