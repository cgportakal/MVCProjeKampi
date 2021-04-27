using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    /// <summary>
    /// Context sınıfı: Ben artık tablolarımı veri tabanına
    /// yansıtmaya hazırım anlamına gelen sınıf diye düşünebiliriz.
    /// </summary>
    public class Context : DbContext
    {
        /// <summary>
        /// Projede yer alan sınıf adı About
        /// Veri tabanında yer alan tablo adı Abouts
        /// </summary>
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
