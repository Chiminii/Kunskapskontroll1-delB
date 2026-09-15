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

        if (!course.Students.Contains(this))
        {
            // if false, then the course is full
            if (!course.Enroll(this))
            {
                Console.WriteLine($"{course.Name} is full. {Name} cannot join.");
                return;
            }
        }
        // if true, then the course is not full 
        Courses.Add(course);
    }
    public void Leave(Course course)
    {
        // check if this course exists in the student's list
        if (!Courses.Contains(course))
        {
            // check if the course has the student registered
            if (!course.Students.Contains(this))
            {
                Console.WriteLine($"Cannot leave since the student wasn't enrolled in the course {course.Name} to begin with. ");
            }
            return;
        }
        // if the student is registered then can be removed
        Courses.Remove(course);
        Console.WriteLine($" {Name} left {course} ");
        course.Remove(this);
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