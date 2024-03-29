﻿namespace CarDatabaseCodefirst;

public class User
{
    public int Ssn { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string Image { get; set; }
    public bool IsAdmin { get; set; }

    public List<FavoriteCars> FavoriteCars { get; set; }
    //public List<Car> Cars { get; set; }
    public List<Reservation> Reservations { get; set; }

    public List<Review> Reviews { get; set; }
}