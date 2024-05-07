using System.ComponentModel.DataAnnotations.Schema;

public class PersonelAddress
{
    public int PersonelAddressId { get; set; } 
    public string Address { get; set; }
    public Personel Personel { get; set; }

    //public int PersonelId { get; set; } //bu property zorunlu değildir. bu kolonu oluşturmazsak one to one 
                                          //ilişkisi için foreign key personeladdressid olur.

}
