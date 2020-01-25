using System.ComponentModel.DataAnnotations;

namespace w13t1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name = "Name")]
        public string StudentName { get; set; }
        public int Age { get; set; }
        public Standard standard { get; set; }

        public bool isNewlyEnrolled { get; set; }
        public string Password { get; set; }
    }


    public class Standard
    {
        public int StandardId { get; set; }
        public string StrandardName { get; set; }
    }
}