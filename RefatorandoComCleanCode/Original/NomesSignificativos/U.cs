using System;
using System.Collections.Generic;

namespace RefatorandoComCleanCode.Original.NomesSignificativos
{
    public class U
    {
        private List<Tuple<string, int>> d = new List<Tuple<string, int>>();

        public void A(string x, int y)
        {
            d.Add(new Tuple<string, int>(x, y));
        }

        public bool B(string x)
        {
            foreach (var i in d)
            {
                if (i.Item1 == x && i.Item2 == 1)
                {
                    return true;
                }
            }
            return false;
        }

        public void C()
        {
            foreach (var i in d)
            {
                Console.WriteLine("Nome: " + i.Item1 + " | Tipo: " + i.Item2);
            }
        }
    }
}
