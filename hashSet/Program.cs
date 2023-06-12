using HashSet.Entities;

Course A = new Course { Name = "A" };
Course B = new Course { Name = "B" };
Course C = new Course { Name = "C" };

List<Course> ListCourses = new List<Course>() { A, B, C };
HashSet<int> Registrations = new HashSet<int>();

foreach (Course course in ListCourses)
{
    Console.WriteLine($"How many students for course {course.Name}?");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("Type the registrations");
    for (int i = 0; i < n; i++)
    {
        int numberOfRegistration = int.Parse(Console.ReadLine());
        Registrations.Add(numberOfRegistration);
    }
}

Console.WriteLine($"Total students: {Registrations.Count}");