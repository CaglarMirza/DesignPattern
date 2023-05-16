//using DesignPatterns;
////using SingletonDesignPattern;
//var singleton = Singleton.GetInstance(); 
//singleton.ZegGoeiedag(); 
//var tweedeSingleton = Singleton.GetInstance(); 
//if (singleton == tweedeSingleton) 
//Console.WriteLine("Zelfde instanties");
//tweedeSingleton.ZegGoeiedag();
//Console.ReadLine();



using System.Text;
using DesignPatterns;

var bak = Versnellingsbak.GetInstance();
bak.GaNaarVersnelling(1);
bak.GaNaarVersnelling(7);
//als test een tweede verwijzing naar dezelfde versnellingsbak
var bak2 = Versnellingsbak.GetInstance();
bak2.GaNaarVersnelling(0);
bak2.GaNaarVersnelling(-1);