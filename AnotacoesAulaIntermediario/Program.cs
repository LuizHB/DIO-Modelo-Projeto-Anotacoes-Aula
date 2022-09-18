using AnotacoesAulaIntermediario.Models;
using System.Globalization;
using Newtonsoft.Json;

//atribuindo valores para a propriedade (set)
//utilizando construtor
//é possível escrever o que é o parametro antes de escrever a variavel
//neste caso nome antes de "Luiz" e sobrenome antes de "Bispo"
Pessoa p1 = new Pessoa(nome: "Luiz", sobrenome: "Bispo");

/*
p1.Nome = "Luiz";
p1.Sobrenome = "Bispo";
p1.Idade = 31;
p1.Apresentar();
*/

// instanciando novas pessoas para usar na classe curso
//utilizando construtor
Pessoa p2 = new Pessoa(nome: "Carine", sobrenome: "Demonia");

/*
p2.Nome = "Carine";
p2.Sobrenome = "Demon";
*/
Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

Console.WriteLine("-------------");

//concatenação de valores
string numero1 = "10";
string numero2 = "34";
string resultado = numero1 + numero2;
Console.WriteLine(resultado);

Console.WriteLine("-------------");

//formatando valores monetarios
//definindo local da moeda
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
decimal valorMonetario = 82.48M;
//C - significa a moeda local e formata no estilo da moeda local
Console.WriteLine($"{valorMonetario:C}");
//Criando uma localização e moeda
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
//Formatando as casas decimais no C (os n°s indicam a qt de casas decimais)
Console.WriteLine($"{valorMonetario:C1} junto de {valorMonetario:C2} e {valorMonetario:C3}");
//exibindo porcentagem - P
double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P2"));
//digitos separados por #
int numeroRX = 123456;
Console.WriteLine(numeroRX.ToString("##-##-##"));

Console.WriteLine("-------------");

//formatação de datetime
//possibilidade de modificar os termos de qualquer forma que queira
DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
//exibindo apenas data
Console.WriteLine(data.ToShortDateString());
//exibindo apenas horário
Console.WriteLine(data.ToShortTimeString());
//utilizando Parse (permite converter string para formato datetime)
DateTime data2 = DateTime.Parse("14/05/2022 19:00");
Console.WriteLine(data2);
//utilizando tryParse com teste de conversão
string dataString = "2021-03-13 16:00";
bool sucesso = DateTime.TryParseExact(dataString,
                       "yyyy-MM-dd HH:mm",
                       CultureInfo.InvariantCulture,
                       DateTimeStyles.None,
                       out DateTime data3);
if (sucesso)
{
    Console.WriteLine($"conversão com sucesso! Data: {data3}");
}
else
{
    Console.WriteLine($"{dataString} não é data válida.");
}

Console.WriteLine("-------------");

//exceção (ao ler um arquivo) - Ex: arquivo de nome diferente no código
try //método para pegar a exceção caso tenha erro
{
    string[] linhas = File.ReadAllLines("Files/file_Reading.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}//exceção especifica pode ser chamada diretamente usando a exception designada
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Erro de leitura de diretório. Diretório não encontrado. {ex.Message}");
}
//exceção genérica (tem de ser chamada após as especificas)
catch (Exception ex)//captura o erro, no exemplo retorna a mensagem de erro
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally//executar um bloco de código se catch ou try ativar ou não
{
    Console.WriteLine("Finalizou este bloco de catchs e try.");
}

//exceção por classe (chamando um throw exception)
new ExemploExcecoes().Metodo1();

Console.WriteLine("-------------");

//coleção - fila - queue
Queue<int> fila = new Queue<int>();
//adicionando termos na fila
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(5);
fila.Enqueue(7);
Console.WriteLine("Iniciando fila:");
foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine("-------------");

//opção para remover o primeiro elemento da fila
Console.WriteLine($"Removendo elemento: {fila.Dequeue()}");
foreach (int item in fila)
{
    Console.WriteLine(item);
}
Console.WriteLine("-------------");

//coleção - pilha - stack
Stack<int> pilha = new Stack<int>();
//adicionando termos na pilha
pilha.Push(2);
pilha.Push(4);
pilha.Push(5);
pilha.Push(9);
Console.WriteLine("Iniciando pilha:");
foreach (int item in pilha)
{
    Console.WriteLine(item);
}
Console.WriteLine("-------------");

//Removendo elemento do topo:
Console.WriteLine($"Removendo elemento do topo: {pilha.Pop()}");
foreach (int item in pilha)
{
    Console.WriteLine(item);
}
Console.WriteLine("-------------");

//coleção dicionario - dictionary
Dictionary<string, string> estados = new Dictionary<string, string>();
//adicionando termos no dicionario, não podem conter a mesma chave
estados.Add("BA", "Bahia");
estados.Add("SP", "São Paulo");
estados.Add("PA", "Pará");
Console.WriteLine("Iniciando dicionário:");
foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}.");
}

