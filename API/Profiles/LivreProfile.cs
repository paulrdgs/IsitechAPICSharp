using AutoMapper;
using MangaAPI.Models;
using MangaAPI.Models.DTO.Incoming;
using MangaAPI.Models.DTO.outgoing;

namespace MangaAPI.Profiles;

public class LivreProfile : Profile
{
    public LivreProfile()
    {

        CreateMap<Livre, LivreDto>()
            .ForMember(
                dest => dest.nom,
                opt => opt.MapFrom(x => $"{x.nom}")
            )
            .ForMember(
                 dest => dest.edition,
                opt => opt.MapFrom(x =>  $"{x.edition}")
            )
            .ForMember(
                dest => dest.resumer,
                opt => opt.MapFrom(x => $"{x.resumer}")
            )
            .ForMember(
                dest => dest.prix,
                opt => opt.MapFrom(x => $"{x.prix}")
            );

        CreateMap<LivreForCreationDto, Livre>()
            .ForMember(
                dest => dest.id,
                opt => opt.MapFrom(src => new Int128())
            )
            .ForMember(
                dest => dest.nom,
                opt => opt.MapFrom(x => $"{x.nom}")
            )
            .ForMember(
                 dest => dest.edition,
                opt => opt.MapFrom(x =>  $"{x.edition}")
            )
            .ForMember(
                dest => dest.resumer,
                opt => opt.MapFrom(x => $"{x.resumer}")
            )
            .ForMember(
                dest => dest.prix,
                opt => opt.MapFrom(x => $"{x.prix}")
            );

        CreateMap<LivreForDeleteSpecificDto, Livre>()
            .ForMember(
                dest => dest.id,
                opt => opt.MapFrom(src => new Int128())
            )
            .ForMember(
                dest => dest.nom,
                opt => opt.MapFrom(x => $"{x.nom}")
            );

        CreateMap<LivreForUpdateDto, Livre>()
            .ForMember(
                dest => dest.id,
                opt => opt.MapFrom(src => new Int128())
            )
            .ForMember(
                dest => dest.resumer,
                opt => opt.MapFrom(src => $"{src.nouveau_resumer}")
            )
            .ForMember(
                dest => dest.prix,
                opt => opt.MapFrom(src => $"{src.nouveau_prix}")
            );

        
    }
}