using System;
namespace resposta
{
    public class Dias
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> faturaDia = new Dictionary<string, double>();

            faturaDia.Add("dia1", 22174.1664);
            faturaDia.Add("dia2", 24537.6698);
            faturaDia.Add("dia3", 26139.6134);
            faturaDia.Add("dia4", 0.0);
            faturaDia.Add("dia5", 0.0);
            faturaDia.Add("dia6", 26742.6612);
            faturaDia.Add("dia7", 0.0);
            faturaDia.Add("dia8", 42889.2258);
            faturaDia.Add("dia9", 46251.174);
            faturaDia.Add("dia10", 11191.4722);
            faturaDia.Add("dia11", 0.0);
            faturaDia.Add("dia12", 0.0);
            faturaDia.Add("dia13", 3847.4823);
            faturaDia.Add("dia14", 373.7838);
            faturaDia.Add("dia15", 2659.7563);
            faturaDia.Add("dia16", 48924.2448);
            faturaDia.Add("dia17", 18419.2614);
            faturaDia.Add("dia18", 0.0);
            faturaDia.Add("dia19", 0.0);
            faturaDia.Add("dia20", 35240.1826);
            faturaDia.Add("dia21", 43829.1667);
            faturaDia.Add("dia22", 18235.6852);
            faturaDia.Add("dia23", 4355.0662);
            faturaDia.Add("dia24", 13327.1025);
            faturaDia.Add("dia25", 0.0);
            faturaDia.Add("dia26", 0.0);
            faturaDia.Add("dia27", 25681.8318);
            faturaDia.Add("dia28", 1718.1221);
            faturaDia.Add("dia29", 13220.495);
            faturaDia.Add("dia30", 8414.61);



            double[] valor = faturaDia.Values.ToArray();

            for (int j = 0; j <= valor.Length - 2; j++)
            {
                for (int i = 0; i <= valor.Length - 2; i++)
                {
                    if (valor[i] > valor[i + 1])
                    {
                        var vart = valor[i + 1];
                        valor[i + 1] = valor[i];
                        valor[i] = vart;
                    }
                }
            }

            Console.WriteLine("O menor valor faturado foi {0}", valor[0]);
            Console.WriteLine("o Maior valor faturado foi {0}", valor[29]);
        }
    }
}