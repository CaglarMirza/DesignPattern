using System.Reflection.PortableExecutable;
using System.IO;
using Eiland;



EiLand eiland = new EiLand();
Vulkaan vulkaan = new Vulkaan();
vulkaan.BarstUit += eiland.Vulkaanuitbarsting;


string[] regels = File.ReadAllLines("inwoners.rtf");



foreach (string regel in regels)
{
    char soort = regel[0];
    string naam = regel.Substring(1);

    Inwoner inwoner = InwonerFactory.GetUniekeInstantie.MaakInwoner(soort, naam);


    if (inwoner != null)
    {
        EiLand.GetuniekeInstantie.ToevoegInwoner(inwoner);
        EiLand.GetuniekeInstantie.Attach(inwoner);


    }
}

// Vulkaanuitbarsting
vulkaan.StartUitbarsting();

    Console.ReadLine();
