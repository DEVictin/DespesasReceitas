using System;
using System.Text;


namespace DespesasReceitas
{
    class DespesasSuperfluas : Despesas
    {
        public DespesasSuperfluas(string gasto, double valorDespesa, DateTime dataDespesa) 
            : base(gasto, valorDespesa, dataDespesa)
        {
        }
    }
}
