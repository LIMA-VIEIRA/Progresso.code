using System;
using System.Collections.Generic;

namespace Bank
    {
         class Program
        {
            static Lista<Conta> listcontas =new List<Contea>();
            static void Main(string[] args)
            {
                string opcaoUsuario = obterOpcaoUsuario();
                while (opcaoUsuario.ToUpper() != "X")
                {
                    switch (opcaoUsuario)
                {
                    case "1":
                    ListarContas();
                    break;
                    case "2":
                    InserirConta();
                    break;
                    case "3":
                    Transferir();
                    break;
                    case "4":
                    Sacar();
                    break;
                    case "5":
                    Depositar();
                    break;
                    case "C":
                    Console.Clear();
                    break;
                    default:
                      throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
                }
                Console.WriteLine("obrigado por ultilizar nossos serviços.");
                Console.ReadLine();
            }
            private static void Depositar()
            {
                Console.Write("Digite o numero da conta");
                int indiceConta = int.Parse(Console.ReadLine());
                
                Console. Write("Digite o valor a ser depositado:");
                double valorDeposito = double.Parse(Console.ReadLine());

                listConta[indiceconta].Depositar(valorDeposito);
            }   

            private static void Sacar()
            {
                Console.write("Digite o numero da conta:");
                int indiceConta =int.Parse(Console.ReadLine());

                Console.Weite("Digitar o valr a ser sacado:");
                double valorSaque = double.Parse(Console.ReadLine());

                listContas[indiceConta].Sacar(valorSacar);
            }
            private static void Transferir()
            {
                Console.Write("Digite o numero da conta de origem:");
                int indiceContaOrigem = int.Parse(Console.ReadLine());

                Console.Write(" Digite o numero da conta de destino:");
                int indeceContaDestino = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor a ser tnsferido":);
                double valorTransferencia = double.Parse(Console.ReadLine());

                listConta[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContasDestino]);
            }
            private static void InserirConta()
            {
                Console.WriteLine("Inserir nova conta");

                Console.Write("Digite 1para conta Fisica ou 2 para Juridica:");
                int entradaTipoConta = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome do Cliente:");
                string entradaNome = Console.ReadLine();

                Console.Write("Digite o saldo inicial:");
                double entadaSaldo = double.Parse(Console.ReadLine());

                Console.Write("Digite o Credito:");
                double entradaCredito = double.Parse(Console.ReadLine());

                Conta novaConta = new conta(tipoConta: (TipoConta)entradaTipoConta,
                                            saldo: entradaSaldo,
                                            Credito: entradaCredito,
                                            nome: entradaNome);
                listContas.Add(novaConta);                            
            }
            private static void ListarContas()
            {
                Console.WriteLine("Listar Contas");
                if (listContas.Count == 0)
                {
                    Console.WriteLine("Nenhuma conta cadastrada.");
                    return;
                }
                for(int i = 0; i< listContas.count; i++)
                {
                    Conta conta = listConta[i];
                    Console.Write("#{0} -",i);
                    Console.WriteLine(contas);
                }
            }
            private static string ObterOpcaoUsuario()
            {
                   Console.WriteLine();
                   Console.WriteLine("Bank a seo dispor!!!");
                   Console.WriteLine("informe a opção dejejada:");

                   Console.WriteLine("1- Listar contas");
                   Console.WriteLine("2- Inserir nova conta");
                   Console.WriteLine("3- Transferir");
                   Console.WriteLine("4- Sacar");
                   Console.WriteLine("5- Depositar");
                   Console.WriteLine("C- Limpar Tela");
                   Console.WriteLine("X- Sair");
                   Console.WriteLine();

                   string OpcaoUsuario = Console.ReadLine().ToUpper
                   Console.WriteLine();
                   return opcaoUsurio;
            }
        }
    }