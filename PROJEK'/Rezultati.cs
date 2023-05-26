using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEK_
{
    public class Rezultati
    {
        public string Pozicija { get; set; }

        public string Rezultat { get; set; }

        public  void DodavanjeRezultata()
        {

            Sportas sportasi = new Sportas();

            List<Rezultati> rezultati = new List<Rezultati>();
            Console.WriteLine("dodavanje rezultata");

            Console.WriteLine("upisite id sportasa");
            sportasi.ID = Convert.ToInt32(Console.ReadLine());
            
        }

    }
}
