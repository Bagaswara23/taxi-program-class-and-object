using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Taxi
{
    class Taxi
    {
        public string NamaPengemudi { get; set; }
        public bool DalamPerjalanan { get; set; }
        public int JumlahPenumpang { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Nama Pengemudi : {0}", NamaPengemudi);
            if(DalamPerjalanan == true)
            {
                Console.WriteLine("Dalam Perjalanan : Ya");
            }
            if(DalamPerjalanan == false)
            {
                Console.WriteLine("Dalam Perjalanan : Tidak");
            }

            Console.WriteLine("Jumlah Penumpang {0}", JumlahPenumpang);
        }

        public void MenjemputPenumpang()
        {
            Console.WriteLine("{0} Sedang menjemput penumpang", NamaPengemudi);
        }

        public void SudahSampai()
        {
            Console.WriteLine("{0} Sudah sampai tujuan penumpang", NamaPengemudi);
        }
    }
}
