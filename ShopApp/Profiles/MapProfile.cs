using AutoMapper;
using ShopApp.Data.Entities;
using ShopApp.Dtos.AuthorDtos;
using ShopApp.Dtos.BookDtos;

namespace ShopApp.Profiles;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<Author, AuthorInBookReturnDto>();
        CreateMap<Book, BookReturnDto>()
        .ForMember(b => b.Authors, map => map.MapFrom(b => b.BookAuthors.Select(ba => ba.Author)));

        CreateMap<Book, BookInAuthorReturnDto>();
        CreateMap<Author, AuthorReturnDto>()
        .ForMember(a => a.Books, map => map.MapFrom(b => b.BookAuthors.Select(ba => ba.Book)));

        CreateMap<BookCreateDto, Book>();
        CreateMap<AuthorCreateDto, Author>();
    }
}
