class Program
{

    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
           
        string mensagem = $"Olá, {nome}! Seja muito bem-vindo!";
        
        Console.WriteLine(mensagem);
     }
}
