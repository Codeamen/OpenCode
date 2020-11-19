using System;
using System.Collections.Generic;
using System.Text;

namespace AuthLibrary.Models.MemberEntities
{
    public class Lecturer: Person
    {
        public int LecturerId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


    }
}
