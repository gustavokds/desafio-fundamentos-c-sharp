namespace desafio_fundamentos;

public class Caracter
{
    public void contarCaracter()
    {
        int caracteres = 0;
        Console.WriteLine("Digite uma palavra ou frase:");
        string frase = Console.ReadLine().Trim();
        foreach (char caracter in frase)
        {
            if (caracter != ' ') caracteres++;
        }
        Console.WriteLine($"Quantidades de caracteres: {caracteres}");
    }
}
