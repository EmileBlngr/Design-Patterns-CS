using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Method
{
    public abstract class Abonnement
    {
        protected readonly IReduction reduction;
        public Abonnement(IReduction reduction = null)
        {
            this.reduction = reduction;
        }
        public abstract int GetPrice();
    }
    public class AbonnementStandard : Abonnement
    {
        public AbonnementStandard(IReduction reduction) : base(reduction)
        {
        }

        public override int GetPrice() => 10 - reduction.Reduction;
    }
    public class AbonnementPremium : Abonnement
    {
        public AbonnementPremium(IReduction reduction) : base(reduction)
        {
        }

        public override int GetPrice() => 20 - reduction.Reduction;
    }
    public interface IReduction
    {
        int Reduction { get; }
    }
    public class ReductionForte : IReduction
    {
        public int Reduction => 5;
    }
    public class ReductionFaible : IReduction
    {
        public int Reduction => 1;
    }
    public class PasDeReduction : IReduction
    {
        public int Reduction => 0;
    }
}
