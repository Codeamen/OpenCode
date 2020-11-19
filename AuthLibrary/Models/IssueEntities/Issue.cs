
using AuthLibrary.Models.BookEntities;
using AuthLibrary.Models.MemberEntities;


using System;
using System.Collections.Generic;
using System.Text;

namespace AuthLibrary.Models.IssueEntities
{
    public class Issue
    {
        public int IssueId { get; set; }
        public DateTime IssuDate { get; set; }
        public DateTime ReturnDate { get; set; }
        //public int MemberId { get; set; }
        //public Member Member { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
    }
}
