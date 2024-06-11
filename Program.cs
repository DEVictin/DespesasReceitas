using System;
using System.IO;
using DespesasReceitas;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        string n = "";
        while (n == "")
        {
            Painel();
            n = Console.ReadLine();

            switch (n)
            {
                case "1":
                    PainelDespesas();
                    n = Console.ReadLine();
                    switch (n)
                    {
                        case "1":
                            Console.WriteLine("Do que se trata sua despesa importante? ");
                            string gastoImportante = Console.ReadLine();
                            Console.WriteLine("Qual o valor da despesa: ");
                            double valorDespesaImportante = double.Parse(Console.ReadLine());
                            Console.WriteLine("Quando precisa pagar? ");
                            DateTime dataDespesaImportante = DateTime.Parse(Console.ReadLine());
                            Despesas despesaImportante = new DespesasImportantes(gastoImportante, valorDespesaImportante, dataDespesaImportante);

                            using (StreamWriter arquivo = File.AppendText("DespesasImportantes.txt"))
                            {
                                string newLine = string.Format("{0};{1};{2}", despesaImportante.Gasto, despesaImportante.ValorDespesa, despesaImportante.DataDespesa);
                                arquivo.WriteLine(newLine);
                            }
                            break;

                        case "2":
                            Console.WriteLine("Do que se trata sua despesa superflua? ");
                            string gastoSuperfluo = Console.ReadLine();
                            Console.WriteLine("Qual o valor da despesa: ");
                            double valorDespesaSuperflua = double.Parse(Console.ReadLine());
                            Console.WriteLine("Quando precisa pagar? ");
                            DateTime dataDespesaSuperflua = DateTime.Parse(Console.ReadLine());
                            Despesas despesaSuperflua = new DespesasSuperfluas(gastoSuperfluo, valorDespesaSuperflua, dataDespesaSuperflua);

                            using (StreamWriter arquivo = File.AppendText("DespesasSuperfluas.txt"))
                            {
                                string newLine = string.Format("{0};{1};{2}", despesaSuperflua.Gasto, despesaSuperflua.ValorDespesa, despesaSuperflua.DataDespesa);
                                arquivo.WriteLine(newLine);
                            }
                            break;
                    }
                    break;

                case "2":
                    PainelReceitas();
                    Console.Write("Do que se trata sua receita? ");
                    string receita = Console.ReadLine();
                    Console.Write("Qual o valor da receita? ");
                    double valorReceita = double.Parse(Console.ReadLine());
                    Console.Write("Qual a data que você irá receber? ");
                    DateTime dataReceita = DateTime.Parse(Console.ReadLine());
                    Receitas newReceita = new Receitas(receita, valorReceita, dataReceita);

                    using (StreamWriter arquivo = File.AppendText("Receitas.txt"))
                    {
                        string newLine = string.Format("{0};{1};{2}", newReceita.Receita, newReceita.ValorReceita, newReceita.DataReceita);
                        arquivo.WriteLine(newLine);
                    }
                    Console.ReadKey();
                    break;

                case "3":
                    Console.ReadKey();
                    break;

                default:
                    return;
            }
            n = "";
        }
        static void Painel()
        {
            Console.Clear();
            
            Console.WriteLine("====================================== Personal Finances ===");
            Console.WriteLine("============================================================");
            Console.WriteLine("============================================================");
            Console.WriteLine("=== 1 - Cadastrar Despesas            ======================");
            Console.WriteLine("=== 2 - Cadastrar Receitas            ======================");
            Console.WriteLine("=== 3 - Imprimir Relatório            ======================");
            Console.WriteLine("=== 4 - Limpar Despesas               ======================");
            Console.WriteLine("=== 5 - Limpar Receitas               ======================");
            Console.WriteLine("=== 6 - Sair                          ======================");
            Console.WriteLine("============================================================");
        }
        static void PainelDespesas()
        {
            Console.Clear();
            
            Console.WriteLine("====================================== Personal Finances ===");
            Console.WriteLine("============================================================");
            Console.WriteLine("============  Cadastrar Despesas ==========================");
            Console.WriteLine("============================================================");
            Console.WriteLine("====     1 - Despesas Importantes  =======================");
            Console.WriteLine("====     2 - Despesas Superfluas   =======================");
            Console.WriteLine("============================================================");
        }
        static void PainelReceitas()
        {
            Console.Clear();
           
            Console.WriteLine("====================================== Personal Finances ===");
            Console.WriteLine("============================================================");
            Console.WriteLine("==================  Cadastrar Receitas  ====================");
            Console.WriteLine("============================================================");


        }
    }
}

    

