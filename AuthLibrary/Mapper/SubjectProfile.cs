using AuthLibrary.Models.BookEntities;
using AuthLibrary.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthLibrary.Mapper
{
    public class SubjectProfile : Profile
    {
        public SubjectProfile()
        {
            //CreateMap<Subject, SubjectViewModel>()
                //.ForMember(dst => dst.Books, opt => opt.MapFrom(x => x.BookSubjects.Select(y => y.Book).ToList()));
            CreateMap<SubjectViewModel, Subject>();
            CreateMap<Models.BookEntities.Subject, ViewModels.SubjectViewModel>()
                .ForMember(dst => dst.Books, opt => opt.MapFrom(x => x.BookSubjects.Select(y => y.Book).ToList()));
        }
    }
}
