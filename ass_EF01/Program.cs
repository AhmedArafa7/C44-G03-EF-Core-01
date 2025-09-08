using ass_EF01.Contexts;

namespace ass_EF01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CourseDbContext context = new CourseDbContext();
        }
    }
}
