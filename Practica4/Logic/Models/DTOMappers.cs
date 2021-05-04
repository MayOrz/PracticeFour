using System;
using System.Collections.Generic;
using System.Text;
using UPB.Practica4.Database.Models;

namespace UPB.Practica4.Logic.Models
{
    class DTOMappers
    {
        public static List<Person> MapPerson(List<Database.Models.Person> persons)
        {
            List<Person> mappedPersons = new List<Person>();

            foreach (Database.Models.Person person in persons)
            {
                mappedPersons.Add(new Person()
                {
                    ID = person.ID,
                    Name = person.Name
                });

            }

            return mappedPersons;
        }

    }
}
