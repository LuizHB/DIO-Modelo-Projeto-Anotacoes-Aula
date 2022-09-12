using DioFunds.Common.Models;

//operadores logicos or, and, not
//or precisa apenas uma condição verdadeira pra validar
//and precisa de todas as condições serem verdadeiras pra validar
//not usa pra negar a condição


bool maiorIdade = true;
bool autorizacao = false;

if (maiorIdade || autorizacao)
{
    Console.WriteLine("entrada liberada ||");
}
else
{
    Console.WriteLine("entrada não liberada ||");
}

if (maiorIdade && autorizacao)
{
    Console.WriteLine("Entrada liberada &&");
}
else
{
    Console.WriteLine("entrada não liberada &&");
}

if (maiorIdade && !autorizacao)
{
    Console.WriteLine("Entrada liberada !");
}
else
{
    Console.WriteLine("entrada não liberada !");
}

//operadores condicionais case/switch
/*
Console.WriteLine("digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("vogal");
        break;
    default:
        Console.WriteLine("não é vogal");
        break;
}
*/
/*
if (letra == "a" ||
letra == "e" ||
letra == "i" ||
letra == "o" ||
letra == "u")
{
    Console.WriteLine("vogal");
}
else
{
    Console.WriteLine("não é vogal");
}
*/

// operadores condicionais + varios if (if aninhado (else if))

int quantidadeEstoque = 10;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;

Console.WriteLine($"quantidade estoque: {quantidadeEstoque}");
Console.WriteLine($"quantidade compra: {quantidadeCompra}");
Console.WriteLine($"é possivel venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada");
}
else
{
    Console.WriteLine("Sem quantidade em estoque");
}

//conversão caso tenha erro
string a5 = "15-";
int b3 = 0;

int.TryParse(a5, out b3);

Console.WriteLine(b3);
Console.WriteLine("Conversão com sucesso");

//cast implicito - conversão direta implicita

int a4 = 4;
double b1 = a4;
Console.WriteLine(b1);

//converter para string
int inteiro = 64;
string a3 = inteiro.ToString();

Console.WriteLine(a3);

// cast - casting - converter tipos

int a1 = Convert.ToInt32("8");
int a2 = int.Parse("7");

Console.WriteLine(a1);
Console.WriteLine(a2);

/* operadores e combinação */
int a = 1;
int b = 3;
int c = a + b;

c += 5;
c -= 3;
c *= 2;
c /= 3;
Console.WriteLine(c);

//estrutura chamando de outra biblioteca em mesmo projeto

// variavel 
Pessoa pessoa1 = new Pessoa();
Pessoa pessoa2 = new Pessoa();

pessoa1.NomeP = "Luiz";
pessoa1.Idade = 31;
pessoa1.Apresentar();

pessoa2.NomeP = "Xin";
pessoa2.Idade = 14;
pessoa2.Apresentar();

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

DateTime dataEmCincoDias = DateTime.Now.AddDays(5);
Console.WriteLine(dataEmCincoDias);

Console.WriteLine(dataAtual.ToString("HH:mm"));


//calculadora
Calculadora calc = new Calculadora();

calc.Soma(2, 3);
calc.Divisao(15, 6);
calc.Subtracao(10, 5);
calc.Multiplicacao(2, 3);
calc.Potencia(5, 2);
calc.Coseno(30);
calc.Seno(30);
calc.Tangente(30);
calc.RaizQuadrada(18);

// incremento e decremento
int numbero = 10;
Console.WriteLine("Numero: " + numbero);
numbero++;
Console.WriteLine("Incremento: " + numbero);
int numbero2 = 10;
numbero2--;
Console.WriteLine("Decremento: " + numbero2);


//estruturas de repetição
//laço for
int nums = 10;

for (int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{nums} * {contador} = {nums * contador}");
}


//laço while
int nums2 = 8;
int contador2 = 0;
while (contador2 <= 10)
{
    Console.WriteLine($"{nums2} * {contador2} = {nums2 * contador2}");
    contador2++;
    //interrompendo o loop
    //lembrar que contador inicia em zero 
    if (contador2 == 7)
    {
        break;
    }
}


//laço do while
/*
int suma = 0, nums3 = 0;

do
{
    Console.WriteLine("Digite um numero");
    nums3 = Convert.ToInt32(Console.ReadLine());
    suma += nums3;
} while (nums3 != 0);
Console.WriteLine($"Total soma: {suma}");
*/

//menu interativo
string opcao;
bool exibirMenu = true;
while (exibirMenu)
{
    Console.WriteLine("Digite sua opção");
    Console.WriteLine("1 - cadastrar cliente");
    Console.WriteLine("2 - buscar cliente");
    Console.WriteLine("3 - apagar cliente");
    Console.WriteLine("4 - encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("1 - cadastrar cliente");
            break;
        case "2":
            Console.WriteLine("2 - buscar cliente");
            break;
        case "3":
            Console.WriteLine("3 - apagar cliente");
            break;
        case "4":
            Console.WriteLine("4 - encerrar");
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("opção invalida");
            break;
    }
}

Console.WriteLine("o programa encerrou");


//arrays

int[] arrayInteiros = new int[3];
arrayInteiros[0] = 72;
arrayInteiros[1] = 13;
arrayInteiros[2] = 58;

for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Posição: {i}, número: {arrayInteiros[i]}");
}

//array com foreach
Console.WriteLine("Usando Foreach");
foreach (int valor in arrayInteiros)
{
    Console.WriteLine(valor);
}
//para declarar a posicao precisa de contador
int contadorForeach = 0;
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Posição: {contadorForeach}, número: {valor}");
    contadorForeach++;
}

//Mudando tamanho de array
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Array tamanho novo: Posição: {i}, número: {arrayInteiros[i]}");
}

//copiando dados de um array para outro array
int[] arrayDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayDobrado, arrayInteiros.Length);
for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Array dobrado copiado: Posição: {i}, número: {arrayInteiros[i]}");
}

//lista
List<string> listaString = new List<string>();

listaString.Add("DP");
listaString.Add("SL");
listaString.Add("AK");
listaString.Add("LM");


for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"Lista: Posição: {i}, número: {listaString[i]}");
}

Console.WriteLine($"Itens na Lista: {listaString.Count}, capacidade: {listaString.Capacity}");
listaString.Add("JA");
Console.WriteLine($"Add JA na Lista: {listaString.Count}, capacidade: {listaString.Capacity}");
listaString.Remove("SL");
Console.WriteLine($"Remove SL na Lista: {listaString.Count}, capacidade: {listaString.Capacity}");












