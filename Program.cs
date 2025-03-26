Console.WriteLine("Digite a palavra secreta: ");
string palavra = Console.ReadLine()!.ToLower();

Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine()!.ToLower();

bool verificacao = palavra.Contains(letra);

Console.WriteLine($"A letra {letra} existe na palavra secreta => {verificacao}");