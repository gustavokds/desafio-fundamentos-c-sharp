using System.Globalization;

namespace desafio_fundamentos;

public class Data
{

    public void exibirDataFormatos()
    {
        Console.WriteLine("Digite uma data.");
        var dataDigitada = Console.ReadLine().Trim();
        DateTime data;
        if (DateTime.TryParse(dataDigitada, out data))
        {
            Console.WriteLine($"Formato Completo: {data}");
            Console.WriteLine($"Apenas a data: {data.ToShortDateString()}");
            Console.WriteLine($"Apenas a hora: {data.ToString("T", new CultureInfo("pt-BR"))}");
            Console.WriteLine($"Data com o mês por extenso: {data.ToString("dd/MMMM/yyyy", new CultureInfo("pt-BR"))}");
        }
        else Console.WriteLine("Não é uma data válida. Use formato de data do seu dispositivo");

    }
    
}
