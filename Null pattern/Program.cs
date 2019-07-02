using System;
using System.Collections.Generic;
using System.Linq;

namespace Null_pattern
{
    class Program
    {
        static IList<Utilisateur> lst = new List<Utilisateur>();
        static void Main(string[] args)
        {
            GenerateData();

            Console.WriteLine(Search("Rabe").GetName());
            Console.WriteLine(Search("Bolida").GetName());
            Console.WriteLine(Search("Mbappe") is NoUser);
            Console.WriteLine(Search("Lalaina").GetName());

            Console.ReadKey();
        }

        static void GenerateData()
        {
            lst.Add(new Developpeur("Rabe"));
            lst.Add(new Developpeur("Rakoto"));
            lst.Add(new Developpeur("Bolida"));
            lst.Add(new Developpeur("Lalaina"));
        }
        static Utilisateur Search(string name)
        {
            return lst.FirstOrDefault(d => d.GetName().ToUpper() == name.ToUpper()) ?? new NoUser();
        }
    }
}
