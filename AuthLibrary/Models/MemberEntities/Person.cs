using AuthLibrary.Models.IssueEntities;

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthLibrary.Models.MemberEntities
{
    public class Person : IdentityUser
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhonNumber { get; set; }
      
        public PersonRole PersonRole { get; set; }
        public Department Department { get; set; }
        public ICollection<Issue> Issues { get; set; }

    }
}
