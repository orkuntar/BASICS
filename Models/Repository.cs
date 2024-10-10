namespace BASICS.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>() {
            new Course() {Id=1, Title = "Python", Description = "Python Kursu", Image="1.jpg", Tags = new string[] {"aspnet", "web gelistirme"}, isActive = true, isHome = true },
            new Course() {Id=2, Title = "PHP", Description = "PHP Kursu", Image="2.jpg", Tags = new string[] {"php", "web gelistirme"}, isActive = true, isHome = true},
            new Course() {Id=3, Title = "Django", Description = "Django Kursu", Image="3.png", Tags = new string[] {"django", "web gelistirme"}, isActive = true, isHome = true},
            new Course() {Id=4, Title = "JavaScript", Description = "JavaScript Kursu", Image="1.jpg", Tags = new string[] {"javascript", "web gelistirme"}, isActive = true, isHome = false}
            };
        }
        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}