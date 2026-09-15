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
        // anmäl en studerande till kursen om det finns en plats
    }

    public void Remove(Student student)
    {
        // ta bort en studerande ur kursen
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