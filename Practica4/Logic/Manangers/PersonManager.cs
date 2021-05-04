using System;
using System.Collections.Generic;
using System.Text;
using UPB.Practica4.Database;
using UPB.Practica4.Logic.Models;

namespace UPB.Practica4.Logic.Managers
{
    public class PersonManager : IPersonManager
    {
        private readonly IDbContext _dbContext;

        public PersonManager(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Person> GetAllInfo()
        {
            List<Database.Models.Person> person = _dbContext.GetAll();
            return DTOMappers.MapPerson(person);
        }

        public Person CreatePerson(string personName)
        {
            return new Person()
            {
                Name = personName
            };
        }

        public Person UpdatePerson(Person person)
        {
            person.Name = "updated";
            return person;
        }

        public Person DeletePerson(Person person)
        {
            person.Name = "deleted";
            return person;
        }
    }
}
