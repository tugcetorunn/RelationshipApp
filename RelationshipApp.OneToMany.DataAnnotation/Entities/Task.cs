// See https://aka.ms/new-console-template for more information


public class Task
{
    public int TaskId { get; set; }
    public string Description { get; set; }
    public ICollection<Personel> Personels { get; set; }
}
