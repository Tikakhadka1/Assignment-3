public class Student
{
    public int Id { get; set;}
    public string Name { get; set; }
    public string Address { get; set; }
    public Gender Gender { get; set; }
    public DateTime Dob { get; set; }
    public byte[] Photo { get; set; }
    public string GuardianDetails { get; set; }
    public Grade? Grade{ get; set; }
}