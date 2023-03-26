using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudPessoasLista
{
    public class PrintPeopleList
    {

      
        public void PrintList2()
        {
            Console.WriteLine("List of People:");
            Console.WriteLine("----------------");
            Console.WriteLine("ID   \tName     \tPhone  \tId  \tCity  \tPais");

            for (int i = 0; i < PeopleRepository.peopleMaster.Count; i++)
            {
                People person = PeopleRepository.peopleMaster[i];
                Console.WriteLine($"{person.Id}\t{person.Name} \t{person.Phone}\t{person.Citys.Id}\t{person.Citys.Name}\t{person.Citys.Country}");
            }
        }

    }
}
