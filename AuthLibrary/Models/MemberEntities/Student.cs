using System;
using System.Collections.Generic;
using System.Text;

namespace AuthLibrary.Models.MemberEntities
{
    public class Student: Person
    {
        public string MatricNumber { get; set; }
       
        public string Password { get; set; }
       
    }
}
