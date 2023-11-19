using Factory_Method;
using System;
internal class Program
{
    static void Main(string[] args)
    {
        Patient a = new Patient();
        Patient b = new Patient { NumeroMutuelle = "003843746813" };
        Patient c = new Patient { NumeroMutuelle = "001392392382" };
        var factory = new MutuelleFactory();
        Console.WriteLine("Patient a = " + factory.GetMutuelle(a).GetPourcentageRemboursement());
        Console.WriteLine("Patient b = " + factory.GetMutuelle(b).GetPourcentageRemboursement());
        Console.WriteLine("Patient c = " + factory.GetMutuelle(c).GetPourcentageRemboursement());
    }
}