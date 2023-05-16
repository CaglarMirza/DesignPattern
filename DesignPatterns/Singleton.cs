using System;
namespace DesignPatterns
{
    public class Versnellingsbak
    {
        private static Versnellingsbak? _uniekeInstantie;
        private int versnelling;
        private Versnellingsbak() { }
        public static Versnellingsbak GetInstance()
        {
            if (_uniekeInstantie == null)
            {
                _uniekeInstantie = new Versnellingsbak();
            }
            return _uniekeInstantie;
        }
        public void GaNaarVersnelling(int versnelling)
        {
            if ((versnelling < -1) || (versnelling > 5))
                Console.WriteLine("Verkeerde versnelling : {0}", versnelling);
            else
            {
                if (versnelling == -1)
                    Console.WriteLine("Van {0}e versnelling in achteruit",
                        this.versnelling);
                else
                    this.versnelling = versnelling;
            }
        }
    }
}

