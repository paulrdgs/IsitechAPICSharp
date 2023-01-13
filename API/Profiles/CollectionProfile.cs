using AutoMapper;
using MangaAPI.Models;
using MangaAPI.Models.DTO.Incoming;
using MangaAPI.Models.DTO.outgoing;

namespace MangaAPI.Profiles;

public class CollectionProfile : Profile
{
    public CollectionProfile()
    {

        CreateMap<CollectionForCreationDto, Collection>()
            .ForMember(
                dest => dest.id,
                opt => opt.MapFrom(src => new Int128())
            )
            .ForMember(
                dest => dest.idUtilisateur,
                opt => opt.MapFrom(x => $"{x.idUtilisateur}")
            )
            .ForMember(
                 dest => dest.idLivre,
                opt => opt.MapFrom(x =>  $"{x.idLivre}")
            )
            .ForMember(
                dest => dest.idTome,
                opt => opt.MapFrom(x => $"{x.idTome}")
            );


        CreateMap<Collection, CollectionDto>()
            .ForMember(
                dest => dest.idUtilisateur,
                opt => opt.MapFrom(x => $"{x.idUtilisateur}")
            )
            .ForMember(
                 dest => dest.idLivre,
                opt => opt.MapFrom(x =>  $"{x.idLivre}")
            )
            .ForMember(
                dest => dest.idTome,
                opt => opt.MapFrom(x => $"{x.idTome}")
            );

        CreateMap<Collection, CollectionJustLivreDto>()
            .ForMember(
                dest => dest.idUtilisateur,
                opt => opt.MapFrom(x => $"{x.idUtilisateur}")
            )
            .ForMember(
                 dest => dest.idLivre,
                opt => opt.MapFrom(x =>  $"{x.idLivre}")
            );


        
    }
}