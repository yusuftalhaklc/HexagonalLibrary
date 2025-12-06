using AutoMapper;
using Library.Application.DTOs.Author.Results;
using Library.Application.DTOs.Book.Results;
using Library.Application.DTOs.BookTag.Results;
using Library.Application.DTOs.Category.Results;
using Library.Application.DTOs.Tag.Results;
using Library.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Author mappings
            CreateMap<Author, AuthorQueryResult>().ReverseMap();
            CreateMap<DTOs.Author.Commands.CreateAuthorCommand, Author>();
            CreateMap<DTOs.Author.Commands.UpdateAuthorCommand, Author>();

            // Book mappings
            CreateMap<Book, BookQueryResult>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category != null ? src.Category.Name : string.Empty))
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author != null ? $"{src.Author.Firstname} {src.Author.LastName}" : string.Empty));
            CreateMap<DTOs.Book.Commands.CreateBookCommand, Book>();
            CreateMap<DTOs.Book.Commands.UpdateBookCommand, Book>();

            // Category mappings
            CreateMap<Category, CategoryQueryResult>().ReverseMap();
            CreateMap<DTOs.Category.Commands.CreateCategoryCommand, Category>();
            CreateMap<DTOs.Category.Commands.UpdateCategoryCommand, Category>();

            // Tag mappings
            CreateMap<Tag, TagQueryResult>().ReverseMap();
            CreateMap<DTOs.Tag.Commands.CreateTagCommand, Tag>();
            CreateMap<DTOs.Tag.Commands.UpdateTagCommand, Tag>();

            // BookTag mappings
            CreateMap<BookTag, BookTagQueryResult>()
                .ForMember(dest => dest.BookTitle, opt => opt.MapFrom(src => src.Book != null ? src.Book.Title : string.Empty))
                .ForMember(dest => dest.TagName, opt => opt.MapFrom(src => src.Tag != null ? src.Tag.Name : 0));
            CreateMap<DTOs.BookTag.Commands.CreateBookTagCommand, BookTag>();
            CreateMap<DTOs.BookTag.Commands.UpdateBookTagCommand, BookTag>();
        }
    }
}

