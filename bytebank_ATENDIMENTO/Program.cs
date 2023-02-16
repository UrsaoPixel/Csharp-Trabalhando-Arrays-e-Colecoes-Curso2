using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_ATENDIMENTO.bytebank.Util;
Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
new ByteBankAtendimento().AtendimentoCliente();

#region Exemplos de uso do List
//List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
//{
//    new ContaCorrente(874, "5679787-A"),
//    new ContaCorrente(874, "4456668-B"),
//    new ContaCorrente(874, "7781438-C")
//};

//List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
//{
//    new ContaCorrente(951, "5679787-E"),
//    new ContaCorrente(321, "4456668-F"),
//    new ContaCorrente(719, "7781438-G")
//};

//_listaDeContas2.AddRange(_listaDeContas3);
//_listaDeContas2.Reverse();

//for (int i = 0; i < _listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"Indice [{i}] = Conta [{_listaDeContas2[i].Conta}]");
//}

//Console.WriteLine("\n\n");

//var range = _listaDeContas3.GetRange(0, 1);
//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Índice [{i}] = Conta [{range[i].Conta}]");
//}

//Console.WriteLine("\n\n");

//_listaDeContas3.Clear();
//for (int i = 0; i < _listaDeContas3.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas3[i].Conta}]");
//}


//// Definindo a lista
//List<string> nomesDosEscolhidos = new List<string>()
//{
//    "Bruce Wayne",
//    "Carlos Vilagran",
//    "Richard Grayson",
//    "Bob Kane",
//    "Will Farrel",
//    "Lois Lane", //
//    "Loise Lane",//
//    "Loisi Cafka",//
//    "General Welling",
//    "lois Letícia", //
//    "Uxas",
//    "Diana Prince",
//    "Elisabeth Romanova",
//    "Anakin Wayne"
//};

////método que filtra a lista ignorando o `case sensitive`
//List<string> VerificaNomes(List<string> nomesDosEscolhidos, string escolhido)
//{
//    //StringComparison.OrdinalIgnoreCase
//    return nomesDosEscolhidos.Where(p => p.Contains("lois", StringComparison.OrdinalIgnoreCase)).ToList();

//}

////armazena o resultado
//var lista = VerificaNomes(nomesDosEscolhidos, "Lois");

////exibe a lista
//foreach (var item in lista)
//{
//    System.Console.WriteLine(item);
//}
//Console.ReadKey();
#endregion
#region Exemplos arrays em c#

//TestaArrayInt();
//TestaBuscaPalavra();

void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 20;
    idades[1] = 23;
    idades[2] = 51;
    idades[3] = 56;
    idades[4] = 23;

    Console.WriteLine($"Tamanho do Array {idades.Length}");

    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"Indice [{i}] = {idades[i]}");
        acumulador += idade;
    }

    int media = acumulador / idades.Length;
    Console.WriteLine($"Média de idades = {media}");
}

void TestaBuscaPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1}ª Palavra ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}");
            break;
        }
    }
}

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

//[5,9][1,8][7,1][10][6,9]
//TestaMediana(amostra);

void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para calculo da mediana está vazio ou nulo!");
    }

    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);
    //[1,8][5,9][6,9][7,1][10]

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
                                     (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
}


double[] listaDeValores = new double[6] { 1.5, 7.2, 2, 9, 12.4, 8 };

// CalcularMedia(listaDeValores);

void CalcularMedia(double[] array)
{
    double media = array.Sum() / array.Length;

    Console.WriteLine($"Total dos itens: {array.Length}");
    Console.WriteLine($"Valor da média: {media}");
}

void TestaArrayDeContasCorrentes()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adcionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adcionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adcionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adcionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adcionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adcionar(new ContaCorrente(874, "7781438-C"));
    var contaDoAndre = new ContaCorrente(956, "123456789-X");
    listaDeContas.Adcionar(contaDoAndre);
    //listaDeContas.ExibeLista();
    //Console.WriteLine("===========================");
    //listaDeContas.Remover(contaDoAndre);
    //listaDeContas.ExibeLista();

    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
        Console.WriteLine($"Índice [{i}] = {conta.Conta}/{conta.Numero_agencia}");
    }
}

//TestaArrayDeContasCorrentes();

#endregion