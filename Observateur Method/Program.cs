using System;

namespace Observateur_Method
{
    internal class Program
    {
        static void Main()
        {
            Sujet sujet = new Sujet();

            Observateur observateurA = new Observateur("A");
            Observateur observateurB = new Observateur("B");

            sujet.AjouterObservateur(observateurA);
            sujet.AjouterObservateur(observateurB);

            sujet.Etat = "État 1";  //  observateurs A et B notifiés.

            sujet.RetirerObservateur(observateurA);

            sujet.Etat = "État 2";  // observateur B  notifié.
        }
    }
}
