
class Calculadora
{

        /* Console.WriteLine("Digite o tipo de operação que deseja realizar");
        Console.WriteLine("[A] - Adição");
        Console.WriteLine("[S] - Subtração");
        Console.WriteLine("[M] - Multiplicação");
        Console.WriteLine("[D] - Divisão");

        char dec = char.Parse(Console.ReadLine() ?? "");
        dec = char.ToLower(dec);

        Console.Write("Digite o primeiro número: ");
        double NumberOne = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Digite o segundo número: ");
        double NumberTwo = double.Parse(Console.ReadLine() ?? "0");

        Calculadora Calc = new Calculadora(NumberOne, NumberTwo);
            
            switch (dec)
        {
            case 'a':
                Console.WriteLine($"A soma de {NumberOne} + {NumberTwo} é: {Calc.Adicao()}");
                break;
            case 's':
                Console.WriteLine($"A subtração de {NumberOne} - {NumberTwo} é: {Calc.Subtracao()}");
                break;
            case 'm':
                Console.WriteLine($"A multiplicação de {NumberOne} x {NumberTwo} é: {Calc.Multiplicacao()}");
                break;
            case 'd':
                Console.WriteLine($"A divisão de {NumberOne} / {NumberTwo} é: {Calc.Divisao()}");
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }*/

    public double number1 { get; set; }
    public double number2 { get; set; }
    public Calculadora(double number1, double number2)
    {
        this.number1 = number1;
        this.number2 = number2;
    }

    public double Adicao() => number1 + number2;
    
    public double Subtracao() => number1 - number2;
    
    public double Multiplicacao() => number1 * number2;
    
    public double Divisao()
    {
        if (number2 == 0)
        {
            Console.WriteLine("Não é possível dividir por zero.");
            return double.NaN;
        }
        return number1 / number2;
    }
}