Console.WriteLine("-------------");

//removendo termos usando chave e alterando valores
Console.WriteLine($"Removendo elemento pela chave: {estados["SP"]}");
estados.Remove("SP");
Console.WriteLine($"Alterando elemento: {estados["BA"]}");
estados["BA"] = "Bahia - valor alterado";
foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}.");
}
Console.WriteLine("-------------");
//verificando se contem chave
string chave = "SE";
Console.WriteLine($"Verificando o elemento: {chave}");
if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não encontrado. É seguro adicionar a chave: {chave}");
}

Console.WriteLine("-------------");

//obtendo valor pela chave
string chave2 = "PA";
Console.WriteLine($"Obtendo valor da chave {chave2}: {estados["PA"]}");

Console.WriteLine("-------------");

//tuplas (melhor forma de montar)
(int, string, string, decimal) tupla = (1, "Luiz", "Bispo", 1.80M);
Console.WriteLine($"Id: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");

Console.WriteLine("-------------");

//outra forma de montar a tupla
ValueTuple<int, string, string, decimal> outroExTupla = (2, "Demon", "Saint", 1.40M);
var outraTuplaCreate = Tuple.Create(3, "Anim", "Mars", 1.48M);
Console.WriteLine($"Id: {outroExTupla.Item1}");
Console.WriteLine($"Id: {outraTuplaCreate.Item3}");

Console.WriteLine("-------------");

//tuplas no método
LeituraArquivo arquivo = new LeituraArquivo();
var (sussex, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Files/fileReading.txt");

if (sussex)
{
    Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeLinhas}.");
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}
Console.WriteLine("-------------");
//como descartar uma informação - utilizar _ numa das variaveis
var (sussexs, linhasArquivos, _) = arquivo.LerArquivo("Files/fileReading.txt");
if (sussexs)
{
    foreach (string linha in linhasArquivos)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}

Console.WriteLine("-------------");

//utilizando desconstrutor
Pessoa p5 = new Pessoa("Louis", "Maxex");
(string nome, string sobrenome) = p5;
Console.WriteLine($"{nome} {sobrenome}");

Console.WriteLine("-------------");
//IF normal para checar se número é par
int numero3 = 15;
if (numero3 % 2 == 0)
{
    Console.WriteLine($"Número {numero3} é par");
}
else
{
    Console.WriteLine($"Número {numero3} é ímpar");
}
Console.WriteLine("-------------");

//IF ternário para checar se número é par
//if ternário reduz a quantidade de código
int numero4 = 13;
bool ehPar = false;
ehPar = numero4 % 2 == 0;
Console.WriteLine($"O número {numero4} é " + (ehPar ? "par" : "ímpar"));

Console.WriteLine("-------------");

//serialização de dados (biblioteca newtonsoft.json)
//datetime em json
DateTime dataAtual = DateTime.Now;
Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
//comando que serializa o objeto (neste caso objeto v1)
string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);
//salvando texto em json
File.WriteAllText("Files/vendas.json", serializado);
Console.WriteLine(serializado);

Console.WriteLine("-------------");

