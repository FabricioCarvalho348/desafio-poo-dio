using desafio_poo_dio.Models;

namespace desafio_poo_dio;

class Program
{
    static void Main(string[] args)
    {
    // TODO: Realizar os testes com as classes Nokia e Iphone
    Nokia celularUm = new Nokia("99 99999-9999", "G42", "48923472498237841", "128");
    Iphone celularDois = new Iphone("99 99999-9999", "15 Pro Max", "950923598252523", "512");
    
    celularUm.Ligar();
    celularDois.Ligar();
    
    celularUm.InstalarAplicativo("WhatsApp");
    celularDois.InstalarAplicativo("Twitch");
    }
}