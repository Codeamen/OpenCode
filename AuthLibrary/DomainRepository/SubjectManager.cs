using AuthLibrary.Data;
using AuthLibrary.Interface;
using AuthLibrary.Models.BookEntities;
using AuthLibrary.ViewModels;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthLibrary.DomainRpository
{
    public class SubjectManager : ISubjectRepository
    {
        private readonly AuthLibraryDBContext _context;
        private readonly IMapper _mapper;

        public SubjectManager(AuthLibraryDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task Create(Subject subject)
        {
            try
            {
                if(subject != null)
                {
                    //var newResult = new Subject()
                    //{
                    //    SubjectId = subject.SubjectId,
                    //    Name = subject.Name,
                    //    BookSubjects = subject.BookSubjects
                    //};

                    var result = await _context.Subjects.AddAsync(subject);
                    var save = await _context.SaveChangesAsync();
                    
                }
               
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task Delete(int Id)
        {
            try
            {
                var result = await _context.Subjects.FindAsync(Id);
                var delete =  _context.Subjects.Remove(result);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task Edit(Subject subject)
        {
            try
            {
                
                var update =  _context.Subjects.Update(subject);
                var save = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<Subject>> GetAllWithBooksAsync(string searchString)
        
        
        {
            try
            {
               var subjects =  from s in _context.Subjects.Include(bs => bs.BookSubjects)
                select s;
                if (!String.IsNullOrEmpty(searchString))
                {
                    subjects = subjects.Where(s => s.Name.ToLower().Contains(searchString.ToLower()));
                    //subjects = subjects.Where(s => s.Name.ToLower().Contains(searchString.ToLower()));
                }
                //var get = await _context.Subjects
                //    .Include(bs => bs.BookSubjects).Where(s => s.Name.ToLower().Contains(searchString.ToLower())
                //    .ToListAsync();

                if(subjects!= null)
                {
                    // return (await subjects.AsNoTracking().ToListAsync());
                    return await subjects.AsNoTracking().ToListAsync();
                }
                return null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Subject> GetSingleWithBooks(int id)
        {
            try
            {
                var result = await _context.Subjects
                    .Where(a => a.SubjectId== id)
                    .Include(bs => bs.BookSubjects)
                 .ThenInclude(b => b.Book)
                 .FirstOrDefaultAsync();
                if(result != null)
                {
                    return result;
                }
                return null;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
