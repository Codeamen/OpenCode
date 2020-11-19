

using AuthLibrary.Models.IssueEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthLibrary.Models.BookEntities
{
    public class Book
    {
      
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public string Language { get; set; }
        public string ISBN { get; set; }
        public string CallNumber { get; set; }
        public int MaxIssueDays { get; set; }
        public Issue Issue { get; set; }
        //public int AuthorId { get; set; }
        public virtual ICollection<BookAuthor> BookAuthors { get; set; } 
        //public int SubjectId { get; set; }
        public List<BookSubject> BookSubjects { get; set; } = new List<BookSubject>();
    }
}
