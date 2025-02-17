class Program
{

    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
           
        string mensagem = $"Olá, {nome}! Seja muito bem-vindo!";
        
        Console.WriteLine(mensagem);

        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();
           
        string mensagem2 = $"Bom {nome + " " + sobrenome}, agora podemos dar início!";
        Console.WriteLine(mensagem2);

        Console.Write("Por gentileza escreva um número quebrado aleatório: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Agora outro, por favor: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        double soma = numero1 + numero2;
        double subtração = numero1 - numero2;
        double multiplicacao = numero1 * numero2;
        double divisao = numero2 != 0 ? numero1 / numero2 : double.NaN;
        double media = (numero1 + numero2) / 2;
        

        Console.WriteLine($"\nResultados:");
        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtração}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");
        if (numero2 != 0)
        {
            Console.WriteLine($"Divisão: {divisao}");
        }
        else
        {
            Console.WriteLine("Divisão: Não é possível dividir por zero!");
        }
        Console.WriteLine($"\nA média entre {numero1} e {numero2} é: {media}");

        Console.Write("Agora escreva uma palavra ou frase, por favor: ");
        string input = Console.ReadLine();

        int contador = 0;

        foreach (char c in input)
        {
          if (c != ' ')
            {
              contador++;
            }
        }

        Console.WriteLine($"A quantidade de caracteres (ignorando espaços) é: {contador}");


    }
}

