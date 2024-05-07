// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations.Schema;

public class Personel
{
    public int PersonelId { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public Department Department { get; set; }

    [ForeignKey(nameof(Department))]
    public int DepartmentId { get; set;}
    public Task Task { get; set; }

    [ForeignKey(nameof(Task))]
    public int TaskId { get; set; }
    
}