//serializando uma coleção
//datetime em json => ISO 8601 padroniza o formato da data no json entre sistemas
Venda v2 = new Venda(2, "Papel", 75.00M, dataAtual);
Venda v3 = new Venda(3, "Cadeiras", 125.00M, dataAtual);
Venda v4 = new Venda(4, "Hardware", 95.00M, dataAtual);
List<Venda> listaVendas = new List<Venda>();
listaVendas.Add(v1);
listaVendas.Add(v2);
listaVendas.Add(v3);
listaVendas.Add(v4);
string serializado2 = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
File.WriteAllText("Files/listaVendas.json", serializado2);
Console.WriteLine(serializado2);

Console.WriteLine("-------------");

//Deserializar o objeto > listaVendas.json para objeto
//etapa estudar o arquivo json e mapear o conteudo em uma classe
string conteudoArquivo = File.ReadAllText("Files/listaVendas.json");
List<Deserializar> listaVenda2 = JsonConvert.DeserializeObject<List<Deserializar>>(conteudoArquivo);
foreach (Deserializar venda in listaVenda2)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}," +
    $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}.");
}

Console.WriteLine("-------------");

//tipo nulo (nullable)
bool? desejaReceberEmail = null;
if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
{ //hasvalue = se tem valor diferente de nulo (sem ele retorna exceção)
  //value é o próprio valor da variavel
    Console.WriteLine("O usuário optou por receber email");
}
else
{
    Console.WriteLine("O usuário não respondeu ou optou por não receber email");
}

Console.WriteLine("-------------");
//tipo nulo em propriedade
string vendaArquivo = File.ReadAllText("Files/vendasFinais.json");
List<Deserializar> listaVenda3 = JsonConvert.DeserializeObject<List<Deserializar>>(vendaArquivo);
foreach (Deserializar venda in listaVenda3)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}," +
    $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" +
    $" {(venda.Desconto.HasValue ? $" Desconto de: {venda.Desconto}" : "")}");
}

Console.WriteLine("-------------");
//tipo anonimo, os valores não mudam e não pode retornar em métodos
var tipoAnonimo = new { NomeA = "Luiz", SobrenomeA = "Bispo", AlturaA = 1.80M };
Console.WriteLine("Nome: " + tipoAnonimo.NomeA);
Console.WriteLine("Sobrenome: " + tipoAnonimo.SobrenomeA);
Console.WriteLine("Altura: " + tipoAnonimo.AlturaA);

Console.WriteLine("-------------");
//tipo anonimo em coleção
string colecaoArquivo = File.ReadAllText("Files/listaVendas.json");
List<Deserializar> listaVenda4 = JsonConvert.DeserializeObject<List<Deserializar>>(colecaoArquivo);

var listaAnonima = listaVenda4.Select(x => new { x.Produto, x.Preco });
foreach (var venda in listaAnonima)
{
    Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
}

Console.WriteLine("-------------");
//tipo dinamico, pode mudar o tipo por escolha 
dynamic variavelDinamica = true;
Console.WriteLine($"Tipo de variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
variavelDinamica = 4;
Console.WriteLine($"Tipo de variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
variavelDinamica = "Texto";
Console.WriteLine($"Tipo de variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

Console.WriteLine("-------------");
//classe generica / bom pra reuso de código
//na hora de chamar ele pede o tipo para prosseguir
MeuArray<int> arrayInteiro = new MeuArray<int>();
arrayInteiro.AdicionarElementoArray(20);
Console.WriteLine(arrayInteiro[0]);
MeuArray<string> arrayString = new MeuArray<string>();
arrayString.AdicionarElementoArray("texto");
Console.WriteLine(arrayString[0]);

Console.WriteLine("-------------");
//metodo de extensão aplicando classe com método
//para checar se numero é par ou não
int numero5 = 34;
int numero6 = 15;
bool par, par2 = false;
par = numero5.EsPar();
par2 = numero6.EsPar();
string mensagem = "O número " + numero5 + " é " +
                   (par ? "par" : "ímpar");
string mensagem2 = "O número " + numero6 + " é " +
(par2 ? "par" : "ímpar");
Console.WriteLine(mensagem);
Console.WriteLine(mensagem2);
