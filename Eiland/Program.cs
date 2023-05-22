using System.Reflection.PortableExecutable;
using System.IO;
using Eiland;





string[] regels = File.ReadAllLines(@"\inwoners.rtf");

//var eiland  = new EiLand 


foreach (string regel in regels)
{
    char soort = regel[0];
    string naam = regel.Substring(1);

    Inwoner inwoner = InwonerFactory.MaakInwoner(soort, naam);

    if (inwoner != null)
    {
        EiLand.GetuniekeInstantie.ToevoegInwoner(inwoner);


    }
}

// Vulkaanuitbarsting
EiLand.GetuniekeInstantie.Vulkaanuitbarsting();

Console.ReadLine();