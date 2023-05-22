using System;
namespace Eiland
{
	public class InwonerFactory
	{




        public static Inwoner MaakInwoner(char soort, string naam)
        {
            Inwoner inwoner = null;

            switch (soort)
            {
                case 'V':
                    inwoner = new Vogel(naam);
                    break;
                case 'Z':
                    inwoner = new Zoogdier(naam);
                    break;
                default:
                    Console.WriteLine("Onbekend soort inwoner: " + soort);
                    break;
            }
            //string locatie = @"\data\";
            using var schrijvenInwoner = new StreamWriter(@"\data\inwoners.txt");

            schrijvenInwoner.WriteLine($"{soort} {naam}");



            return inwoner;
        }
    }
}

