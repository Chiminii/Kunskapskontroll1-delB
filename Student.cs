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
        // gå med i en kurs
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