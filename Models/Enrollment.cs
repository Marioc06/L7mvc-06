namespace ContosoUniversity.Models
{
    public enum Grade
    //@* tinfo200:[2021-03-12-marioc6-dykstra1] - The multiple options to find the right Grade to fall under. "Grade?".*@
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        //@* tinfo200:[2021-03-12-marioc6-dykstra1] - The same thing here for the auto-implemented properties in interfaces*@
        //@* tinfo200:[2021-03-12-marioc6-dykstra1] - EnrollmentID, StudentID, CourseID to make implement Inheritance accurate and easier to identify.*@
        public int EnrollmentID { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        public Grade? Grade { get; set; }
        public Student Student { get; set; }
    }
}