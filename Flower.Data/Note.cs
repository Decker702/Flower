using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower.Data
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        //This is optional, don't decorate it with Required.
        public string Content1 { get; set; }

        [Required]
        public DateTimeOffset CreateUtc { get; set;}

        public DateTimeOffset? MotifiedUtc { get; set; }



    }
}
