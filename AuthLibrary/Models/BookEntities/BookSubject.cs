using System;
using System.Collections.Generic;
using System.Text;

namespace AuthLibrary.Models.BookEntities
{
   public class BookSubject
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
