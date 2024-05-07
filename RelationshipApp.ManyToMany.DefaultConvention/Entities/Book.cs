// See https://aka.ms/new-console-template for more information
public class Book
{
    public int BookId { get; set; }
    public string Name { get; set; }
    public int ISBNNo { get; set; }
    public ICollection<Author> Authors { get; set;}
}
