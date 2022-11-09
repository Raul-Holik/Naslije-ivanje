using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naslijeđivanje
{
    class Cat
    {
        bool opasna;

        public bool Opasna { get => opasna; set => opasna = value; }

        public virtual void Opasnost()
        {
            this.opasna = false;
        }
        public override string ToString()
        {
            return "Macka - opasnost = " + this.opasna;
        }
    }

    class Gepard : Cat
    {
        public override void Opasnost()
        {
            this.Opasna = true;
        }
        public override string ToString()
        {
            return "Gepard - opasnost = " + this.Opasna;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Gepard g = new Gepard();
            g.Opasnost();
            Console.WriteLine(g.ToString());

            Cat m = new Cat();
            m.Opasnost();
            Console.WriteLine(m.ToString());

            Console.ReadKey();
        }
    }
}
