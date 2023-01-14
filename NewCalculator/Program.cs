namespace NewCalculator;
class Program
{
    static void Main(string[] args)
    {
        
       
        Console.WriteLine("Bem-Vindo a Calculadora mais foda do C#");
        Console.WriteLine("escolha a operação desejada: soma, subtração, multiplicação ou divisão");
        string operation = Console.ReadLine();       
        string mais = ("soma");
        string menos = ("subtração");
        string vezes = ("multiplicação");
        string dividir = ("divisão");

        Console.WriteLine("digite o primeiro valor aqui: ");
        var v1 = Console.ReadLine();
        float v2 = float.Parse(v1);
        Console.WriteLine("o valor do primeiro fator é:" + v2);
        Console.WriteLine("digite o segundo valor ");
        var v3 = Console.ReadLine();
        var v4 = float.Parse(v3);
        Console.WriteLine("o Valor do segundo fator é: " + v4);
        var soman = v2 + v4;
        var menosn = v2 - v4;
        var vezesn = v2 * v4;
        var divisn = v2 / v4;
        
      
        if (operation == mais)
            {
                Console.WriteLine("o resultado da operação é:" + soman);
            }
        if (operation == menos)
            {
                Console.WriteLine("o resultado da operação é: " + menosn);
            }
        if (operation == vezes)
            {
                Console.WriteLine("o resultado da operação é: " + vezesn);
            }
        if (operation == dividir)
            {
                Console.WriteLine("o resultado da operação é: " + divisn);
            }
        



    }
}
