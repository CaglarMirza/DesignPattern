using System;
namespace Eiland
{
	public class InwonerFactory
	{
        private static InwonerFactory? uniekeInstantie;

        private static readonly Lazy<InwonerFactory> lazy = new Lazy<InwonerFactory>(() => new InwonerFactory());

        public static InwonerFactory GetUniekeInstantie
        {
            get
            {
                //if (instance == null)
                //    instance = new InwonerFactory();
                //return instance;
                return lazy.Value;
            }
        }




        public  Inwoner MaakInwoner(char soort, string naam)
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
            ////string locatie = @"\data\";
            //using var schrijvenInwoner = new StreamWriter(@"\data\inwoners.txt");

            //schrijvenInwoner.WriteLine($"{soort} {naam}");



            return inwoner;
        }
    }
}

