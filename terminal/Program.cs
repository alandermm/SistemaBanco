using System;
using Dados;
using Util;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Validacao validacao = new Validacao();

            /*bool cpfvalido = false;
            string cpf = "";

            do{
                //Pede o cpf para o usuário
                Console.WriteLine("Informe seu CPF");
                //Recebe o cpf do usuário
                cpf = Console.ReadLine();

                //Recebe o retorno do método Validar CPF
                cpfvalido = validacao.ValidarCPF(cpf);

                //Caso seja um cpf inválido informa ao usuário
                if(cpfvalido == false){
                    Console.WriteLine("CPF inválido");
                }
            } while (cpfvalido == false); //Faça enquanto cpf inválido

            Console.WriteLine("CPF válido");*/

            //string doc = validacao.pedirCPF();

            /*//Cria o objeto da conta
            Conta conta = new Conta();

            //Deposita valor na conta
            conta.Depositar(100.00);

            //Imprime saldo atual
            Console.WriteLine("Seu saldo é: " + conta.Saldo);

            conta.Depositar(100.00);
            //Imprime saldo atual
            Console.WriteLine("Seu saldo é: " + conta.Saldo);

            conta.Sacar(50.00);

            //Mostra o saldo para usuário
            Console.WriteLine("Seu saldo é: " + conta.Saldo);*/

            ContaPessoaFisica contapf = new ContaPessoaFisica();
            contapf.Sacar(50.00);

            //Mostra o saldo para o usuário
            Console.WriteLine("O seu saldo é: " + contapf.Saldo);

            contapf.Depositar(1000000.00);

            //Mostra o saldo para o usuário
            Console.WriteLine("O seu saldo é: " + contapf.Saldo);

            ContaPessoaJuridica contapj = new ContaPessoaJuridica();
            contapj.Depositar(500.00);
            //Mostra o saldo para o usuário
            Console.WriteLine("O seu saldo é: " + contapj.Saldo);

            contapj.Sacar(50.00);
            //Mostra o saldo para o usuário
            Console.WriteLine("O seu saldo é: " + contapj.Saldo);


        }
    }
}
