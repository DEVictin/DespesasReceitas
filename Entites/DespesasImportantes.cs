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
    }
}
