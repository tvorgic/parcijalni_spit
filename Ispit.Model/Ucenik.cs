using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model
{
    public class Ucenik
    {
        public string ime;
        public string prezime;
        public DateTime datumRodjenja;
        public double prosjek;



        public   void Starost(DateTime datumRodjenja, DateTime tekuciDatum)
        {
            int starost = tekuciDatum.Year - datumRodjenja.Year ;

            Console.WriteLine(starost);


        }

        public  double Prosjek(double prosjek)
        {
            if(prosjek == 1 || prosjek <= 1.49)
            {
                Console.WriteLine("nedovoljan");
            }
            else if (prosjek == 1.50 ||  prosjek <= 2.49)
            {
                Console.WriteLine("dovoljan");
            }
            else if(prosjek == 2.50 ||  prosjek <= 3.49)
            {
                 Console.WriteLine("dobar");
            }
            else if(prosjek == 3.50 || prosjek <= 4.49) 
            {
                Console.WriteLine("vrlo dobar");
             }
            else if(prosjek == 4.50 || prosjek <= 5)
            {
                Console.WriteLine("odličan");
            }
        }
    }

    

    

}
