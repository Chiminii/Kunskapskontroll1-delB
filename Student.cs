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
            Console.WriteLine($"{Name} is already in the course {course.Name}");
            return;
        }
        // check if course is full
        if (!course.Students.Contains(this))
        {
            if(course.Students.Count >= course.MaxSeats)
            {
                Console.WriteLine($"Course {course.Name} is full. {Name} cannot join.");
                return;
            }
        }
        course.Students.Add(this);
        Courses.Add(course);
        Console.WriteLine($"{Name} has enrolled in the course {course.Name}.");
    }
    public void Leave(Course course)
    {
        // check if this course exists in the student's list
        if (!Courses.Contains(course))
        {
            // check if the course has the student registered
            if (!course.Students.Contains(this))
            {
                Console.WriteLine($"{Name} cannot leave, the student wasn't enrolled in the course {course.Name} to begin with. ");
            }
            return;
        }
        // if the student is registered then can be removed
        course.Students.Remove(this);
        Courses.Remove(course);
        Console.WriteLine($"{Name} has left the {course.Name} course. ");
    }

    public void Schedule()
    {
        Console.WriteLine($"\n{Name}'s schedule");
        foreach (Course course in Courses)
        {
            Console.WriteLine($"{Name} has {course.Name} ");
        }
    }

    public override string ToString()
    {
        return $"{Name}";
    }

}