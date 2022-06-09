using kolokwium2.Dto;
using kolokwium2.Models;
using kolokwium2.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Controllers
{
    [Route("api")]
    [ApiController]
    public class MusiController : ControllerBase
    {
        private readonly IDbService _dbService;
        public MusiController(IDbService dbService)
        {
            _dbService = dbService;
        }
        [HttpGet]
        [Route("album/{id}")]

        public async Task<IActionResult> GetAlbumById(int albumId)
        {
          var trackList =  _dbService.getAlbumaAndSongsbyId(albumId).Result.ToList().OrderBy(e => e.Duration);
            
            
            if (trackList == null)
            {
                return BadRequest("404 nie ma takiego albumu");
            }
            return Ok(trackList);
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IActionResult> RemoveMusician(int id)
        {
            await _dbService.RemoveMusicianById(id);
            return Ok("doctor was removed");
        }

        //    [HttpPut]
        //    [Route("insert")]
        //    public async Task<IActionResult> InsertDoctor(Doctor doctor)
        //    {
        //     //   await _dbService.RemoveDoctor(id);
        //        return Ok("doctor was removed");
        //    }
        //}
    }
}
