Exercícios de Programação em C#

Descrição

Este programa foi criado para praticar diversos conceitos de programação em C#, incluindo manipulação de entradas do usuário, operações matemáticas, controle de fluxo com if e foreach, e formatação de datas. O código cobre as seguintes funcionalidades:

Exibição de mensagens de boas-vindas.
Realização de operações matemáticas básicas (soma, subtração, multiplicação, divisão).
Cálculo de média entre dois números.
Contagem de caracteres de uma palavra ou frase, ignorando espaços.
Validação da placa de um veículo conforme o padrão brasileiro (antes de 2018).
Exibição da data e hora em diferentes formatos.

Funcionalidades

1. Mensagem de Boas-Vindas
O programa solicita ao usuário que digite seu nome e sobrenome, e exibe uma mensagem de boas-vindas personalizada com o nome do usuário.

Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();
string mensagem = $"Olá, {nome}! Seja muito bem-vindo!";
Console.WriteLine(mensagem);

Em seguida, o programa pede o sobrenome e exibe uma nova mensagem.

Console.Write("Digite seu sobrenome: ");
string sobrenome = Console.ReadLine();
string mensagem2 = $"Bom {nome + " " + sobrenome}, agora podemos dar início!";
Console.WriteLine(mensagem2);

2. Operações Matemáticas
O programa solicita ao usuário dois números decimais e realiza as seguintes operações:

Soma
Subtração
Multiplicação
Divisão (com verificação para evitar divisão por zero)
Média

A seguir, o código realiza os cálculos e exibe os resultados:

double soma = numero1 + numero2;
double subtração = numero1 - numero2;
double multiplicacao = numero1 * numero2;
double divisao = numero2 != 0 ? numero1 / numero2 : double.NaN;
double media = (numero1 + numero2) / 2;

Se o segundo número for zero, a divisão será ignorada e uma mensagem de erro será exibida.

3. Contagem de Caracteres (Ignorando Espaços)
O programa solicita uma palavra ou frase e conta o número de caracteres ignorando espaços.

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

4. Validação da Placa de um Veículo
O programa solicita a placa do veículo e valida se ela segue o padrão brasileiro (até 2018):

7 caracteres alfanuméricos.
3 letras seguidas de 4 números.
A validação é feita verificando a posição dos caracteres e usando Char.IsLetter() e Char.IsDigit().

if (placa.Length == 7)
{
    if (Char.IsLetter(placa[0]) && Char.IsLetter(placa[1]) && Char.IsLetter(placa[2]))
    {
        if (Char.IsDigit(placa[3]) && Char.IsDigit(placa[4]) && Char.IsDigit(placa[5]) && Char.IsDigit(placa[6]))
        {
            Console.WriteLine("Verdadeiro");
        }
        else
        {
            Console.WriteLine("Falso");
        }
    }
    else
    {
        Console.WriteLine("Falso");
    }
}
else
{
    Console.WriteLine("Falso");
}

5. Exibição da Data e Hora
O programa exibe a data e hora atual em diferentes formatos, utilizando a cultura brasileira pt-BR para garantir a formatação correta.

Formato Completo: Inclui o dia da semana, mês por extenso, ano, hora, minutos e segundos.
Data no formato "01/03/2024".
Hora no formato de 24 horas.
Data com mês por extenso.
Exemplo de como a data é exibida:

DateTime agora = DateTime.Now;
Console.WriteLine(agora.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss", new CultureInfo("pt-BR")));
Console.WriteLine(agora.ToString("dd/MM/yyyy", new CultureInfo("pt-BR")));
Console.WriteLine(agora.ToString("HH:mm", new CultureInfo("pt-BR")));
Console.WriteLine(agora.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));

Como Executar o Programa?

Baixe o código fonte.
Abra o arquivo em um editor de C# (como o Visual Studio ou Visual Studio Code).
Compile e execute o programa.
Siga as instruções no console para interagir com o programa.

Conclusão

Este programa permite praticar diferentes conceitos de programação em C#, incluindo manipulação de entradas do usuário, cálculos matemáticos, validações de dados e formatação de datas e horas.
A interação com o usuário é simples e o código foi estruturado para ser claro e de fácil entendimento.
