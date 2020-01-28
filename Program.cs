using System;

namespace ejercicio_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la primer fecha con formato M/D/Y: ");
            string fecha1 = Console.ReadLine();
            Console.WriteLine("Ingrese la Segunda fecha con el mismo formato: ");
            string fecha2 = Console.ReadLine();
            DateTime date1 = DateTime.Parse(fecha1);
            DateTime date2 = DateTime.Parse(fecha2);
            Console.WriteLine(date1.ToString("D"));
            Console.WriteLine(date2.ToString("D"));
            Console.WriteLine("Calculando la diferencia de tiempo entre las dos fechas: ");
            Console.WriteLine("resultado final:");
            TimeSpan total = date2 - date1;
            int DifDias = total.Days;
            Console.WriteLine("La diferencia es de {0} dias.", DifDias);
            int semanas = DifDias / 7;
            Console.WriteLine("La diferencia es de {0} semanas.", semanas);
        }
    }

}
        




