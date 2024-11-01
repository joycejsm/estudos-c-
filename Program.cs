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

// Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);

//INCREMENTO

// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("Incrementando o 10:");

// // numero = numero + 1;

// numero++;


// int numeroDecrementa = 20;
// Console.WriteLine("Decrementando o 10:");
// numeroDecrementa--;
// Console.WriteLine(numeroDecrementa);

//RAIZ QUADRADA

//ESTRUTURA DE REPETIÇÃO

// int numero = 5;

// Console.WriteLine($"{numero} x 1 = { numero * 1}");


// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = { numero * contador}");
// }

// int numero = 5;
// int contador = 1;



// while (contador <= 10)
// {
//      Console.WriteLine($"{contador }° {numero} x {contador} = { numero * contador}");
//      contador++;

//      if (contador == 6)
//      {
//         break;
//      }
// }

//DO WHILE

string opcao;
bool exibirMenu = true;

while(exibirMenu)
{   
    
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente: ");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        
        case "1":

            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":

            Console.WriteLine("Buscar cliente");
            break;

        case "3":

            Console.WriteLine("Apagar cliente");
            break;

        case "4":

            Console.WriteLine("Encerrar");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}

// int soma = 0, numero = 0;

// do{
//     Console.WriteLine("Digite umnúmero: (0 para parar)");
    

//     soma +=numero;
// } while(numero !=0);

// Console.WriteLine($"Total da soma dos números digitados é : {soma}");