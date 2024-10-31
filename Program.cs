using System.ComponentModel.DataAnnotations;
using dio_c_.Models;
using Exemplo02.Models;

//Cast - Casting (conversão de uma variável de um tipo para outro)
// int a = Convert.ToInt32("5");
// int a = Convert.ToInt32(null);
// Console.WriteLine(a);

// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);

//CASTING IMPLICITO

// int a = 5;
// double b = a;

// Console.WriteLine(b);

//ORDEM DOS OPERADORES

// double a = 4/2+2;

// Console.WriteLine(a); //4

// double a = 4/(2+2);

// Console.WriteLine(a); // 1

// int a = 10;
// int b = 20;

// int c = a + b;

// Console.WriteLine(c);

// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;
// Console.WriteLine("Valor da variavel quantiidade: " + quantidade);

// quantidade = 10;
// Console.WriteLine("Valor da variavel quantiidade: " + quantidade);

// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;


// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variavel quantiidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura);
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável: " + condicao);



// using Exemplo01.Models;


// Pessoa p = new Pessoa();

// p.Nome = "Joyce";
// p.Idade = 27;
// p.Apresentar();


//INTRO OPERADORES CONDICIONAIS

// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;


// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");


// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida!");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada!");
// }
// else
// {
//     Console.WriteLine("Desculpe não temos a quantidade informada!");
// }

//OPERADOR OR na prática

// bool ehMaiorDeIdade = false;
// bool possuiAutorizacao = true;

// if (ehMaiorDeIdade || possuiAutorizacao)
// {
//     Console.WriteLine("Acesso liberado!");
// }

// else{
//     Console.WriteLine("Acesso negado!");
// }

Calculadora calc = new Calculadora();

calc.Somar(10, 30);
calc.Subtrair(10, 50);
calc.Multiplicar(15, 45);
calc.Dividir(2, 2);
calc.Potencia(3, 3);