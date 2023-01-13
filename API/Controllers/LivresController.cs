using AutoMapper;
using MangaAPI.Context;
using MangaAPI.Models;
using MangaAPI.Models.DTO.Incoming;
using MangaAPI.Models.DTO.outgoing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MangaAPI.Controllers;

[ApiController]
[Route(template:"api/[controller]")]
public class LivresController : ControllerBase
{
    private readonly ApplicationDbContext _context;


    private readonly ILogger<LivresController> _logger;
    private readonly IMapper _mapper; 

    



    public LivresController(ILogger<LivresController> logger, IMapper mapper, ApplicationDbContext dbContext)
    {
        _logger = logger;
        _mapper = mapper;
        _context = dbContext;
    }

    [HttpGet("AllLivres")]
    public async Task<IActionResult> GetLivres()
    {
        List<Livre> allLivres = await _context.Livres.ToListAsync();

        var _livres = _mapper.Map<IEnumerable<LivreDto>>(allLivres);
        return Ok(allLivres);
    }


    [HttpGet("SpecificLivre")]
    public async Task<ActionResult<List<Livre>>> GetSpecificLivre(string name)
    {
        List<Livre>? livre = await _context.Livres.Where(i => i.nom == name).ToListAsync();

        var _livre = _mapper.Map<IEnumerable<LivreDto>>(livre);

        return Ok(_livre);
    }

}