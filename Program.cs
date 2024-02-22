namespace CarDatabaseCodefirst
{
    internal class Program
    {

        static void Main()
        {
            var dbcontext = new CarRentalContext();

            #region Generating tables data
            string[] carNames = { "Sedan", "SUV", "Hatchback", "Convertible", "Pickup Truck", "Crossover", "Minivan", "Coupe", "Electric", "Luxury Sedan" };
            string[] carBrands = { "Toyota", "Honda", "Ford", "Chevrolet", "Nissan", "Jeep", "Subaru", "Hyundai", "Kia", "Mazda" };
            string[] carColors = { "Red", "Blue", "Green", "Yellow", "Black", "White", "Silver", "Gray", "Brown", "Orange" };
            string[] carCategories = { "Economy", "Compact", "Midsize", "Standard", "Fullsize", "Premium", "Luxury", "SUV", "Van", "Truck" };
            string[] carImages = { "https://www.example.com/image1.jpg", "https://www.example.com/image2.jpg", "https://www.example.com/image3.jpg", "https://www.example.com/image4.jpg", "https://www.example.com/image5.jpg", "https://www.example.com/image6.jpg", "https://www.example.com/image7.jpg", "https://www.example.com/image8.jpg", "https://www.example.com/image9.jpg", "https://www.example.com/image10.jpg" };
            bool[] IsAutomatic =
            { true, false, true, false, true, false, true, false, true, false };

            bool[] HasAirCodition =
            { true, false, true, false, true, false, true, false, true, false };
            DateTime[] modelYears =
            { new DateTime(2022, 1, 1), new DateTime(2021, 6, 1), new DateTime(2020, 3, 1), new DateTime(2019, 9, 1), new DateTime(2018, 5, 1), new DateTime(2017, 12, 1), new DateTime(2016, 8, 1), new DateTime(2015, 4, 1), new DateTime(2014, 11, 1), new DateTime(2013, 7, 1)
            };

            string[] modelYearsString =
            { "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013" };

            int[] pricesPerDay =
            { 50, 70, 40, 60, 80, 55,65, 75, 90, 55 };

            int[] seatCounts = { 4, 5, 4, 5, 4, 5, 4, 5, 4, 5 };




            string[] userSsn = { "1234567890", "2345678901", "3456789012", "4567890123", "56789053445", "6789012345", "7890123456", "8901234567", "9012345678", "0123456789" };
            int[] ssns = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] userNames = { "John", "Jane", "Robert", "Emily", "Michael", "Jessica", "William", "Ashley", "David", "Sophia" };
            string[] userPasswords = { "123456", "password", "password123", "12345678", "123456789", "password1234", "1234567", "password12345", "1234567890", "password123456" };

            string[] userEmails =
            {
            "emial1@gmail.com", "email2@gmail.com", "email3@gmail.com", "email4@gmail.com", "email5@gmail.com",
            "email6@gmail.com", "email7@gmail.com", "email8@gmail.com", "email9@gmail.com", "email10@gmail.com"
        };
            string[] userAddresses = { "Address1", "Address2", "Address3", "Address4", "Address5", "Address6", "Address7", "Address8", "Address9", "Address10" };
            string[] userImages = { "https://www.example.com/image1.jpg", "https://www.example.com/image2.jpg", "https://www.example.com/image3.jpg", "https://www.example.com/image4.jpg", "https://www.example.com/image5.jpg", "https://www.example.com/image6.jpg", "https://www.example.com/image7.jpg", "https://www.example.com/image8.jpg", "https://www.example.com/image9.jpg", "https://www.example.com/image10.jpg" };

            string[] phoneNumbers =
            { "+201234564890", "+201112223344", "+201998877665", "+201076543210", "+201555444333", "+201234567890", "+201987654321", "+201234569890", "+201112233445", "+201876543210" };

            bool[] isAdmin =
            { true, true, false, false, false, false, false, false, false, false };


            dbcontext = new CarRentalContext();
            dbcontext.Database.EnsureDeleted();
            dbcontext.Database.EnsureCreated();

            for (var i = 0; i < 10; i++)
            {
                var car = new Car
                {
                    Name = carNames[i],
                    Brand = carBrands[i],
                    ModelYear = modelYearsString[i],
                    Color = carColors[i],
                    Category = carCategories[i],
                    SeatCount = seatCounts[i],
                    PricePerDay = pricesPerDay[i],
                    Images = carImages[i],
                    IsAutomatic = IsAutomatic[i],
                    HasAirCondition = HasAirCodition[i]
                };
                dbcontext.Cars.Add(car);

                var user = new User
                {
                    Name = userNames[i],
                    Password = userPasswords[i],
                    Email = userEmails[i],
                    PhoneNumber = phoneNumbers[i],
                    Address = userAddresses[i],
                    Image = userImages[i],
                    IsAdmin = isAdmin[i]
                };
                dbcontext.Users.Add(user);
            }
            dbcontext.SaveChanges();

            dbcontext.FavoriteCars.Add(new FavoriteCars { Ssn = 3, CarId = 1 });
            dbcontext.FavoriteCars.Add(new FavoriteCars { Ssn = 3, CarId = 2 });
            dbcontext.FavoriteCars.Add(new FavoriteCars { Ssn = 3, CarId = 3 });
            dbcontext.FavoriteCars.Add(new FavoriteCars { Ssn = 3, CarId = 4 });
            dbcontext.FavoriteCars.Add(new FavoriteCars { Ssn = 4, CarId = 1 });
            dbcontext.FavoriteCars.Add(new FavoriteCars { Ssn = 4, CarId = 2 });
            dbcontext.FavoriteCars.Add(new FavoriteCars { Ssn = 4, CarId = 3 });
            dbcontext.FavoriteCars.Add(new FavoriteCars { Ssn = 4, CarId = 4 });
            dbcontext.SaveChanges();

            dbcontext.Reservations.Add(new Reservation { UserSsn = 3, CarId = 1, StartRentTime = new DateTime(2022, 1, 1), EndRentDate = new DateTime(2022, 1, 5) });

            dbcontext.Reservations.Add(new Reservation { UserSsn = 3, CarId = 2, StartRentTime = new DateTime(2022, 1, 1), EndRentDate = new DateTime(2022, 1, 3) });

            dbcontext.Reservations.Add(new Reservation { UserSsn = 3, CarId = 3, StartRentTime = new DateTime(2022, 1, 1), EndRentDate = new DateTime(2022, 1, 4) });
            dbcontext.SaveChanges();

            dbcontext.Reviews.Add(new Review { ReservationId = 1,UserSsn = 3, CarId = 1, Rate = 5, Message= "Good car for picnic" });

            dbcontext.Reviews.Add(new Review { ReservationId = 2, UserSsn = 3, CarId = 2, Rate = 4, Message = "Good car for family trip" });

            dbcontext.Reviews.Add(new Review { ReservationId = 3, UserSsn = 3, CarId = 3, Rate = 3, Message = "Good car for long trip" });
            dbcontext.SaveChanges();
            #endregion


        }





    }
}
