using Bridge_Method;
using System;
internal class Program
{
    static void Main(string[] args)
    {
        var pasDeReduc = new PasDeReduction();
        var reducFaible = new ReductionFaible();
        var reducForte = new ReductionForte();

        var abonnement = new AbonnementStandard(pasDeReduc);
        Console.WriteLine("Prix : " + abonnement.GetPrice());

        var abonnementBlackFriday = new AbonnementPremium(reducForte);
        Console.WriteLine("Prix : " + abonnementBlackFriday.GetPrice());
    }
}
