using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;
using PlantSwap.Models;

namespace PlantSwap.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SwapsController : ControllerBase
  {
    private readonly PlantSwapContext _db;
    public SwapsController(PlantSwapContext db)
    {
      _db = db;
    }

    // GET: api/swaps
    [EnableCors("outside")]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Swap>>>Get(string ingredientToSwap, string cuisineType)
    {
      var query = _db.Swaps.AsQueryable();

      if (ingredientToSwap != null)
      {
        query = query.Where(entry => entry.IngredientToSwap == ingredientToSwap);
      }
      
      if (cuisineType != null)
      {
        query = query.Where(entry => entry.CuisineType == cuisineType);
      }

      return await query.ToListAsync();
    }

    // GET: api/swaps/1
    [EnableCors("outside")]
    [HttpGet("{id}")]
    public async Task<ActionResult<Swap>>GetSwap(int id)
    {
      var swap = await _db.Swaps.FindAsync(id);

      if (swap == null)
      {
        return NotFound();
      }

      return swap;
    } 

    [HttpPost]
    public async Task<ActionResult<Swap>>Post(Swap swap)
    {
      _db.Swaps.Add(swap);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetSwap), new { id = swap.SwapId }, swap);
    }

  }

}