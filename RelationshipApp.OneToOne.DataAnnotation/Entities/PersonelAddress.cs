using System.ComponentModel.DataAnnotations.Schema;

public class PersonelAddress
{
    //[ForeignKey(nameof(Personel))]
    public int PersonelAddressId { get; set; } //personelid property sini sildiğimizde data annotation kullanmak
                                               //istiyorsak foreignkey attribute ünü bu kolonun üstüne yazıyoruz.
                                               //fazladan bir kolon oluşturmayıp programı daha temiz hale getirmiş
                                               //oluruz.
    public string Address { get; set; }
    public Personel Personel { get; set; }

    [ForeignKey(nameof(Personel))]
    public int PersonelId { get; set; } //bu property zorunlu değildir. bu kolonu oluşturmazsak one to one 
                                        //ilişkisi için foreign key personeladdressid olur.

}
