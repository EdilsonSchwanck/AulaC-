using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudPessoasLista
{
    public class UpdatePeople
    {
        public void Update()
        {
            PeopleRepository repositoryExists = new PeopleRepository();

            Console.WriteLine("Digite um Id da pessoa para editar");
            var update1 = Convert.ToInt32(Console.ReadLine());

            bool idExists = repositoryExists.PeopleExists(update1);

            if (idExists)
            {
                var people = repositoryExists
                                   .GetPeopleList()
                                   .FirstOrDefault(x => x.Id == update1);


                Console.WriteLine("Digite um novo nome");
                people.Name = Console.ReadLine();
                Console.WriteLine("Digite um novo telefone");
                people.Phone = Console.ReadLine();

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("A pessoa não foi encontrada na lista");
                Console.WriteLine("------------------------------------");
                Console.WriteLine();
            }
        }


    }
}
