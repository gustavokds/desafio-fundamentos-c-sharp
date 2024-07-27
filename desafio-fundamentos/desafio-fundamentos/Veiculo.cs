using System.Text.RegularExpressions;

namespace desafio_fundamentos;

public class Veiculo
{
    public string placa { get; set; }

    public void verificarPlaca()
    {
        Console.WriteLine("Digite a placa do veículo");
        Console.WriteLine(validarPlaca());
    }

    private string validarPlaca()
    {
        placa = Console.ReadLine().Trim();

        if (placa.Length == 7 && placa != null)
        {
            var placaLetras = placa.Substring(0, 3);
            var placaNumeros = placa.Substring(3, 4);
            if ((Regex.IsMatch(placaLetras, "^[a-zA-Z]+$")) && (Regex.IsMatch(placaNumeros, "^[0-9]+$")))
                return "Valido";
            else
                return "Falso";
        }
        else
            return "Falso";
    }
}
