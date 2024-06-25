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
        override public string ToString()
        {
            return string.Format("Gasto: {0}\nValor: R$ {1}; Data: {2}", Gasto, ValorDespesa, DataDespesa.ToString("dd/MM/yyyy"));
        }
                public static double CalcularTotalDespesasNoPeriodo(List<DespesasSuperfluas> despesas, DateTime dataInicio, DateTime dataFim)
        {
            double total = 0;

            foreach (var despesa in despesas)
            {
                if (despesa.DataDespesa >= dataInicio && despesa.DataDespesa <= dataFim)
                {
                    total += despesa.ValorDespesa;
                }
            }

            return total;
        }
    }
}
