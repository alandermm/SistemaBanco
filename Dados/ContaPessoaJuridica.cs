using System;
namespace Dados
{
    public class ContaPessoaJuridica : Conta
    {
        public Empresa empresa {get; set;}
        public override double Sacar(double Valor){
            base.Sacar(Valor + 0.5);
            return this.Saldo;
        }

        public void CadastrarConta(string Numero, string Agencia, double Saldo, string RazaoSocial, DateTime DataAbertura, string CNPJ){
            
        }
    }
}