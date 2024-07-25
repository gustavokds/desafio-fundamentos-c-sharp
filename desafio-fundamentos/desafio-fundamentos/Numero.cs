using System.ComponentModel;

namespace desafio_fundamentos;

public class Numero
{
    public double numero1 {  get; set; }
    public double numero2 { get; set; }


    public void operacoesNumeros()
    {
        //Nao tem validacao caso o usuario digite algo diferente de um numero
        Console.WriteLine("Digite o primeiro numero:");
        numero1 = loopingDado("Digite o primeiro numero válido");
        Console.WriteLine("Digite o segundo numero:");
        numero2 = loopingDado("Digite o primeiro numero válido");
        Console.WriteLine("Operações dos numeros:");
        Console.WriteLine($"SOMA = {numero1 + numero2}");
        Console.WriteLine($"SUBTRAÇÃO = {numero1 - numero2}");
        Console.WriteLine($"MULTIPLICAÇÃO = {numero1 * numero2}");
        Console.WriteLine($"DIVISÃO = {numero1 / numero2}");
        Console.WriteLine($"MEDIA= {(numero1 + numero2) / 2}");
    }
    private double loopingDado(string msgDadoInvalido)
    {
        bool msgExibida = false;
        do
        {
            double numero = Convert.ToDouble(Console.ReadLine());
            if (numero != null)
            {
                msgExibida = true;
                return numero;
            }
            else Console.WriteLine(msgDadoInvalido);
        } while (!msgExibida);

        return 0.0f;
    }
}
