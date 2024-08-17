namespace desafio_poo_dio.Models;

// TODO: Herdar da classe "Smartphone"
public class Iphone : Smartphone
{
    public Iphone(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
    {
    }

    // TODO: Sobrescrever o método "InstalarAplicativo"
    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando o Aplicativo {nomeApp} no iPhone {Modelo}, que possui o Número: {Numero}, com a identificação IMEI: {IMEI} e com {Memoria}GB de memória.");
    }
}