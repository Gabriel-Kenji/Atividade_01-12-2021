using System;

namespace Atividade_01_12_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicamentos medicamentos = new Medicamentos();
            int i = -1;
            while (i != 0)
            {
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("Menu\n");

                Console.WriteLine("0.Finalizar processo");
                Console.WriteLine("1.Cadastrar medicamento");
                Console.WriteLine("2.Consultar medicamento (sintético):");
                Console.WriteLine("3.Consultar medicamento (analítico):");
                Console.WriteLine("4.Comprar medicamento (cadastrar lote)");
                Console.WriteLine("5.Vender medicamento (abater do lote mais antigo)");
                Console.WriteLine("6.Listar medicamentos ");
                Console.WriteLine("--------------------------------------------------------------------------");
                int k = 0;
                while (k == 0)
                {
                    Console.Write("\nDigite o numero da opção desejada:");
                    string confi = Console.ReadLine();
                    if (!string.IsNullOrEmpty(confi))
                    {
                        bool result = int.TryParse(confi, out i);
                        if (result)
                        {
                            k++;
                        }
                        else
                        {
                            Console.WriteLine("Erro! Digite um valor valido.");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Erro! Digite um valor valido.");
                    }
                }

                switch (i)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("\nPrograma finalizado!\n\n");
                        break;

                    case 1:
                        Console.WriteLine("--------------------------------------------------------------------------\nAdicionar medicamento:");
                        int a = 0;
                        bool ex = false;
                        int id = 0;
                        string nome;
                        string laboratorio;
                        while (a == 0)
                        {
                            ex = false;
                            k = 0;
                            while (k == 0)
                            {
                                Console.Write("Digite o Id do medicamento:");
                                string confi = Console.ReadLine();
                                if (!string.IsNullOrEmpty(confi))
                                {
                                    bool result = int.TryParse(confi, out id);
                                    if (result)
                                    {
                                        k++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Erro! Digite um valor valido.");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Erro! Digite um valor valido.");
                                }
                            }
                            Medicamento medicamento1 = new Medicamento(id,"nome","lab",new List<Lote>());
                            foreach(Medicamento medicamentos1 in medicamentos.ListaMedicamentos)
                            {
                                
                                if (medicamentos1.Equals(medicamento1))
                                    ex = true;
                            }
                            
                            if (!ex)
                                a++;
                            else
                                Console.WriteLine("O Id digitado ja está em uso, digite um valido.\n");
                        }
                        Console.Write("Digite o nome do medicamento:");
                        nome = Console.ReadLine();
                        Console.Write("Digite o nome do laboratorio do medicamento:");
                        laboratorio = Console.ReadLine();

                        Medicamento medicamento = new Medicamento(id,nome,laboratorio,new List<Lote>());
                        medicamentos.adicionar(medicamento);

                        foreach(Medicamento medicamento2 in medicamentos.ListaMedicamentos)
                        {
                            Console.WriteLine("   " + medicamento2.ToString());
                        }
                        break;

                    case 2:
                        a = 0;
                        id = 0;
                        while (a == 0)
                        {
                            ex = false;
                            k = 0;
                            while (k == 0)
                            {
                                Console.Write("Digite o Id do medicamento:");
                                string confi = Console.ReadLine();
                                if (!string.IsNullOrEmpty(confi))
                                {
                                    bool result = int.TryParse(confi, out id);
                                    if (result)
                                    {
                                        k++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Erro! Digite um valor valido.");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Erro! Digite um valor valido.");
                                }
                            }
                            Medicamento medicamento2 = new Medicamento(id, "nome", "lab", new List<Lote>());
                            foreach (Medicamento medicamentos1 in medicamentos.ListaMedicamentos)
                            {
                                if (medicamentos1.Equals(medicamento2))
                                {
                                    ex = true;
                                }
                                    
                            }

                            if (ex)
                                a++;
                            else
                                Console.WriteLine("O Id digitado não existe.\n");
                        }
                        Medicamento medicamento3 = new Medicamento(id, "nome", "lab", new List<Lote>());
                        Console.WriteLine("\n"+medicamentos.pesquisar(medicamento3).ToString());
                        break;

                    case 3:
                        a = 0;
                        id = 0;
                        while (a == 0)
                        {
                            ex = false;
                            k = 0;
                            while (k == 0)
                            {
                                Console.Write("Digite o Id do medicamento:");
                                string confi = Console.ReadLine();
                                if (!string.IsNullOrEmpty(confi))
                                {
                                    bool result = int.TryParse(confi, out id);
                                    if (result)
                                    {
                                        k++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Erro! Digite um valor valido.");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Erro! Digite um valor valido.");
                                }
                            }
                            Medicamento medicamento2 = new Medicamento(id, "nome", "lab", new List<Lote>());
                            foreach (Medicamento medicamentos1 in medicamentos.ListaMedicamentos)
                            {
                                if (medicamentos1.Equals(medicamento2))
                                {
                                    ex = true;
                                }

                            }

                            if (ex)
                                a++;
                            else
                                Console.WriteLine("O Id digitado  não existe.\n");
                        }
                        Medicamento medicamento4 = new Medicamento(id, "nome", "lab", new List<Lote>());
                        Console.WriteLine("\n" + medicamentos.pesquisar(medicamento4).ToString());
                        Medicamento m = medicamentos.pesquisar(medicamento4);
                        Console.WriteLine("Lotes:\n");
                        foreach(Lote lote in m.Lotes)
                        {
                            Console.WriteLine(lote.ToString()+"\n");
                        }
                        break;

                    case 4:
                        a = 0;
                        id = 0;
                        int qtde = 0;
                        while (a == 0)
                        {
                            ex = false;
                            k = 0;
                            while (k == 0)
                            {
                                Console.Write("Digite o Id do medicamento:");
                                string confi = Console.ReadLine();
                                if (!string.IsNullOrEmpty(confi))
                                {
                                    bool result = int.TryParse(confi, out id);
                                    if (result)
                                    {
                                        k++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Erro! Digite um valor valido.");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Erro! Digite um valor valido.");
                                }
                            }
                            Medicamento medicamento2 = new Medicamento(id, "nome", "lab", new List<Lote>());
                            foreach (Medicamento medicamentos1 in medicamentos.ListaMedicamentos)
                            {
                                if (medicamentos1.Equals(medicamento2))
                                {
                                    ex = true;
                                }

                            }

                            if (ex)
                                a++;
                            else
                                Console.WriteLine("O Id digitado não existe.\n");
                        }

                        Medicamento medicamento5 = new Medicamento(id, "nome", "lab", new List<Lote>());

                        a = 0;

                        while (a == 0)
                        {
                            ex = false;
                            k = 0;
                            while (k == 0)
                            {
                                Console.Write("Digite o Id do lote:");
                                string confi = Console.ReadLine();
                                if (!string.IsNullOrEmpty(confi))
                                {
                                    bool result = int.TryParse(confi, out id);
                                    if (result)
                                    {
                                        k++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Erro! Digite um valor valido.");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Erro! Digite um valor valido.");
                                }
                            }
                            foreach (Lote lote1 in medicamentos.pesquisar(medicamento5).Lotes)
                            {
                                if (id == lote1.Id)
                                {
                                    ex = true;
                                }

                            }

                            if (!ex)
                                a++;
                            else
                                Console.WriteLine("O Id digitado ja está em uso, digite um valido.\n");
                        }

                        k = 0;
                        while (k == 0)
                        {
                            Console.Write("Digite o quantidade de medicamentos:");
                            string confi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(confi))
                            {
                                bool result = int.TryParse(confi, out qtde);
                                if (result)
                                {
                                    k++;
                                }
                                else
                                {
                                    Console.WriteLine("Erro! Digite um valor valido.");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Erro! Digite um valor valido.");
                            }
                        }

                         a = -1;
                        bool bissextos = false;
                        int mes = 0;
                        int dia = 0;
                        int ano = 0;
                        while (a != 0)
                        {
                            Console.WriteLine("Digite o ano de Vencimento:");
                            ano = Convert.ToInt32(Console.ReadLine());
                            if (ano > 0 && ano <= DateTime.Now.Year)
                            {
                                if ((ano / 4) == 0)
                                {
                                    if ((ano / 100) != 0)
                                    {
                                        bissextos = true;
                                    }
                                }
                                else if ((ano / 400) == 0)
                                {
                                    bissextos = true;
                                }
                                a = 0;
                            }

                        }
                        int m1 = -1;
                        while (m1 != 0)
                        {
                            Console.WriteLine("Digite o mes de Vencimento:");
                            mes = Convert.ToInt32(Console.ReadLine());
                            if (mes > 0 && mes < 13)
                            {
                                m1 = 0;
                            }
                        }
                        int d = -1;
                        while (d != 0)
                        {
                            Console.WriteLine("Digite o dia de Vencimento:");
                            dia = Convert.ToInt32(Console.ReadLine());
                            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                            {
                                if (dia <= 31 && dia > 0)
                                {
                                    d = 0;
                                }

                            }
                            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                            {
                                if (dia <= 30 && dia > 0)
                                {
                                    d = 0;
                                }
                            }
                            else if (mes == 2)
                            {
                                if (bissextos)
                                {
                                    if (dia <= 29 && dia > 0)
                                    {
                                        d = 0;
                                    }
                                }
                                else
                                {
                                    if (dia <= 28 && dia > 0)
                                    {
                                        d = 0;
                                    }
                                }
                            }
                        }
                        DateTime data = new DateTime(ano, mes, dia);
                        Lote lote2 = new Lote(id,qtde,data);

                        medicamentos.pesquisar(medicamento5).comprar(lote2);
                        Console.WriteLine("Lote comprado com sucesso");
                        break;

                    case 5:
                        a = 0;
                        id = 0;
                        qtde = 0;
                        while (a == 0)
                        {
                            ex = false;
                            k = 0;
                            while (k == 0)
                            {
                                Console.Write("Digite o Id do medicamento:");
                                string confi = Console.ReadLine();
                                if (!string.IsNullOrEmpty(confi))
                                {
                                    bool result = int.TryParse(confi, out id);
                                    if (result)
                                    {
                                        k++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Erro! Digite um valor valido.");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Erro! Digite um valor valido.");
                                }
                            }
                            Medicamento medicamento2 = new Medicamento(id, "nome", "lab", new List<Lote>());
                            foreach (Medicamento medicamentos1 in medicamentos.ListaMedicamentos)
                            {
                                if (medicamentos1.Equals(medicamento2))
                                {
                                    ex = true;
                                }

                            }

                            if (ex)
                                a++;
                            else
                                Console.WriteLine("O Id digitado não existe.\n");
                        }

                        Medicamento medicamento6 = new Medicamento(id, "nome", "lab", new List<Lote>());

                        k = 0;
                        while (k == 0)
                        {
                            Console.Write("Digite o quantidade de medicamentos:");
                            string confi = Console.ReadLine();
                            if (!string.IsNullOrEmpty(confi))
                            {
                                bool result = int.TryParse(confi, out qtde);
                                if (result)
                                {
                                    k++;
                                }
                                else
                                {
                                    Console.WriteLine("Erro! Digite um valor valido.");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Erro! Digite um valor valido.");
                            }
                        }
                        bool aaa = medicamentos.pesquisar(medicamento6).vender(qtde);
                        if (aaa)
                        {
                            Console.WriteLine("Venda realiza com sucesso");
                        }
                        else
                        {
                            Console.WriteLine("Não a medicamentos o suficiente para a venda");
                        }

                            break;
                    case 6:
                        Console.WriteLine("Lista de medicamentos");
                        foreach(Medicamento medicamento1 in medicamentos.ListaMedicamentos)
                        {
                            Console.WriteLine("\n" + medicamento1.ToString());
                        }
                        break;
                }
            }
        }
    }
}