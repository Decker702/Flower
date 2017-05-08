using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower.Models
{
    public class NoteCreate
    {
        [Required]
        [MinLength(1, ErrorMessage = "Please enter at least 1 number or character")]
        [MaxLength(130)]
        public string Title { get; set; }

        [Required]
        [MaxLength(8888)]
        public string Content { get; set; }

        //This is optional
        public string  Content1 { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}
