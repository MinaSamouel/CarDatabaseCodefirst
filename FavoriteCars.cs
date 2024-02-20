namespace CarDatabaseCodefirst;

public class FavoriteCars
{
    public int Ssn { get; set; }

    public int CarId { get; set; }

    public User User { get; set; }
    public List<Car> Cars { get; set; }
}