using CrudPessoasLista;

InterfaceOptions interfaceOptions = new InterfaceOptions();
interfaceOptions.interfaceUser();


int _operator = Convert.ToInt32(Console.ReadLine());
while (_operator != 0)
{
    switch (_operator)
    {
        case 0:
            Environment.Exit(0);
        break;

        case 1:
            CreatePeople createPeople = new CreatePeople();
            createPeople.Create();

        break;

        case 2:
            PrintPeopleList printPeopleList = new PrintPeopleList();
            printPeopleList.PrintList2();

        break;

        case 3:
            UpdatePeople updatePeople = new UpdatePeople();
            updatePeople.Update();
            break;

        case 4:
            Console.WriteLine("Digite um Id da pessoa para excluir");
            var id = Convert.ToInt32(Console.ReadLine());
            PeopleRepository repsitory = new PeopleRepository();
            repsitory.DeletePeople(id);
        break;

        case 5:
            new UpdateCity().Update();
        break;
        case 6:
            Console.WriteLine("Digite um Id da pessoa para excluir a cidade");
            var idCity = Convert.ToInt32(Console.ReadLine());
            CityRepository repositoryCity = new CityRepository();
            repositoryCity.DeleteCity(idCity);
        break;

    }

    interfaceOptions.interfaceUser();


    _operator = Convert.ToInt32(Console.ReadLine());
}

