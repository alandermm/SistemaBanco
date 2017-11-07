namespace Dados
{
    public class ContaPessoaFisica : Conta
    {
        public Pessoa Pessoa {get; set;}

        /// <summary>
        /// Efetua saque na conta pessoa física mais 10 centavos
        /// </summary>
        /// <param name="Valor">Parâmetro do tipo double com o valor do saque</param>
        /// <returns>Retorna o saldo</returns>
        public override double Sacar(double Valor){
            base.Sacar(Valor + 0.10);
            return this.Saldo;
        }

        /// <summary>
        /// Efetua depósito na conta pessoa física mais 1 centavo
        /// </summary>
        /// <param name="Valor">Parâmetro do tipo double com o valor do deposito</param>
        /// <returns>Retorna o saldo</returns>
        public override double Depositar(double Valor){
            this.Saldo += Valor + 0.01;
            return this.Saldo;
        }
    }
}