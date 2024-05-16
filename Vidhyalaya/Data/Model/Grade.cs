using System.ComponentModel.DataAnnotations;

public class Grade
{
    [Key]
    public int Label { get; set;}
    public string ClassTeacher { get; set;}
    public string Medium { get; set;}
    public string Subjects { get; set;}
    public string SessionYear { get; set;}
    public List<Student> Students{ get; set;}
}