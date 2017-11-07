namespace Dados
{
    public class ContaPessoaJuridica : Conta
    {
        public override double Sacar(double Valor){
            base.Sacar(Valor + 0.5);
            return this.Saldo;
        }
    }
}