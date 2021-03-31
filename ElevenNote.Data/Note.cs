using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Note
    {
        //[Required]
        //[Range(1,5, ErrorMessage ="please choose a number between 1 and 5")]
        //[MaxLength(100, ErrorMessage ="there are to many characters i this field")]

        //[Display(Name ="your note")]

        [key]   
        public int NoteId { get; set; }
        
        [Required]
        public Guid OwnerId { get; set; }
        
        [Required]
        public String Title { get; set; }
        
        [Required]
        public String Content { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}
