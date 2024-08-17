namespace desafio_poo_dio.Models;

public abstract class Smartphone
{
    public string Numero { get; set; }
    // TODO: Implementar as propriedades faltantes de acordo com o diagrama
    protected string Modelo { get; set; }
    protected string IMEI { get; set; }
    protected string Memoria { get; set; }

    protected Smartphone(string numero, string modelo, string imei, string memoria)
    {
        Numero = numero;
        // TODO: Passar os parâmetros do construtor para as propriedades
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;
    }

    public void Ligar()
    {
        Console.WriteLine("Ligando...");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação...");
    }

    public abstract void InstalarAplicativo(string nomeApp);
}