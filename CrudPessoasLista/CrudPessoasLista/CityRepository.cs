using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudPessoasLista
{
        public class CityRepository
        {
        public static List<City> cityRepository = new List<City>();
        public void AddCity(City city)
        {
            cityRepository.Add(city);
        }

        public List<City> GetCityList()
        {
            return cityRepository;
        }

        public void UpdateCity(int cityId, City city)
        {
            City cityToUpdate = cityRepository.FirstOrDefault(c => c.Id == cityId);

            if (cityToUpdate != null)
            {
                cityToUpdate.Name = city.Name;
                cityToUpdate.State = city.State;
                cityToUpdate.Country = city.Country;
            }
        }

        public bool CityExists(int cityId)
        {
            return cityRepository.Any(c => c.Id == cityId);
        }

        public void DeleteCity(int cityId)
        {
            City cityToRemove = cityRepository.FirstOrDefault(city => city.Id == cityId);

            if (cityToRemove != null)
            {
                new PeopleRepository().RemoveCity(cityId);
                cityRepository.Remove(cityToRemove);
            }
        }
    }
}
