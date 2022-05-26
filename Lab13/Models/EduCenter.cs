using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_2.Models
{
    public partial class EduCenter : DbContext
    {
        public EduCenter() : base("name=Model1")
        { }

        public virtual DbSet<Course> courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        { }
    }
}
