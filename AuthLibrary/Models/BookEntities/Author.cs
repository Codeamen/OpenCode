using System;
using System.Collections.Generic;
using System.Text;

namespace AuthLibrary.Models.BookEntities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
