namespace cascadingvalues.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        // Constructor
        public Student() { }

        public Student(int id, string name, int age, string course)
        {
            Id = id;
            Name = name;
            Age = age;
            Course = course;
        }

        // Method to Display Student Info
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age}, Course: {Course}";
        }
    }
}
