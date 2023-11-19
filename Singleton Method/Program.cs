using System;

namespace Singleton_Method
{
    class Program
    {
        static void Main()
        {
            Singleton instance = Singleton.Instance;
            instance.AfficherMessage();
            //Singleton autreInstance = new Singleton(); //Erreur si on rajoute une 2eme instance
        }
    }
}
