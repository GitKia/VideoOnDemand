using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOD.Common.DTOs
{
    public class CourseDTO
    {
        public int Id { get; set; }
        public string ImageURL { get; set; }
        public string Marqueelabel { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Free { get; set; }
        public List<SectionDTO> Sections { get; set; }
        public List<InstructorDTO>? Instructors { get; set; }

    }
}
