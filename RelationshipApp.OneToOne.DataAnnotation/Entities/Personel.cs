public class Personel
{
    public int PersonelId { get; set; } //int yerine Guid de tip atanabilir.
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Tckn { get; set; }
    public PersonelAddress PersonelAddress { get; set; }

    //public int PersonelAddressId { get; set; }
}
