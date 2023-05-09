﻿using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf, double salario) : base (cpf,salario) { }
        public override double getBonificacao() {
            return this.Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario = this.Salario + (this.Salario * 0.05);
        }
    }
}
