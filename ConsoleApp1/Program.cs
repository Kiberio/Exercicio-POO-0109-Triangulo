//Daniel Hiroshi Fugikawa - 200209
using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        Triangulo x , y;

        static void Main(string[] args)
        {
            //Declaração de variavel da classe triângulo
            Triangulo x,y;

            //Instanciar a variavel
            x = new Triangulo();
            y = new Triangulo();


            //Info para o meu usuário solicitando as medidas do triângulo x
            Console.WriteLine("Entre com as medidas do triângulo X:");

            //Dados imputados do meu usuário para as variaveis do objeto da classe triangulo
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Formula do calculo da area do triângulo x
            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            //Impressa do resultado de x
            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Info para o meu usuário solicitando as medidas do triângulo x
            Console.WriteLine("Entre com as medidas do triângulo Y:");

            //Dados imputados do meu usuário para as variaveis do objeto da classe triangulo
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Formula do calculo da area do triângulo y
            double b = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(b * (b - y.A) * (b - y.B) * (b - y.C));
            //Impressa do resultado de y
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //Comparando qual área é a maior
            if (areaX > areaY)
            {
                Console.WriteLine("Área de x é maior");
            }
            else
            {
                Console.WriteLine("Área de y é a maior");
            }
            Console.WriteLine("Tecle enter para fechar...");        //Ou Console.ReadKey();
            Console.ReadLine();

               
         


        }
    }
}
