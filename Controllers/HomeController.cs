using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Deep_Patel_Backend_Challenge.Models;
using Deep_Patel_Backend_Challenge.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Deep_Patel_Backend_Challenge.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            this._context = context;
        }

        //Add Inventory - Finished
        [HttpPost]
        public async Task<IActionResult> AddInventory([FromBody] Inventory inventory)
        {            
            try
            {                
                bool inventoryExist = _context.Inventories.Any(x => x.Name.Equals(inventory.Name));

                if (inventoryExist)
                {
                    return BadRequest($"{inventory.Name} inventory already exists in the database");
                }
                
                _context.Inventories.Add(inventory);
                await _context.SaveChangesAsync();

                return Ok($"{inventory.Name} inventory added to the database.");

            }
            catch (Exception error)
            {
                return BadRequest(error.ToString());
            }
        }
        
    }
}