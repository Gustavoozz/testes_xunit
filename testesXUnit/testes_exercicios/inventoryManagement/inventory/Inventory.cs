using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    public class Inventory

    {
        private Dictionary<string, int> products = new Dictionary<string, int>();

        public void AddProduct(string nome, int quantidade)
        {
            if (products.ContainsKey(nome))
            {
                products[nome] += quantidade;
            }
            else
            {
                products[nome] = quantidade;
            }
        }

        public int GetAmount(string nome)
        {
            return products.TryGetValue(nome, out int quantidade) ? quantidade : 0;
        }
    }
}
