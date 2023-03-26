using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudPessoasLista
{
    public class People
    {
        private static int generateNumber = 1;

        public int Id { get; private set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public City Citys { get; set; }

        public People(string name, string phone, City citys)
        {

            this.Id = generateNumber;
            generateNumber++;

            this.Name = name;
            this.Phone = phone;
            this.Citys = citys;
        }


    }
}
