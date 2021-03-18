using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.NamaPengemudi = "Gepeng";
            taxi.DalamPerjalanan = true;
            taxi.JumlahPenumpang = 10;

            taxi.TaxiInfo();
            taxi.MenjemputPenumpang();
            taxi.SudahSampai();

            Console.ReadKey();
        }
    }
}
