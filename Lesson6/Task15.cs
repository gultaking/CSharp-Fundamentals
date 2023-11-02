namespace CSharpFundamentals.Lesson6;

public class Task15
{
    public void Sort()
    {
        List<Student> list = new List<Student>()
        {
            new Student() { Id = 4, Name = "Rima", Age = 18 },
            new Student() { Id = 3, Name = "Anar", Age = 22 },
            new Student() { Id = 5, Name = "Nara", Age = 19 },
            new Student() { Id = 1, Name = "Bahar", Age = 20 }
        };

        IEnumerable<Student> check = from element in list
            orderby element.Name
            select element;

        foreach (Student item in check)
        {
            Console.WriteLine($"Id = {item.Id} ,Name = {item.Name}, Age = {item.Age}");
        }
    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}