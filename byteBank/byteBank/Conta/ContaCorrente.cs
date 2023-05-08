using byteBank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace byteBank.Conta
{
    public class ContaCorrente
    {

        //Membro estático é uma propriedade relacionada à classe e não ao objeto. Os objetos conseguem acessar essa propriedade porque faz parte do contexto da classe, por isso o construtor conseguiu fazer o incremento dela.
        public static int TotalDeContasCriadas { get; private set; }

        //Por padrão as propriedades são públicas e encapsulam campos privados. <- QUANDO PRECISAR DE VALIDAÇÃO, USAR ASSIM
        private int numero_agencia;
        public int Numero_agencia 
        {
            get { return this.numero_agencia; }
            private set {
                            if (value > 0) { 
                            this.numero_agencia = value;
                            }
                    }
        }
        //private string conta;
        //Propriedades autoimplementadas, onde não preciso de nenhuma validação 
        public string Conta { get; set; }
        public Cliente Titular { get; set; }

        //Para atributo saldo, utilizei método normal
        private double saldo;

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.numero_agencia= numero_agencia;
            this.Conta = numero_conta;
            TotalDeContasCriadas++;
        }


        public double getSaldo() { 

            return this.saldo;
        }

        public void setSaldo(double valor) {
            if (valor > 0) {
                this.saldo = valor;
            }
            else
            {
                Console.WriteLine("Você está tentando depositar um valor negativo");
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }



        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;

            }
            else
            {
                return false;
            }

        }



        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (valor <= saldo)
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
