using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observateur_Method
{
    public class Sujet
    {
        public string etat;
        private List<IObservateur> observateurs = new List<IObservateur>();

        public string Etat
        {
            get { return etat; }
            set
            {
                etat = value;
                NotifierObservateurs();
            }
        }
        public void AjouterObservateur(IObservateur observateur)
        {
            observateurs.Add(observateur);
        }

        public void RetirerObservateur(IObservateur observateur)
        {
            observateurs.Remove(observateur);
        }
        public void NotifierObservateurs()
        {
            foreach (var observateur in observateurs)
            {
                observateur.MettreAJour(etat);
            }
        }
    }
}
