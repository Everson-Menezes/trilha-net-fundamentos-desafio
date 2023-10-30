using System;
using System.Text.RegularExpressions;

public class Veiculo
{
    private string _placa;
    public string Placa
    {
        get { return _placa; }
        set
        {
            if (!IsValidPlaca(value))
            {
                throw new ArgumentException("Placa inválida. Deve seguir o padrão do Mercosul (XXX0XX00).");
            }
            _placa = value;
        }
    }

    public string Cor { get; set; }
    public int Ano { get; set; }
    public string Modelo { get; set; }
    public string Fabricante { get; set; }

    public Veiculo(string placa, string cor, int ano, string modelo, string fabricante)
    {
        Placa = placa;
        Cor = cor;
        Ano = ano;
        Modelo = modelo;
        Fabricante = fabricante;
    }

    private static bool IsValidPlaca(string placa)
    {
        // Expressão regular para validar a placa no padrão do Mercosul
        string pattern = @"^[A-Z]{3}\d{1}[A-Z0-9]{1}\d{2}$";
        return Regex.IsMatch(placa, pattern);
    }

    public override string ToString()
    {
        return $"Placa: {Placa}, Cor: {Cor}, Ano: {Ano}, Modelo: {Modelo}, Fabricante: {Fabricante}";
    }
}
