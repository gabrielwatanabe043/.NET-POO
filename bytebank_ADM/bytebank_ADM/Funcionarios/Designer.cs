using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf, double salario):base(cpf,salario) { }
        public override double getBonificacao() {
            return this.Salario * 0.17;
        }
        public override void AumentarSalario() {
            this.Salario = this.Salario + (this.Salario * 0.11);
        }
    }
}
