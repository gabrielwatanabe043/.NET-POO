using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf, double salario) : base(cpf,salario) { }
        public override double getBonificacao() {
            return this.Salario + 0.20;
        }
        public override void AumentarSalario() {
            this.Salario = this.Salario + (this.Salario * 0.10);
        }
    }
}
