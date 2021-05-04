

using System;
using System.Collections.Generic;
using UPB.Practica4.Database.Models;

namespace UPB.Practica4.Database
{
    public class DbContext : IDbContext
    {
        public List<Person> personTable { get; set; }

        public DbContext()
        {

            personTable = new List<Person>()
            {
                new Person() { ID= "Group-001", Name = $"Maria", AvailableSlots = 2},
                new Person() { ID= "Group-002", Name = "Lionel", AvailableSlots = 2},
                new Person() { ID= "Group-003", Name = "Juliana", AvailableSlots = 2}
        };



        }

        public Person AddPerson(Person person)
        {
            personTable.Add(person);
            return person;
        }

        public Person UpdatePerson(Person personToUpdate)
        {
            Person foundStudent = personTable.Find(person => person.ID == personToUpdate.ID);

            foundStudent.Name = personToUpdate.Name;
            return foundStudent;
        }

        public Person DeletePerson(Person personToDelete)
        {

            personTable.Remove(personToDelete);
            return personToDelete;

        }

        public List<Person> GetAll()
        {

            return personTable;
        }



    }
}

