using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        [StringLength(50)]
        public string WriterName { get; set; }
        [StringLength(50)]
        public string WriterSurname { get; set; }
        [StringLength(100)]
        public string WriterImage { get; set; }
        [StringLength(70)]
        public string WriterMail { get; set; }
        [StringLength(25)]
        public string WriterPassword { get; set; }

        //Heading ile ilişki kurduk.
        public ICollection<Heading> Headings { get; set; }
        //Content(içerik) ile ilişki kurduk.
        public ICollection<Content> Contents { get; set; }
    }
}
