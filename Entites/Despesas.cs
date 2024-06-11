using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DespesasReceitas
{
    class Despesas
    {
        public string Gasto { get; set; }
        public double ValorDespesa { get; set; }
        public DateTime DataDespesa { get; set; }

        public Despesas(string gasto, double valorDespesa, DateTime dataDespesa)
        {
            Gasto = gasto;
            ValorDespesa = valorDespesa;
            DataDespesa = dataDespesa;
        }
    }
}
