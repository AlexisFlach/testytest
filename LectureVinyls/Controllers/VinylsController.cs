using LectureVinyls.Entities;
using LectureVinyls.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LectureVinyls.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VinylsController : ControllerBase
    {

        private VinylsRepository _repository = new VinylsRepository();

        [HttpGet]

        public IEnumerable<Vinyl> GetVinyls()
        {
            return _repository.GetVinyls();
        }

    }
}
