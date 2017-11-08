using System;
using Dados;
using Util;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            //Menu principal
            do{
                Console.WriteLine("Digite a opção: ");
                Console.WriteLine("1 - Cadastrar Conta");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Depositar");
                Console.WriteLine("9 - Sair");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarConta();
                        break;
                }
            }while(opcao != "9");
        }

        

        static void CadastrarConta(){
            Console.Write("Digite a Razão Social: ");
            string razaosocial = Console.ReadLine();

            Console.Write("Digite a data da abertura: ");
            string dataabertura = Console.ReadLine();

            string cnpj = new Validacao().pedirCNPJ();
            
            Console.Write("Digite seu número de conta: ");
            string numeroconta = Console.ReadLine();

            Console.Write("Digite a agencia: ");
            string agencia = Console.ReadLine();

            Console.Write("Digite o Saldo: ");
            double saldo = Convert.ToDouble(Console.ReadLine());

            ContaPessoaJuridica conta = new ContaPessoaJuridica();
            conta.CadastrarConta(numeroconta, agencia, saldo, razaosocial, Convert.ToDateTime(dataabertura), cnpj);
        }
    }
}