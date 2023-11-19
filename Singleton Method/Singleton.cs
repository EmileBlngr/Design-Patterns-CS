using System;


namespace Singleton_Method
{
    public class Singleton
    {
        private static Singleton instance;
        private static readonly object verrou = new object();
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (verrou) // Un seul theread à la fois ici
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }

        // Un constructeur privé pour empêcher la création directe d'instances
        private Singleton()
        {
            // Initialisation de l'instance unique
        }
        public void AfficherMessage()
        {
            Console.WriteLine("Instance Singleton.");
        }
    }
}
