using AutoMapper;
using Library.Application.DTOs.AuthorDTOs.Results;
using Library.Application.DTOs.BookDTOs.Results;
using Library.Application.DTOs.BookTagDTOs.Results;
using Library.Application.DTOs.CategoryDTOs.Results;
using Library.Application.DTOs.TagDTOs.Results;
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
            CreateMap<DTOs.AuthorDTOs.Commands.CreateAuthorCommand, Author>();
            CreateMap<DTOs.AuthorDTOs.Commands.UpdateAuthorCommand, Author>();

            // Book mappings
            CreateMap<Book, BookQueryResult>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category != null ? src.Category.Name : string.Empty))
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author != null ? $"{src.Author.Firstname} {src.Author.LastName}" : string.Empty));
            CreateMap<DTOs.BookDTOs.Commands.CreateBookCommand, Book>();
            CreateMap<DTOs.BookDTOs.Commands.UpdateBookCommand, Book>();

            // Category mappings
            CreateMap<Category, CategoryQueryResult>().ReverseMap();
            CreateMap<DTOs.CategoryDTOs.Commands.CreateCategoryCommand, Category>();
            CreateMap<DTOs.CategoryDTOs.Commands.UpdateCategoryCommand, Category>();

            // Tag mappings
            CreateMap<Tag, TagQueryResult>().ReverseMap();
            CreateMap<DTOs.TagDTOs.Commands.CreateTagCommand, Tag>();
            CreateMap<DTOs.TagDTOs.Commands.UpdateTagCommand, Tag>();

            // BookTag mappings
            CreateMap<BookTag, BookTagQueryResult>()
                .ForMember(dest => dest.BookTitle, opt => opt.MapFrom(src => src.Book != null ? src.Book.Title : string.Empty))
                .ForMember(dest => dest.TagName, opt => opt.MapFrom(src => src.Tag != null ? src.Tag.Name : 0));
            CreateMap<DTOs.BookTagDTOs.Commands.CreateBookTagCommand, BookTag>();
            CreateMap<DTOs.BookTagDTOs.Commands.UpdateBookTagCommand, BookTag>();
        }
    }
}

