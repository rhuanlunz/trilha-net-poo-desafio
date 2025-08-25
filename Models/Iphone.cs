namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp}. Aguarde só um pouquinho ;)...");
        }
    }
}