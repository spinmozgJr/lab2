using System;

namespace lab2
{
    class Program
    {
        static double[] CalculationOfCompressibilityFactor(double[] Z0, double[] Z1)
        {
            var acentricityFactor = 0.049;
            double[] result = new double[Z0.Length];
            for (int i = 0; i < Z0.Length; i++)
            {
                result[i] = Z0[i] + acentricityFactor * Z1[i];
            }

            return result;
        }

        static void Main(string[] args)
        {
            double[] Z0 = new double[] { 0.9664, 0.9599, 0.9550, 1.0101, 1.0153, 1.0284 };
            double[] Z1 = new double[] { 0.1133, 0.1476, 0.2069, 0.0828, 0.1076, 0.1529 };


            Console.WriteLine("Введите назавние вещества");
            string substance = Console.ReadLine();

            var compressibilityFactor = CalculationOfCompressibilityFactor(Z0, Z1);

            Console.WriteLine($"{substance, 12}");
            for (int i = 0; i < compressibilityFactor.Length; i++)
            {
                Console.Write(string.Format("{0:f4} ", compressibilityFactor[i]));

                if (i == 2)
                    Console.WriteLine();
            }
            Console.WriteLine("\n");

            Console.WriteLine("Реальная температура");
            const double Tc = 132.9;
            double[] Tr = { 2.0, 3.0 };
            double[] T = new double[Tr.Length];
            for (int i = 0; i < Tr.Length; i++)
            {
                T[i] = Tr[i] * Tc;
                Console.Write(string.Format("{0:f2} ", T[i]));
            }
            Console.WriteLine('\n');

            Console.WriteLine("Реальное давление");
            const double Pc = 34.5;
            double[] Pr = { 1.5, 2.0, 3.0 };
            double[] P = new double[Pr.Length];
            for (int i = 0; i < Pr.Length; i++)
            {
                P[i] = Pr[i] * Pc;
                Console.Write(string.Format("{0:f2} ", P[i]));
            }
            Console.WriteLine('\n');

            string programVersion = "1.0";
            string nowDateTime = DateTime.Now.ToString();
            Console.WriteLine($"сейчас: {nowDateTime} \nверсия программы {programVersion}"); 
        }
    }
}
