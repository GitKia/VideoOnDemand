using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOD.Membership.Database.Entities;

namespace VOD.Membership.Database.Contexts
{
    public class VODContext : DbContext
    {
        public VODContext(DbContextOptions<VODContext> options): base(options)
        {

        }
        public override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e =>
            e.GetForeignKeys()))

            {
                relationship.DeleteBehavior = DeleteBehavior.Cascade;
            }
        }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Videos> Videos { get; set; }

    }
}
