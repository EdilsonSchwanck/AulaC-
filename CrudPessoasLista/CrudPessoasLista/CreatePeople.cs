using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudPessoasLista
{
    public class CreatePeople
    {
        public void Create()
        {
            Capture capture = new Capture();
            capture.Captura();

            CaptureCity captureCity = new CaptureCity();
            captureCity.Capture();
            City city = new City(captureCity.Name, captureCity.State, captureCity.Country);
            new CityRepository().AddCity(city);

            People people = new People(capture.Name, capture.Telefone, city);

            PeopleRepository repository = new PeopleRepository();
            repository.AddPeople(people);
        }
    }
}
