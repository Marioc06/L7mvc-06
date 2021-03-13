using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Course
    {
        //@* tinfo200:[2021-03-12-marioc6-dykstra1] - Bringing in DatabaseGeneratedOption.None.*@
        //@* tinfo200:[2021-03-12-marioc6-dykstra1] - DatabaseGeneratedOption.None to generate the values for the property. *@
       
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
