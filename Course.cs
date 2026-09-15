class Course
{
    public string Name;
    public int MaxSeats;
    public List<Student> Students = [];

    public Course(string name, int maxSeats)
    {
        Name = name;
        MaxSeats = maxSeats;
    }

    public void Enroll(Student student)
    {
        // check for doubles
        if (Students.Contains(student))
        {
            Console.WriteLine($"{student.Name} is already the {Name} course.");
            return;
        }

        // check if course is full
        if (!student.Courses.Contains(this))
        {
            if (Students.Count >= MaxSeats)
            {
                Console.WriteLine($"Course {Name} is full. {student.Name} cannot enroll.");
                return;
            }
        }

        student.Courses.Add(this);
        Students.Add(student);
        Console.WriteLine($"{student} has enrolled in the course {Name}.");
    }

    public void Remove(Student student)
    {
        // if a student isn't registered
        if (!Students.Contains(student))
        {
            Console.WriteLine($"Cannot be removed. {student.Name} does not exist on the list.");
            return;
        }
        else
        {
            student.Courses.Remove(this);
            Students.Remove(student);
            Console.WriteLine($"Removed {student.Name} from the {Name} course.");
            return;
        }
    }

    public void RollCall()
    {
        Console.WriteLine($"\nStudents in the {Name} course");
        foreach (Student student in Students)
        {
            Console.WriteLine($"{student} ");
        }
    }

    public override string ToString()
    {
        return $"{Name} ({Students.Count}/{MaxSeats} seats) ";
    }
}