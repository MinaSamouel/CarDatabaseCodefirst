namespace CarDatabaseCodefirst;

public class Review
{
    public int ReservationId { get; set; }
    public int CarId { get; set; }
    public int UserSsn { get; set; }

    public string Message { get; set; }
    public int Rate { get; set; }

    public Car Car { get; set; }
    public User User { get; set; }
    public Reservation Reservation { get; set; }
}