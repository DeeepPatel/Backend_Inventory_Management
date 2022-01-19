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
                    return BadRequest($"{inventory.Name} inventory already exists in the database");
                
                
                _context.Inventories.Add(inventory);
                await _context.SaveChangesAsync();

                return Ok($"{inventory.Name} inventory added to the database.");

            }
            catch (Exception error)
            {
                return BadRequest(error.ToString());
            }
        }
        
        //Get Inventory by ID - Finished
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInventoryById(string id)
        {            
            try
            {
                var inventory = await _context.Inventories.FirstOrDefaultAsync(x => x.Id.Equals(new Guid(id)));

                if (inventory == null)                
                    return NotFound($"{id} - Inventory does not exist.");                

                return Ok(inventory);
            }
            catch (Exception error)
            {
                return BadRequest(error.ToString());
            }
        }

        //Get all inventories
        [HttpGet("inventories")]
        public async Task<IActionResult> GetAllInventories()
        {            
            try
            {
                return Ok(await _context.Inventories.ToArrayAsync());
            }
            catch (Exception error)
            {
                return BadRequest(error.ToString());
            }
        }

        [HttpGet("favouritecollection")]
        public async Task<IActionResult> GetAllFavourites()
        {            
            try
            {
                return Ok(await _context.FavouriteCollection.ToArrayAsync());
            }
            catch (Exception error)
            {
                return BadRequest(error.ToString());
            }
        }
        
        //update inventory
        [HttpPut("update/inventory/{id}")]
        public async Task<IActionResult> UpdateInventoryById(string id, [FromBody] Inventory updateInventory)
        {
           try
            {
                var inventory = await _context.Inventories.FirstOrDefaultAsync(x => x.Id.Equals(new Guid(id)));
                if (inventory == null)                
                    return NotFound($"{id} - Inventory does not exist.");

                inventory.Name = updateInventory.Name;
                inventory.Description = updateInventory.Description;
                inventory.Amount = updateInventory.Amount;

                await _context.SaveChangesAsync();

                return Ok("Inventory has been updated.");
            }
            catch (Exception error)
            {
                return BadRequest(error.ToString());
            }
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> AddInventoryToFavourites(string id)
        {            
            try
            {                
                Inventory inventory = await _context.Inventories.FirstOrDefaultAsync(x => x.Id.Equals(new Guid(id)));

                var favourite = new FavouriteInventoryDTO{
                    Inventory = inventory,
                    Name = inventory.Name,
                    Description = inventory.Description,
                    Amount = inventory.Amount
                };                

                
                bool favouriteExist = _context.FavouriteCollection.Include(x=>x.Inventory).Any(x => x.Inventory.Name.Equals(favourite.Inventory.Name));

                if (favouriteExist)
                    return BadRequest($"{favourite.Inventory.Name} already exists in the favourites collection.");

                _context.FavouriteCollection.Add(favourite);                
                await _context.SaveChangesAsync();

                //return Ok("Inventory moved to trash.");
                return Ok($"{favourite.Inventory.Name} added to favourites collection.");
                
            }
            catch (Exception error)
            {
                return BadRequest(error.ToString());
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemWithId(string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                    return BadRequest("the given ID is empty");

                Inventory inventory = await _context.Inventories.FirstOrDefaultAsync(x => x.Id.Equals(new Guid(id)));

                if (inventory == null)
                    return NotFound($"{id} - Inventory does not exist");

                _context.Inventories.Remove(inventory);
                await _context.SaveChangesAsync();
                return Ok($"{id} - Inventory is deleted");

            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpDelete("favourites/{id}")]
        public async Task<IActionResult> DeleteFavouriteWithId(string id)
        {
            try
            {
                FavouriteInventoryDTO favourite = await _context.FavouriteCollection.FirstOrDefaultAsync(x => x.Id.Equals(new Guid(id)));

                if (favourite == null)
                    return NotFound($"{id} - Inventory does not exist in the favourites");

                _context.FavouriteCollection.Remove(favourite);
                await _context.SaveChangesAsync();
                return Ok($"Inventory with ID {id} has been removed from favourites");
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }


    }        
    
}