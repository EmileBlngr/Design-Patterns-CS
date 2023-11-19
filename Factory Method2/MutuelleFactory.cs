using Factory_Method;
using System;


namespace Factory_Method
{
    public class Patient
    {
        public string NumeroMutuelle { get; set; }
    }
    public class MutuelleFactory
    {
        public Mutuelle GetMutuelle(Patient p)
        {
            if (string.IsNullOrEmpty(p.NumeroMutuelle)) return new PasDeMutuelle();
            if (p.NumeroMutuelle.StartsWith("003")) return new EmileMutuelle();
            return new JeanMutuelle();
        }
    }
}
