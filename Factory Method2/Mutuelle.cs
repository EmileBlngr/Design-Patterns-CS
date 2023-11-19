using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public abstract class Mutuelle
    {
        public abstract decimal GetPourcentageRemboursement();
    }

    public class EmileMutuelle : Mutuelle
    {
        public override decimal GetPourcentageRemboursement()
        => 100m;
    }
    public class JeanMutuelle : Mutuelle
    {
        public override decimal GetPourcentageRemboursement()
        => 150m;
    }
    public class PasDeMutuelle : Mutuelle
    {
        public override decimal GetPourcentageRemboursement()
        => 0m;
    }
}
