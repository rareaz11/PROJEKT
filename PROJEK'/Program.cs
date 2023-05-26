using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEK_
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Random random = new Random();

           List<Sportas> sportas = new List<Sportas>();
          
                sportas.Add(new Sportas()
                {
                    ID = random.Next(1000, 10000),
                    Name = "Mario",
                    Prezime = "Maric",
                    Disciplina = "skok u dalj",
                    Dob = 28,
                    MjestoS = "Pula",
                    vrijeme =DateTime.Now,
                }
                );;
            sportas.Add(new Sportas()
            {
                ID = random.Next(1000, 10000),
                Name = "Josip",
                Prezime = "Maric",
                Disciplina = "skok u dalj",
                Dob = 17,
                MjestoS = "Pula",
                vrijeme=DateTime.Now,   
            });
            sportas.Add(new Sportas()
            {
                ID = random.Next(1000, 10000),
                Name = "Kata",
                Prezime = "Katic",
                Disciplina = "kugla",
                Dob = 21,
                MjestoS = "Pula",
                vrijeme=DateTime.UtcNow
            }
                
         );
            if (sportas.Count < 1)
            {

                Console.WriteLine("lista je prazna");
                Console.ReadLine();
                Console.WriteLine("upiste svoje ime: ");
                Console.WriteLine();
                Console.ReadLine();
                return;


            }

            else
            {
                Console.WriteLine("ime sportasa:" +sportas.Count ) ;
                Console.ReadLine();
            }

            foreach (var s in sportas)
            {
                if (sportas.Count<1)
                {
                    
                    Console.WriteLine("lista je prazna");
                    Console.ReadLine();
                    Console.WriteLine("upiste svoje ime: ");
                    Console.WriteLine();
                    Console.ReadLine();
                    return;
                 
                   
                }

                else 
                {
                    Console.WriteLine("ime sportasa : " + s.Name);
                    Console.WriteLine("ID sportasa je : " + s.ID);
                    Console.WriteLine("datum rodenja je: " +s.Dob);
                   
                }
                Console.ReadLine();
            }

            using (StreamWriter sw = new StreamWriter(("sport.txt")))
            {


                foreach (var s in sportas)
                {
                    sw.Write("\nid sportasa: " +s.ID);
                    sw.Write("\nime sportasa: " + s.Name);
                    sw.Write("\nprezime sportasa: " + s.Prezime);
                    sw.Write("\nmjesto stanovanja sportasa: " + s.MjestoS);
                    sw.Write("\ndatum rodenja sportasa: " + s.Dob);
                    sw.Write("\ndisciplina: " + s.Disciplina);
                    sw.Write("\nvrijme upisa: " +s.vrijeme);
                    sw.Write("\n------------------");
                    Console.WriteLine("\nobjavljen upis");
                    Console.WriteLine("______________________");
                    Console.WriteLine("-----------------------");
                 
                

                }
                sw.Close();
            

            }
         
            string line = "";
            using (StreamReader sr = new StreamReader("sport.txt"))
            {
                while((line =sr.ReadLine()) != null) 
                {
                    Console.WriteLine(line);

                }
                sr.Close();
            }
           

            Console.ReadLine();


            Console.WriteLine("ime sportas gdje je godina manji od 20");

            foreach (var s in sportas.Where(s => s.Dob < 20).ToList())
            {
                Console.WriteLine("postavi novu vrijednsoti discipline: ");
                s.Disciplina =Console.ReadLine();
                Console.WriteLine("postavi novo vrijeme");
                s.vrijeme = Convert.ToDateTime(Console.ReadLine());
            }

            using(StreamWriter s1 = new StreamWriter("sport.txt"))
            {
                foreach (var s in sportas)
                {
                    s1.Write("\nid sportasa: " + s.ID);
                    s1.Write("\nime sportasa: " + s.Name);
                    s1.Write("\nprezime sportasa: " + s.Prezime);
                    s1.Write("\nmjesto stanovanja sportasa: " + s.MjestoS);
                    s1.Write("\ndatum rodenja sportasa: " + s.Dob);
                    s1.Write("\ndisciplina: " + s.Disciplina);
                  
                    s1.Write("\n vrijeme " + s.vrijeme);
                    s1.Write("\n------------------");
                    Console.WriteLine("\nobjavljen upis");
                    Console.WriteLine("______________________");
                    Console.WriteLine("-----------------------");


                }
                s1.Close();

            }
            Console.ReadLine();


            string line1 = "";
            using (StreamReader sr = new StreamReader("sport.txt"))
            {
                while ((line1 = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line1);
                }
                sr.Close();
            }

            Console.ReadLine();






        }
    }
}
