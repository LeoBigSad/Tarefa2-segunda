using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa2_Segunda
{
    public class ManipularData
    {
        public static void ConvertDate()
        {
            DateTime now = DateTime.Now;
            string dataFormatada = $"{now.Day}@{now.Year}@{now.Month}#{now.Hour}#{now.Minute}";
            Console.WriteLine("Data Formatada: " + dataFormatada);
        }
        public static void CalculateDateDifference()
        {
            DateTime now = DateTime.Now;
            DateTime futureDate = now.AddDays(45);
            DateTime birthDate = new DateTime(2005, 1, 9);
            double differenceInSeconds = (futureDate - now).TotalSeconds;
            Console.WriteLine($"Diferença em Segundos: {differenceInSeconds}");
            double birthdayDifferenceInYears = ((now - birthDate).TotalDays)/365;
            Console.WriteLine($"Tempo em anos desde que nasci: {birthdayDifferenceInYears}");
        }
    }
}
