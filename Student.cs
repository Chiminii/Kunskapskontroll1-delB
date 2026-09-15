class Student
{
    public string Name;
    public List<Course> Courses = [];

    public Student(string name)
    {
        Name = name;
    }

    public void Join(Course course)
    {
        // checking if there are any doubles
        if (Courses.Contains(course))
        {
            Console.WriteLine($"Already in the course {course}");
            return;
        }
        
        if(!course.Students.Contains(this))
        {
            // if false, then the course is full
            if (!course.Enroll(this))
            {
                Console.WriteLine( $"{course.Name} is full. {Name} cannot join.");
                return;
            }
        }
        // if true, then the course is not full 
        Courses.Add(course);
    }
    public void Leave(Course course)
    {
        // lämnar en kurs
    }

    public void Schedule()
    {
        // skriver ut vilka kurser den studerande går
    }

    public override string ToString()
    {
        return $"{Name}";
    }

}