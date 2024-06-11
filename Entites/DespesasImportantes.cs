using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
