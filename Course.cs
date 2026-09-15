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

    public bool Enroll(Student student)
    {
        // check for doubles
        if (Students.Contains(student))
        {
            Console.WriteLine("Already contains this student.");
            return false;
        }
        // check if there are still places left in the course
        if(Students.Count < MaxSeats)
        {
            Students.Add(student);
            Console.WriteLine( $"{student} has enrolled the course {Name}.");

            student.Join(this);
            return true;
        }
        else
        {
            Console.WriteLine($"Course {Name} is full. {student.Name} cannot enroll.");
            return false;
        }
    }

    public bool Remove(Student student)
    {
        // if a student isn't registered
        if (!Students.Contains(student))
        {
            // Console.WriteLine( $"Cannot be removed. This {student.Name} does not exist on the list.");
            return false;
        }
        else
        {
            Students.Remove(student);
            Console.WriteLine($"Removed {student.Name}");
            student.Leave(this);
            return true;
        }
    }

    public void RollCall()
    {
        // skriver ut alla studerande i kursen
    }

    public override string ToString()
    {
        return $"{Name}: ({MaxSeats}) seats. ";
    }
}