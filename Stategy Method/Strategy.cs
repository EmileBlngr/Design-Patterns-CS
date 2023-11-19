using System;

namespace Stategy_Method
{
    public interface ITriStrategy
    {
        void Trier(int[] tableau);
    }

    //différentes stratégies de tri
    public class TriParSelection : ITriStrategy
    {
        public void Trier(int[] tableau)
        {
            Console.WriteLine("Tri par sélection réalisé");
        }
    }

    public class TriABulles : ITriStrategy
    {
        public void Trier(int[] tableau)
        {
            Console.WriteLine("Tri à bulles réalisé");
        }
    }

    //utilise une stratégie de tri
    public class Tri
    {
        private ITriStrategy strategie;

        public Tri(ITriStrategy strategie)
        {
            this.strategie = strategie;
        }

        public void EffectuerTri(int[] tableau)
        {
            strategie.Trier(tableau);
        }
    }

}
