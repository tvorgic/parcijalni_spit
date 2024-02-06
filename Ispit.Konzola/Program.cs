using Ispit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {





            Console.WriteLine("Unesite ime, prezime, datum rođenja(DD/MM/YYY) i prosjek prvog učenika");
            Ucenik ucenik1 = new Ucenik();
            ucenik1.ime = Console.ReadLine();
            ucenik1.prezime = Console.ReadLine();   
            ucenik1.datumRodjenja = DateTime.Parse(Console.ReadLine()); 
            ucenik1.prosjek = ucenik1.Prosjek(4.5);
            //Console.WriteLine(ucenik1.Starost(05/05/1985,2024));
            Console.WriteLine($"Student: {ucenik1}\n");
            Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

            Console.WriteLine();



            Console.WriteLine("Unesite ime, prezime, datum rođenja(DD/MM/YYY) i prosjek drugog učenika");

            Ucenik ucenik2 = new Ucenik();
            ucenik2.ime = Console.ReadLine();
            ucenik2.prezime = Console.ReadLine();
            ucenik2.datumRodjenja = DateTime.Parse(Console.ReadLine());
            ucenik2.prosjek = ucenik2.Prosjek(3.5);


            Console.WriteLine("Unesite ime, prezime, datum rođenja(DD/MM/YYY) i prosjek drugog učenika");

            Ucenik ucenik3 = new Ucenik();
            ucenik3.ime = Console.ReadLine();
            ucenik3.prezime = Console.ReadLine();
            ucenik3.datumRodjenja = DateTime.Parse(Console.ReadLine());
            ucenik3.prosjek = ucenik3.Prosjek(2.5);








        }
    }
}
