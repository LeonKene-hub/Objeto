using Objetos;

Calculadora calc = new Calculadora();


Console.WriteLine(@$"
Programa calculadora
escolha uma opcao abaixo:

1) soma
2) subtracao
3) multiplicacao
4) divisao

0)sair
");
string opcao = Console.ReadLine();

Console.WriteLine($"Digite o primeiro numero");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundoo numero");
float n2 = float.Parse(Console.ReadLine());



switch (opcao)
{
    case "1":
        Console.WriteLine(calc.Adicao(n1,n2));
        break;
    case "2":
        Console.WriteLine(calc.Subtrcao(n1, n2));
        break;
    case "3":
        Console.WriteLine(calc.Multiplicacao(n1, n2));
        break;
    case "4":
        Console.WriteLine(calc.Divisao(n1, n2));
        break;
    case "0":
        Console.WriteLine($"Obrigado por usar nosso programa");
        break;
    default:
        Console.WriteLine($"opcao errada");
        break;
}
