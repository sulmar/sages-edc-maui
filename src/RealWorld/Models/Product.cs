namespace Models;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public decimal TotalAmount => Price * Quantity;
    public bool Archived { get; set; }


    private int available;
    public int Available
    {
        get
        {
            return available;
        }
        set
        {
            available = value;
            OnPropertyChanged(nameof(Available));
        }
    }
}
