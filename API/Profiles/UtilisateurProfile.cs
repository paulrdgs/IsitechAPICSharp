using AutoMapper;
using MangaAPI.Models;
using MangaAPI.Models.DTO.Incoming;
using MangaAPI.Models.DTO.outgoing;

namespace MangaAPI.Profiles;

public class UtilisateurProfile : Profile
{
    public UtilisateurProfile()
    {
        CreateMap<UtilisateurForCreationDto, Utilisateur>()
            .ForMember(
                dest => dest.id,
                opt => opt.MapFrom(src => new Int128())
            )
            .ForMember(
                dest => dest.nom,
                opt => opt.MapFrom(src => $"{src.nom}")
            )
            .ForMember(
                dest => dest.prenom,
                opt => opt.MapFrom(src => $"{src.prenom}")
            );

        CreateMap<Utilisateur, UtilisateurDto>()
            .ForMember(
                dest => dest.nom,
                opt => opt.MapFrom(x => $"{x.nom}")
            )
            .ForMember(
                 dest => dest.prenom,
                opt => opt.MapFrom(x =>  $"{x.prenom}")
            );

        CreateMap<UtilisateurForUpdateDto, Utilisateur>()
            .ForMember(
                dest => dest.id,
                opt => opt.MapFrom(src => new Int128())
            )
            .ForMember(
                dest => dest.nom,
                opt => opt.MapFrom(src => $"{src.nouveau_nom}")
            )
            .ForMember(
                dest => dest.prenom,
                opt => opt.MapFrom(src => $"{src.nouveau_prenom}")
            );
    }
}