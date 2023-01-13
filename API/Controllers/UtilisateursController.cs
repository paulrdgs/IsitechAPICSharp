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
public class UtilisateursController : ControllerBase
{
    private readonly ApplicationDbContext _context;


    private readonly ILogger<UtilisateursController> _logger;
    private readonly IMapper _mapper; 


    public UtilisateursController(ILogger<UtilisateursController> logger, IMapper mapper, ApplicationDbContext dbContext)
    {
        _logger = logger;
        _mapper = mapper;
        _context = dbContext;
    }
    

    [HttpGet("SpecificUtilisateur")]
    public async Task<ActionResult<List<Utilisateur>>> GetSpecificUtilisateur(string name)
    {
        List<Utilisateur>? utilisateur = await _context.Utilisateurs.Where(i => i.nom == name).ToListAsync();

        var _utilisateur = _mapper.Map<IEnumerable<UtilisateurDto>>(utilisateur);

        return Ok(_utilisateur);
    }

    
    

    [HttpPost("CreateUtilisateur")]
    public async Task<IActionResult> CreateUtilisateur(UtilisateurForCreationDto data)
    {
        
        if(data != null)
        {      
            var _utilisateur = _mapper.Map<Utilisateur>(data);

            await _context.Utilisateurs.AddAsync(_utilisateur);
            await _context.SaveChangesAsync();

            return Ok("Utilisateur bien ajouté");
        } 

        return new JsonResult("Something went wrong") { StatusCode = 500 };
    }


    [HttpDelete("SpecificUtilisateur")]
    public async Task<IActionResult> DeleteSpecificUtilisateur([FromBody] UtilisateurDto data)
    {
        List<Utilisateur>? utilisateur = await _context.Utilisateurs.Where(i => i.nom == data.nom && i.prenom == data.prenom).ToListAsync();

        foreach(Utilisateur user in utilisateur)
        {
            _context.Utilisateurs.Remove(user);
        }
        await _context.SaveChangesAsync();

        return Ok("L'utilisateur est bien supprimé");

    }




    [HttpPut("UpdateUtilisateur")]
    public async Task<IActionResult> Modifier([FromBody] UtilisateurForUpdateDto data)
    {

        Utilisateur user = _mapper.Map<Utilisateur>(data);

        Utilisateur? newuser = _context.Utilisateurs.FirstOrDefault(i => i.nom == data.ancien_nom && i.prenom == data.ancien_prenom);
        
        if(newuser != null)
        {
            newuser.nom = user.nom;
            newuser.prenom = user.prenom;
            _context.Utilisateurs.Update(newuser);
            await _context.SaveChangesAsync();
        }
        

        return Ok(data);
    }
    

    

}