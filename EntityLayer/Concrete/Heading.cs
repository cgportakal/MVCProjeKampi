using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingId { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        
        //Category tablosu ile ilişki kurduk.
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        //Başlık ile İçeriği bağlantısın kurduk.
        //1 başlık çok içerik.
        public ICollection<Content> Contents { get; set; }

        //Yazar ile ilişki kurduk.
        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
