using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudPessoasLista
{
    public class City
    {

        private static int generateNumber = 1;
        public int? Id { get; private set; }
        public String Name { get; set; }
        public String State { get; set; }
        public String Country { get; set; }

        public City()
        {
        }

        public City(string name, string state, string country)
        {
            this.Id = generateNumber;
            generateNumber++;

            this.Name = name;
            this.State = state;
            this.Country = country;
        }



    }
}
