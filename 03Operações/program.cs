console.Writeline("digite o valor de x:");
int x = int.Parse(console.Readline());
console.Writeline("digite o valor de y:");
int y = int.Parse(console.Readline());

int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restoDiv2 = x % 2;

Console.WriteLine("Soma: " + soma);
Console.WriteLine("Subtração: " + subtracao);
Console.WriteLine("Multiplicação: " + multiplicacao);
Console.WriteLine("Divisão: " + divisao);
Console.WriteLine("Resto: " + resto);

if (restoDiv2 == 0){
    console.WriteLine($"{é um numero par}");
}else{
        console.WriteLine($"{é um numero impar}");
}