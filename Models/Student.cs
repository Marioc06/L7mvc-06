using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        //@* tinfo200:[2021-03-12-marioc6-dykstra1] - Introducing a simple class structure for the auto-implemented properties get/set*@
        //@* tinfo200:[2021-03-12-marioc6-dykstra1] - Auto-implemented properties get/set are also public interface & Declaring a property*@
        public int ID { get; set; }
        public string LastName { get; set; }

        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments{ get; set; }

    }
}
