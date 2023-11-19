using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observateur_Method
{
    public interface IObservateur
    {
        void MettreAJour(string nouvelEtat);
    }
    public class Observateur : IObservateur
    {
        private string nom;

        public Observateur(string nom)
        {
            this.nom = nom;
        }

        public void MettreAJour(string nouvelEtat)
        {
            Console.WriteLine($"Observateur {nom} : nouvel état - {nouvelEtat}");
        }
    }
}
