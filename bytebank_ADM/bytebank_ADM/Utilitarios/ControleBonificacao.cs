using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitarios
{
    public class ControleBonificacao
    {
        public double TotalBonificacao { get;private set; }

        public void RegistraBonificacao(Funcionario funcionario) {
            TotalBonificacao += funcionario.getBonificacao();

        }
    }
}
