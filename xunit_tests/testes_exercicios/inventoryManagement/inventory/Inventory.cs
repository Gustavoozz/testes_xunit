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
            // O método ContainsKey verifica se a chave nome já existe no dicionário products.
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
            // TryGetValue é um método do dicionário que tenta obter o valor associado à chave nome.
            return products.TryGetValue(nome, out int quantidade) ? quantidade : 0;
        }
    }
}
