using System;
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        public override void InstalarAplicativo(string nomeApp, string modelo)
        {
            Console.WriteLine($"Instalando o Aplicativo {nomeApp} no {modelo} ");
        }

    }
}