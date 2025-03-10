using System;
using System.Collections.Generic;

namespace RefatorandoComCleanCode.Original.CodigoLimpo
{
    public class P
    {
        public List<Tuple<string, double, int>> lst = new List<Tuple<string, double, int>>();

        public void A(string n, double p, int q)
        {
            lst.Add(new Tuple<string, double, int>(n, p, q));
        }

        public void B()
        {
            double t = 0;
            foreach (var i in lst)
            {
                Console.WriteLine("Produto: " + i.Item1 + " | Preço: " + i.Item2 + " | Quantidade: " + i.Item3);
                t += i.Item2 * i.Item3;
            }
            Console.WriteLine("Total: " + t);
        }

        public void C(string n)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i].Item1 == n)
                {
                    lst.RemoveAt(i);
                    break;
                }
            }
        }
    }
}