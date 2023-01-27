using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOD.Membership.Database.Entities
{
    public class Course : IEntity
    {
        public int Id { get; set; } 
        public string ImageUrl { get; set; }
        public string MarqueeImageUrl { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public int Free { get; set; }
        public int InstructorId { get; set; }



    }
}
