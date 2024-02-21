namespace CarDatabaseCodefirst;

public class FavoriteCars
{
    public int Ssn { get; set; }

    public int CarId { get; set; }

    public User User { get; set; }
    public Car Car { get; set; }
}