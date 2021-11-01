using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

//route
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using apiweb.Db; //ApplicationDbContext.cs

using apiweb.DTOs;
using apiweb.Entidades;
using AutoMapper;

namespace apiweb.Controllers
{
    [Route("api/user")]
    //devolver al usuario un error con los motivos
    [ApiController]
    //: ControllerBase , indica que puedo usar un return 404
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public UserController(
            ILogger<UserController> logger,
            ApplicationDbContext context,
            IMapper mapper
            )
        {
            this.logger = logger;
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]  //acción de respuesta
        public async Task<ActionResult<List<UserDTO>>> Get()
        {
            //mapeo automatico de la entidad con automapper
            var user = await context.User.ToListAsync();
            return mapper.Map<List<UserDTO>>(user);
        }

        [HttpPost]  //acción de respuesta
        public async Task<ActionResult> Post([FromBody] UserDTO userDTO)
        {
            var user = mapper.Map<User>(userDTO);
            context.Add(user);
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var user = await context.User.FirstOrDefaultAsync(x => x.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            context.Remove(user);
            await context.SaveChangesAsync();
            return NoContent();
        }


    }
}
