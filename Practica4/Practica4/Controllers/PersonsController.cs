using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using UPB.Practica4.Database;
using UPB.Practica4.Database;
using UPB.Practica4.Logic.Managers;
using UPB.Practica4.Logic.Models;

namespace Practica4.Controllers
{
    [ApiController]
    [Route("/api/info")]
    public class PersonsController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IPersonManager _personManager;
        public PersonsController(IConfiguration config, UPB.Practica4.Logic.Managers.IPersonManager infoManager)
        {
            _config = config;
            _personManager = infoManager;
        }

        [HttpGet]
        public List<UPB.Practica4.Logic.Models.Person> GetInfo()
        {
            return _personManager.GetAllInfo();
        }

        [HttpPost]
        public Person CreateStudents([FromBody] string studentName)
        {
            return _personManager.CreatePerson(studentName);
        }

        [HttpPut]

        public Person UpdatePerson([FromBody] Person student)
        {
            return _personManager.UpdatePerson(student);
        }

        [HttpDelete]
        public Person DeletePerson([FromBody] Person student)
        {
            return _personManager.DeletePerson(student);
        }
    }
}
