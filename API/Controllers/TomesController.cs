using AutoMapper;
using MangaAPI.Context;
using MangaAPI.Models;
using MangaAPI.Models.DTO.Incoming;
using MangaAPI.Models.DTO.outgoing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MangaAPI.Controllers;

[ApiController]
[Route(template:"api/[controller]")]
public class TomesController : ControllerBase
{
    private readonly ApplicationDbContext _context;


    private readonly ILogger<TomesController> _logger;
    private readonly IMapper _mapper; 


    public TomesController(ILogger<TomesController> logger, IMapper mapper, ApplicationDbContext dbContext)
    {
        _logger = logger;
        _mapper = mapper;
        _context = dbContext;
    }


    [HttpGet("NbSpecificTome")]
    public async Task<IActionResult> GetNbSpecificTome(int id)
    {
        List<Tome> allTomes = await _context.Tomes.Where(p => p.idLivre == id).ToListAsync();
        return Ok(allTomes.Count);
    }
    

    
}