// See https://aka.ms/new-console-template for more information

public class Department
{
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public ICollection<Personel> Personels { get; set; }
}
