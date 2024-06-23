using System;
using System.IO;
using DespesasReceitas;

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
                            string gasto = Console.ReadLine();
                            Console.WriteLine("Qual o valor da despesa: ");
                            double valorDespesa = double.Parse(Console.ReadLine());
                            Console.WriteLine("Quando precisa pagar? ");
                            DateTime dataDespesa = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                            Despesas despesa = new DespesasImportantes(gasto, valorDespesa, dataDespesa);

                            using (StreamWriter arquivo = File.AppendText("C:\\Temp\\DespesasImportantes.txt"))
                            {
                                string newLine = string.Format("{0};{1};{2}", despesa.Gasto, despesa.ValorDespesa, despesa.DataDespesa);
                                arquivo.WriteLine(newLine);
                            }
                            break;

                        case "2":
                            Console.WriteLine("Do que se trata sua despesa superflua? ");
                            gasto = Console.ReadLine();
                            Console.WriteLine("Qual o valor da despesa: ");
                            valorDespesa = double.Parse(Console.ReadLine());
                            Console.WriteLine("Quando precisa pagar? ");
                            dataDespesa = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                            despesa = new DespesasSuperfluas(gasto, valorDespesa, dataDespesa);

                            using (StreamWriter arquivo = File.AppendText("C:\\Temp\\DespesasSuperfluas.txt"))
                            {
                                string newLine = string.Format("{0};{1};{2}", despesa.Gasto, despesa.ValorDespesa, despesa.DataDespesa);
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
                    DateTime dataReceita = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                    Receitas newReceita = new Receitas(receita, valorReceita, dataReceita);

                    using (StreamWriter arquivo = File.AppendText("C:\\Temp\\Receitas.txt"))
                    {
                        string newLine = string.Format("{0};{1};{2}", newReceita.Receita, newReceita.ValorReceita, newReceita.DataReceita);
                        arquivo.WriteLine(newLine);
                    }
                    Console.ReadKey();
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("====================================== Personal Finances ===");
                    Console.WriteLine("============================================================");
                    Console.WriteLine("============================================================");
                    Console.WriteLine("Receitas: ");
                    Console.WriteLine("============================================================");
                    string[] linhas = File.ReadAllLines("C:\\Temp\\Receitas.txt");
                    foreach (string linha in linhas)
                    {
                        string[] dados = linha.Split(';');
                        Receitas receita1 = new Receitas(dados[0], double.Parse(dados[1]), DateTime.Parse(dados[2]));
                        Console.WriteLine(receita1);
                    }
                    Console.WriteLine("============================================================");
                    Console.WriteLine("============================================================");
                    Console.WriteLine("Despesas Importantes: ");
                    Console.WriteLine("============================================================");
                    string[] linhas2 = File.ReadAllLines("C:\\Temp\\DespesasImportantes.txt");
                    foreach (string linha in linhas2)
                    {
                        string[] dados = linha.Split(';');
                        DespesasImportantes despesa1 = new DespesasImportantes(dados[0], double.Parse(dados[1]), DateTime.Parse(dados[2]));
                        Console.WriteLine(despesa1);
                    }
                    Console.WriteLine("============================================================");
                    Console.WriteLine("============================================================");
                    Console.WriteLine("Despesas Superfluas: ");
                    Console.WriteLine("============================================================");
                    string[] linhas3 = File.ReadAllLines("C:\\Temp\\DespesasSuperfluas.txt");
                    foreach (string linha in linhas3)
                    {
                        string[] dados = linha.Split(';');
                        DespesasSuperfluas despesa1 = new DespesasSuperfluas(dados[0], double.Parse(dados[1]), DateTime.Parse(dados[2]));
                        Console.WriteLine(despesa1);
                    }
                    Console.ReadKey(); 
                    break;

                case "4":
                    File.Delete("C:\\Temp\\DespesasImportantes.txt");
                    File.Create("C:\\Temp\\DespesasImportantes.txt");
                    File.Delete("C:\\Temp\\DespesasSuperfluas.txt");
                    File.Create("C:\\Temp\\DespesasSuperfluas.txt");
                    Console.Clear();
                    Console.WriteLine("====================================== Personal Finances ===");
                    Console.WriteLine("============================================================");
                    Console.WriteLine("================== Despesas Excluidas!======================");
                    Console.WriteLine("============================================================");
                    Console.ReadKey();
                    break;

                case "5":
                    File.Delete("C:\\Temp\\Receitas.txt");
                    File.Create("C:\\Temp\\Receitas.txt");
                    Console.Clear();
                    Console.WriteLine("====================================== Personal Finances ===");
                    Console.WriteLine("============================================================");
                    Console.WriteLine("================== Receitas Excluidas!======================");
                    Console.WriteLine("============================================================");
                    Console.ReadKey();
                    break;

                case "6":
                    return;

                default:
                    Console.WriteLine("Opção Inválida!");
                    Console.ReadKey();
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
