using System;
using System.Collections.Generic;
using System.Text;
using UPB.Practica4.Logic.Models;

namespace UPB.Practica4.Logic.Managers
{
    public interface IPersonManager
    {
        List<Person> GetAllInfo();

        Person CreatePerson(string personName);

        Person UpdatePerson(Person person);

        Person DeletePerson(Person person);

    }
}
