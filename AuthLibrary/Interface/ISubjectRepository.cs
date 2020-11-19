using AuthLibrary.Models.BookEntities;
using AuthLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthLibrary.Interface
{
    public interface ISubjectRepository
    {
       Task <IEnumerable<Subject>> GetAllWithBooksAsync(string searchString);
       Task <Subject> GetSingleWithBooks(int id);
        Task Create(Subject subject);
        Task Edit(Subject subject);
        Task Delete(int Id);
    }
}
