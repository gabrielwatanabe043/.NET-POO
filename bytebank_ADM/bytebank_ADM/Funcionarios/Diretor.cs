using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        
        public  Diretor(string cpf, double salario):base(cpf, salario){ 
            
        }
        //Utilizado OVERRIDE para dizer que método está sobrescrito
        //Palavara BASE utilizado para dar acesso ao elementos da SUPERCLASSE
        public override double getBonificacao() {
            return this.Salario * 0.50;  
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        


    }
}
