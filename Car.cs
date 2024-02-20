namespace CarDatabaseCodefirst;

public class Car
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public DateTime ModelYear { get; set; }
    public string Color { get; set; }
    public string Category { get; set; }
    public int SeatCount { get; set; }
    public int PricePerDay { get; set; }
    public string Images { get; set; }

    public bool IsAutomatic { get; set; }
    public bool HasAirCondition { get; set; }

}