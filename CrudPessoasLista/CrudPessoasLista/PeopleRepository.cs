using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudPessoasLista
{
    public class PeopleRepository
    {

        public static List<People> peopleMaster = new List<People>();
        public void AddPeople(People people)
        {
            peopleMaster.Add(people);
        }


        public List<People> GetPeopleList()
        {
            return peopleMaster;
        }

        public void RemoveCity(int idCity)
        {
            foreach (var item in peopleMaster)
            {
                if (item.Citys.Id == idCity)
                {
                    item.Citys = new City();
                }
            }
        }


        public void updatePeople(int peopleID, People updatePerson)
        {

            People personToUpdate = peopleMaster.FirstOrDefault(p => p.Id == peopleID);

            if (personToUpdate != null)
            {
                personToUpdate.Name = updatePerson.Name;
                personToUpdate.Phone = updatePerson.Phone;
            }


        }

        public bool PeopleExists(int personId)
        {
            return peopleMaster.Any(p => p.Id == personId);
        }

        public void DeletePeople(int personId)
        {
            People peopleToRemove = peopleMaster.FirstOrDefault(people => people.Id == personId);
            if (peopleToRemove != null)
            {

                peopleMaster.Remove(peopleToRemove);
            }

        }


    }
}
