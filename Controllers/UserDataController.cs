using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backbackend.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace backbackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDataController : ControllerBase
    {
        private static List<UserData> settings = new List<UserData>
            {
                // new UserData
                // {
                //     InputEmail = "",
                //     InputName = "",
                //     InputTel = "",
                // }
            };

        private readonly DataContext _context;

        public UserDataController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<UserData>>> Get()
        {

            return Ok(await _context.UserData.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<List<UserData>>> Add(UserData set)
        {
            try {

                _context.UserData.Add(set);
                await _context.SaveChangesAsync();
                await _context.UserData.ToListAsync();
                return Ok(await _context.UserData.ToListAsync());
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
            
            

        }
    }
}