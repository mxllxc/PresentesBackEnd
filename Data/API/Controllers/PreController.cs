using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreController : ControllerBase
    {
        PresentesRepo repo = new PresentesRepo();

        // ReadAll
        [HttpGet]
        public List<Presentes> Get()
        {
            return repo.Read();
        }

        // ReadById
        [HttpGet("{id}")]
        public Presentes Get(int id)
        {
            return repo.Read(id);
        }

        // Create
        [HttpPost]
        public void Post([FromBody] Presentes model)
        {
            repo.Create(model);
        }

        // Update
        [HttpPut("{id}")]
        public void Put([FromBody] Presentes model)
        {
            repo.Update(model);
        }

        // Delete
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repo.Delete(id);
        }
    }
}
