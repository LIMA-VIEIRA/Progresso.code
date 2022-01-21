using System;

namespace Bamk
{

    public class Conta
    {
        //Atributos    
        
        private Tipoconta Tipoconta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }
        //Metodos
        public Conta(Tipoconta tipoconta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoconta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }
        public bool Sacar(double valorSaque)
        {
            if (this.Saldo - valorSaque < (this.credito *-1)){
                Console.Writeline("Saldo insuficiente");
                return false;
                this.Saldo -= valorSaque;
                Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
                return true;
            }

        public void Depositar(double valorDeposito)
            {
                this.Saldo += valorDepositado;
                Console.WriteLine("Saldo atual da conta de {0} é {1}",this.Nome, this.Saldo);
            }

        public void Transferir(double valorTransferencia, Conta contaDestino)
            {
                if (this.Sacar(valorTransferencia)){
                    contaDestino.Depositar(valorTransferencia);
                }
            }
            
        public overrite string ToString()
        {
               string retorno = "";
               retorno += "Tipoconta" + this.Tipoconta + "|";
               retorno += "Nome" + this.Nome + "|";
               retorno += "Saldo" + this.Saldo + "|";
               retorno += "Credito" + this.Credito;
               return retorno;
        }

    }
}