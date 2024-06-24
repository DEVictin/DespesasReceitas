using System;
using System.Text;


namespace DespesasReceitas
{
    class DespesasImportantes : Despesas
    {
        public DespesasImportantes(string gasto, double valorDespesa, DateTime dataDespesa) 
            : base(gasto, valorDespesa, dataDespesa)
        {
        }
        override public string ToString()
        {
            return string.Format("Gasto: {0}\nValor: R$ {1}; Data: {2}", Gasto, ValorDespesa, DataDespesa.ToString("dd/MM/yyyy"));
        }
    }
}
