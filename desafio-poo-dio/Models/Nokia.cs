namespace desafio_poo_dio.Models;

// TODO: Herdar da classe "Smartphone"
public class Nokia : Smartphone
{
    // TODO: Sobrescrever o método "InstalarAplicativo"
    public Nokia(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
    {
        
    }

    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando o Aplicativo {nomeApp} no Nokia {Modelo}, que possui o Número: {Numero}, com a identificação IMEI: {IMEI} e com {Memoria}GB de memória.");
    }
}