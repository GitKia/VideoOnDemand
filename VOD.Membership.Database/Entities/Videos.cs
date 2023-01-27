using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VOD.Membership.Database.Entities
{
    public class Video : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public string Thumbnail { get; set; }
        public string Url { get; set; }

        public int SectionId { get; set; }
    }
}
