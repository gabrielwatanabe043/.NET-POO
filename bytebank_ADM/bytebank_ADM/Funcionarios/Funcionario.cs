using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalFuncionario { get; private set; }
    

        public Funcionario(string cpf, double salario) {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalFuncionario++;
        }

        //Usado palavra VIRTUAL pois declara que método pode ser reescrito
        public abstract double getBonificacao();

        public abstract void AumentarSalario();

        
    }
}
