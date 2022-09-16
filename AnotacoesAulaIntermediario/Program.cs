using AnotacoesAulaIntermediario.Models;
using System.Globalization;

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

//concatenação de valores
string numero1 = "10";
string numero2 = "34";
string resultado = numero1 + numero2;
Console.WriteLine(resultado);

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
