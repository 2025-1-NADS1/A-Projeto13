using System;

class CasaInteligente
{
    static void Main()
    {
        string[] comodos = { "Quarto 1", "Quarto 2", "Sala", "Cozinha", "Piscina" };
        int totalComodos = comodos.Length;

        // Matriz: cada linha = um cômodo, colunas: [0]=movimento, [1]=temperatura, [2]=umidade
        double[,] sensores = new double[totalComodos, 3];

        Console.WriteLine("=== Sistema da Casa Inteligente ===");

        // Entrada dos dados
        for (int i = 0; i < totalComodos; i++)
        {
            Console.WriteLine($"\n{comodos[i]}:");

            Console.Write(" - Movimento (0 = não, 1 = sim): ");
            sensores[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write(" - Temperatura (°C): ");
            sensores[i, 1] = Convert.ToDouble(Console.ReadLine());

            Console.Write(" - Umidade (%): ");
            sensores[i, 2] = Convert.ToDouble(Console.ReadLine());
        }

        // Análise dos dados
        Console.WriteLine("\n=== Relatório dos Sensores ===");

        for (int i = 0; i < totalComodos; i++)
        {
            Console.WriteLine($"\n{comodos[i]}:");

            if (sensores[i, 0] == 1)
                Console.WriteLine(" - Presença detectada.");
            else
                Console.WriteLine(" - Nenhuma presença.");

            double temperatura = sensores[i, 1];
            double umidade = sensores[i, 2];

            Console.WriteLine($" - Temperatura: {temperatura} °C");
            Console.WriteLine($" - Umidade: {umidade} %");

            // Decisão com base em temperatura
            if (temperatura > 30)
                Console.WriteLine(" - Alerta: Temperatura elevada!");
            else if (temperatura < 15)
                Console.WriteLine(" - Alerta: Temperatura muito baixa!");
            else
                Console.WriteLine(" - Temperatura estável.");

            // Decisão com base em umidade
            if (umidade > 70)
                Console.WriteLine(" - Aviso: Alta umidade.");
            else if (umidade < 30)
                Console.WriteLine(" - Aviso: Umidade baixa.");
            else
                Console.WriteLine(" - Umidade estável.");
        }
    }
}