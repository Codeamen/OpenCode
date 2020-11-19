using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthLibrary.ViewModels
{
    public class SubjectViewModel
    {
        [DisplayName("Id")]
        public int SubjectId { get; set; }

        [Required]
        public string Name { get; set; }

        public List<BookViewModel> Books { get; set; }
    }
}
