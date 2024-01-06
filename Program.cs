using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste com Nokia
            Console.WriteLine("Teste com Nokia:");
            Nokia nokia = new Nokia("123456789", "Nokia123", "IMEI123", 64);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");
            Console.WriteLine();

            // Teste com iPhone
            Console.WriteLine("Teste com iPhone:");
            Iphone iphone = new Iphone("987654321", "iPhoneX", "IMEI987", 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
            Console.WriteLine();

            Console.ReadLine();  // Manter o console aberto para visualizar os resultados
        }
    }
}
