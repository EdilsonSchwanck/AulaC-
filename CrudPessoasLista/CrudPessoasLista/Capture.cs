using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudPessoasLista
{
    public class Capture
    {
        public string Name { get; set; }
        public string Telefone { get; set; }

        public void Captura()
        {

            Console.WriteLine("Digite um Nome");
            this.Name = Console.ReadLine();

            Console.WriteLine("Digite um telefone");
            this.Telefone = Console.ReadLine();
        }

    }
}
