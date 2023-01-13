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
public class CollectionsController : ControllerBase
{
    private readonly ApplicationDbContext _context;


    private readonly ILogger<CollectionsController> _logger;
    private readonly IMapper _mapper; 

    



    public CollectionsController(ILogger<CollectionsController> logger, IMapper mapper, ApplicationDbContext dbContext)
    {
        _logger = logger;
        _mapper = mapper;
        _context = dbContext;
    }

    [HttpGet("AllLivresByUser")]
    public async Task<IActionResult> GetLivres(int idUtilisateur)
    {
        List<Collection>? collections = await _context.Collections.Where(p => p.idUtilisateur == idUtilisateur).ToListAsync();

        
        return Ok(collections.Count);
    }

    
    
    [HttpGet("AllLivresByUserByLivre")]
    public async Task<IActionResult> GetAllLivresByUserByLivre(int idUtilisateur, int idLivre)
    {
        List<Collection>? collections = await _context.Collections.Where(p => p.idUtilisateur == idUtilisateur && p.idLivre == idLivre).ToListAsync();

        var _collect = _mapper.Map<IEnumerable<CollectionDto>>(collections);
        var incremente = 0;
        foreach(var test in _collect)
        {
            incremente++;
        }
        return Ok(incremente);
    }


    [HttpGet("CollectionUtilisateur")]
    public async Task<IActionResult> GetCollectionUtilisateur(int idUtilisateur)
    {
        List<Collection>? collections = await _context.Collections.Where(p => p.idUtilisateur == idUtilisateur).ToListAsync();
        List<int>? newcollect = new List<int>();

        foreach(Collection collect in collections)
        {
            int val = 0;
            val = collect.idLivre;

            if(newcollect.Contains(val) == false)
            {
                newcollect.Add(val);
            }
        }
        
        List<Livre> allLivres = new List<Livre>();

        foreach(int id in newcollect)
        {
            Livre? newlivre = _context.Livres.FirstOrDefault(i => i.id == id);
            allLivres.Add(newlivre);
        }
        
        return Ok(allLivres);
        
    }


}