// 1 - Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato 
//: Aluno tem anos e nota usando a concatenação e a interpolação de strings.

string nome = "Paulo";
int idade = 17;
double nota = 7.5;
Console.WriteLine($"Aluno {nome} tem {idade} anos e sua nota é {nota}.");
Console.ReadLine();

// 2 - Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.

Console.WriteLine($"Aluno {nome} \ntem {idade} anos \nsua nota é {nota}.");
Console.ReadLine();
/* 
3 - Para qual tipo de dados você pode converter um float implicitamente ?
( ) int
( ) double
( ) long
(X) decimal 
*/

/*
4 - Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
( ) int para long
( ) double para long
( ) double para float
(x) decimal para float
( ) long para int
( ) double para decimal
*/

// 5 - Escreva um programa que recebe 3 letras via teclado e as c usando
//a concatenação e também a interpolação de strings

Console.WriteLine($"Insira três letras:");

Console.Write("Letra 1: ");
char letra1 = Console.ReadKey().KeyChar;
Console.WriteLine();

Console.Write("Letra 2: ");
char letra2 = Console.ReadKey().KeyChar;
Console.WriteLine();

Console.Write("Letra 3: ");
char letra3 = Console.ReadKey().KeyChar;
Console.WriteLine();

Console.WriteLine("Usando concatenação:");
string ordemReversaConcat = "" + letra3 + letra2 + letra1;
Console.WriteLine(ordemReversaConcat);

Console.WriteLine("Usando interpolação:");
string ordemReversaInterp = $"{letra3}{letra2}{letra1}";
Console.WriteLine(ordemReversaInterp);
Console.ReadLine();
    
/*
 6 - Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
(F) long resultado = 1.32;
(V)) var nome = “Maria”;
(F) string resultado = 100.ToString();
(V) A sequência de escape \n inclui uma nova linha
(F) float f = 5.45;
(F) decimal valor = (decimal) 10.99f;
(F) var status = null;
(V) object o = 12.45m;
(F) string titulo = true.ToString();
(V) A sequencia \t inclui uma tabulação vertical
*/

// 7 - Escreva um programa para receber dois valores via teclado do tipo double e a seguir
//realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
//exibindo o resultado:


Console.WriteLine("Informe o valor 1: ");
double valor1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o valor 2: ");
double valor2 = Convert.ToDouble(Console.ReadLine());

double soma = valor1 + valor2;
double subtracao = valor1 - valor2;
double multiplicacao = valor1 * valor2;
double exponenciacao = Math.Pow(valor1, valor2);
double divisao = valor1 / valor2;
double modulo = valor1 % valor2;

Console.WriteLine("Soma: " + soma.ToString());
Console.WriteLine("Subtração: " + subtracao.ToString());
Console.WriteLine("Multiplicação: " + multiplicacao.ToString());
Console.WriteLine("Exponenciação: " + exponenciacao.ToString());
Console.WriteLine("Divisão: " + divisao.ToString());
Console.WriteLine("Módulo: " + modulo.ToString());
Console.ReadLine();

//Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
//Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
//então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
//inválido’: (use o operador condicional ternário)
 
Console.WriteLine("Digite o nome:");
string name = Console.ReadLine();
Console.WriteLine("Digite a senha:");
int senha = Convert.ToInt32(Console.ReadLine());

string mensagem = (name == "admin" || name == "maria") && senha == 123 ? "Login feito com sucesso" : "Login inválido";

Console.WriteLine(mensagem);
Console.ReadLine();
//Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
//console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)

Console.WriteLine("Digite o um valor x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o um valor y:");
int y = Convert.ToInt32(Console.ReadLine());

string xParOuNao = x % 2 == 0 ? "par" : "ímpar";
Console.WriteLine($"O número {x} é {xParOuNao}.");

string yParOuNao = y % 2 == 0 ? "par" : "ímpar";
Console.WriteLine($"O número {y} é {yParOuNao}.");
Console.ReadLine();

