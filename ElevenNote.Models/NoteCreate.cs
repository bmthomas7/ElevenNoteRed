using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteCreate
    {
        [Required]
        [MinLength(2, ErrorMessage ="Please enter at least 2 characters")]
        public string Title { get; set; }

        [MaxLength(8000)]
        public String Content { get; set; }


    }
}
