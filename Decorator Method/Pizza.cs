using System;

namespace Decorator_Method
{
    public interface IComposantPizza
    {
        string Description();
        double CalculerPrix();
    }

    // Implémentation concrète de la pizza de base
    public class PizzaSimple : IComposantPizza
    {
        public string Description()
        {
            return "Pizza simple";
        }

        public double CalculerPrix()
        {
            return 5.00;
        }
    }

    // Décorateur abstrait
    public abstract class DecorateurPizza : IComposantPizza
    {
        protected IComposantPizza composantPizza;

        public DecorateurPizza(IComposantPizza composantPizza)
        {
            this.composantPizza = composantPizza;
        }

        public virtual string Description()
        {
            return composantPizza.Description();
        }

        public virtual double CalculerPrix()
        {
            return composantPizza.CalculerPrix();
        }
    }

    // Décorateurs concrets
    public class FromageDecorator : DecorateurPizza
    {
        public FromageDecorator(IComposantPizza composantPizza)
            : base(composantPizza)
        {
        }

        public override string Description()
        {
            return $"{base.Description()}, Fromage";
        }

        public override double CalculerPrix()
        {
            return base.CalculerPrix() + 1.50;
        }
    }

    public class ChampignonsDecorator : DecorateurPizza
    {
        public ChampignonsDecorator(IComposantPizza composantPizza)
            : base(composantPizza)
        {
        }

        public override string Description()
        {
            return $"{base.Description()}, Champignons";
        }

        public override double CalculerPrix()
        {
            return base.CalculerPrix() + 2.00;
        }
    }

}
