using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudPessoasLista
{
    public class CaptureCity
    {
        public String Name { get; set; }
        public String State { get; set; }
        public String Country { get; set; }

        public void Capture()
        {
            Console.WriteLine("Digite o nome da cidade: ");
            this.Name = Console.ReadLine();

            Console.WriteLine("Digite o estado da cidade: ");
            this.State = Console.ReadLine();

            Console.WriteLine("Digite o país da cidade: ");
            this.Country = Console.ReadLine();
        }

    }
}
