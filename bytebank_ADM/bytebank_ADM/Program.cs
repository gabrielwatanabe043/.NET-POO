using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitarios;
class Program 
{
    static void Main(string[] args) 
    {
        SistemaInterno sistema = new SistemaInterno();

        Diretor ingrid = new Diretor("852741", 5000);
        ingrid.Nome = "Ingrid Novaes";
        ingrid.Senha = "123";

        GerenteDeContas ursula = new GerenteDeContas("963741", 1000);
        ursula.Nome = "Ursula Alcantara";
        ursula.Senha = "321";

        ParceiroComercial caio = new ParceiroComercial();
        caio.Senha = "999";

        sistema.Logar(ingrid, "123");
        sistema.Logar(ursula, "963");
        sistema.Logar(caio, "999");

    }
}


