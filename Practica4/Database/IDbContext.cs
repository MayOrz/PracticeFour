using System;
using System.Collections.Generic;
using System.Text;
using UPB.Practica4.Database.Models;

namespace UPB.Practica4.Database
{
    public interface IDbContext
    {
        Person AddPerson(Person person);
        Person UpdatePerson(Person personToUpdate);

        Person DeletePerson(Person personToDelete);

        List<Person> GetAll();

    }
}
