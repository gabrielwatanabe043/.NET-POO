class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 5 - Criando Variaveis Texto");

        //Para armazenar 1 caractere usando o CHAR
        //Para declarar um valor ao CHAR é usado apenas ASPAS SIMPLES.
        char umCaractere = 'a';
        Console.WriteLine(umCaractere);
        //Quando fazemos isso, ele interpreta o caractere fazendo referência a tabela ASCII.
        umCaractere = (char)65;
        Console.WriteLine(umCaractere);

        //String sempre usa com ASPAS DUPLAS

        string frase = "Alura - Curso de C#";
        Console.WriteLine(frase);

        
        


        for (int linha = 0; linha < 5; linha++)
        {
            for (int coluna = 0; coluna < 5; coluna++)
            {
                if ( coluna > linha )
                {
                    break;
                }
                Console.Write( coluna + 1);
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
