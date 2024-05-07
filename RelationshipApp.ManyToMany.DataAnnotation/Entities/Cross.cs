// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations.Schema;

public class Cross
{
    [ForeignKey(nameof(Book))]
    public int BookId { get; set; }

    [ForeignKey(nameof(Author))]
    public int AuthorId { get; set; }
    public Author Author { get; set; }
    public Book Book { get; set; }
}
