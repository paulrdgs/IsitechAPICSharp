using AutoMapper;
using MangaAPI.Models;
using MangaAPI.Models.DTO.Incoming;
using MangaAPI.Models.DTO.outgoing;

namespace MangaAPI.Profiles;

public class TomeProfile : Profile
{
    public TomeProfile()
    {
        CreateMap<TomeForCreationDto, Tome>()
            .ForMember(
                dest => dest.id,
                opt => opt.MapFrom(src => new Int128())
            )
            .ForMember(
                dest => dest.idLivre,
                opt => opt.MapFrom(src => $"{src.idLivre}")
            )
            .ForMember(
                dest => dest.numtome,
                opt => opt.MapFrom(src => $"{src.numtome}")
            );
    }
       
}