using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAT.Core.DataModels
{
    public class LecturesDataModel
    {
        public string Id { get; set; }
        public string CourseId { get; set; }
        [ForeignKey(nameof(CourseId))]
        public CoursesDataModel Course { get; set; }
        public string LecturerId { get; set; }
        [ForeignKey(nameof(LecturerId))]
        public LecturersDataModel Lecturer { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<AttendeesDataModel> Attendees { get; set; }
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;


    }
}
