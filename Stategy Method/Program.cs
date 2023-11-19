using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stategy_Method
{
    class Program
    {
        static void Main()
        {
            int[] tableau = { 5, 2, 8, 3, 1 };

            // Utilisation de la stratégie de tri par sélection
            Tri triParSelection = new Tri(new TriParSelection());
            triParSelection.EffectuerTri(tableau);

            // Utilisation de la stratégie de tri à bulles
            Tri triABulles = new Tri(new TriABulles());
            triABulles.EffectuerTri(tableau);
        }
    }
}
